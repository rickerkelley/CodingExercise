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
    public class UserTransactionsController : ControllerBase
    {
        private readonly FinanceContext _context;
        public UserTransactionsController(FinanceContext context)
        {
            _context = context;
        }

        // GET: api/Transactions
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<UserTransaction>>> GetTransactions(int id)
        {
            //Populate this list with a join across User, Transaction, and Investment tables to retrieve relevant fields.  Populates data into UserTranscation objects which are returned in List.
            List<UserTransaction> TransactionList = new List<UserTransaction>();
            try
            {
                TransactionList = await (from u in _context.Users
                           join t in _context.Transactions
                               on u.UserID equals t.UserID
                           join i in _context.Investment
                           on t.InvestmentID equals i.InvestmentID
                           where u.UserID == id
                           select new UserTransaction
                           {
                               InvestmentID = i.InvestmentID,
                               InvestmentName = i.Name
                           })
             .ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception" + e.Source + "occurred." + e.Message);
            }
           
            return TransactionList;
        }
    }
}
