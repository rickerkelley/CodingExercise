using System;
namespace CodingExcercise.Models
{
    //This class represents the data strucuture for data returned by the API via the UserInvestmentDetailsController.  Class constructor calculates values for CurrentValue, Term and TotalGainLoss.
    public class UserInvestmentDetails
    {
        public decimal CostBasis { get; set; }
        public decimal CurrentValue { get; set; }
        public decimal CurrentPrice { get; set; }
        public string Term { get; set; }
        public decimal TotalGainLoss { get; set; }

        public UserInvestmentDetails(decimal costbasis, decimal currentprice, int sharespurchased, DateTime purchasedate)
        {
            CostBasis = costbasis;
            CurrentPrice = currentprice;
            //Current value is current price * shares purchased
            CurrentValue = currentprice * sharespurchased;
            //checks to see if Purchase Date is within the past year by comparing to see if greater than or equal to current time minus 1 year.  If greater than this, occured int he past year (Short Term), otherwise occured more than a year ago (Long Term).
            if (purchasedate.Date >= DateTime.Now.AddYears(-1))
            {
                Term = "Short Term";
            }
            else
            {
                Term = "Long Term";
            }
            // This total is the Current value minus the value at purchase (cost basis * shares purchased)
            TotalGainLoss = CurrentValue - (CostBasis * sharespurchased);
        }
    }
}
