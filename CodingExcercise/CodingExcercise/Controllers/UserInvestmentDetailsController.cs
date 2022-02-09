using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CodingExcercise.Data;
using CodingExcercise.Models;

namespace CodingExcercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInvestmentDetailsController : ControllerBase
    {
        private readonly FinanceContext _context;

        public UserInvestmentDetailsController(FinanceContext context)
        {
            _context = context;
        }

        //This will pull data from the Joined User, Stock, and Transcation tables.  Joined by UserID on User and Transcation tables and StockID by Stock and Transactions tables.  Constructor for UserInvestmentDetails will calculate some values when new objects are instantiated.
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<UserInvestmentDetails>>> GetUser(int id)
        {
            List<UserInvestmentDetails> InvestmentDetailList = new List<UserInvestmentDetails>();
            try
            {
                InvestmentDetailList = await (from u in _context.Users
                               join t in _context.Transactions
                                   on u.UserID equals t.UserID
                               join s in _context.Investment
                               on t.InvestmentID equals s.InvestmentID
                               where u.UserID == id
                               select new UserInvestmentDetails(t.PurchasePrice, s.CurrentPrice, t.SharesPurchased, t.PurchaseDate)
                               ).ToListAsync();
                
            }
            catch(Exception e)
            {
                Console.WriteLine("An exception" + e.Source + "occurred." + e.Message);
            }
            return InvestmentDetailList;
        }
    }
}
