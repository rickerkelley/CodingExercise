using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingExcercise.Models;
using System;

namespace CodingExcerciseTest
{
    [TestClass]
    public class UserInvestmentDetailsTests
    {
        
        [TestMethod]
        public void TestTerm()
        {
            UserInvestmentDetails DetailsTerm1 = new UserInvestmentDetails(50.00m, 30.00m, 60, DateTime.Now.AddDays(-367));
            Assert.AreEqual(DetailsTerm1.Term, "Long Term");
            UserInvestmentDetails DetailsTerm2 = new UserInvestmentDetails(50.00m, 30.00m, 60, DateTime.Now.AddDays(-7));
            Assert.AreEqual(DetailsTerm2.Term, "Short Term");
        }
        [TestMethod]
        public void TestCurrentValue()
        {
            UserInvestmentDetails DetailsCV1 = new UserInvestmentDetails(50.00m, 30.00m, 60, new DateTime(2007, 1, 5));
            Assert.AreEqual(DetailsCV1.CurrentValue, 1800.00m);
            UserInvestmentDetails DetailsCV2 = new UserInvestmentDetails(50.00m, 45.17m, 30000, new DateTime(2007, 1, 5));
            Assert.AreEqual(DetailsCV2.CurrentValue, 1355100.00m);
        }
        [TestMethod]
        public void TestTotalGainLoss()
        {
            UserInvestmentDetails DetailsTGL1 = new UserInvestmentDetails(50.00m, 30.00m, 60, new DateTime(2007, 1, 5));
            Assert.AreEqual(DetailsTGL1.TotalGainLoss, -1200.00m);
            UserInvestmentDetails DetailsTGL2 = new UserInvestmentDetails(45.17m, 66.76m, 30000, new DateTime(2007, 1, 5));
            Assert.AreEqual(DetailsTGL2.TotalGainLoss, 647700.00m);
        }
    }
}
