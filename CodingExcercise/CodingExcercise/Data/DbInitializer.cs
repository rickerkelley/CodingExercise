using System;
using CodingExcercise.Models;

namespace CodingExcercise.Data
{

    public class DbInitializer
    {
        //creates sample data into database
        public static void Initialize(FinanceContext context)
        {
            context.Database.EnsureCreated();

            context.Users.Add(new User { UserID = 1, FirstName = "Doug", LastName = "Samuel" });
            context.Users.Add(new User { UserID = 2, FirstName = "Fred", LastName = "Jones" });
            context.Users.Add(new User { UserID = 3, FirstName = "Jeremy", LastName = "Smith" });

            context.SaveChanges();

            context.Investment.Add(new Investment { InvestmentID = 1, Name = "Apple", Symbol = "AAPL", CurrentPrice = 175.00M });
            context.Investment.Add(new Investment { InvestmentID = 2, Name = "Microsoft", Symbol = "MSFT", CurrentPrice = 200.00M });

            context.SaveChanges();

            context.Transactions.Add(new Transaction { TransactionID = 1, InvestmentID = 1, UserID = 1, SharesPurchased = 2, PurchaseDate = new DateTime(2019, 1, 5), PurchasePrice = 110.00M});
            context.Transactions.Add(new Transaction { TransactionID = 2, InvestmentID = 2, UserID = 1, SharesPurchased = 1, PurchaseDate = new DateTime(2020, 11, 15), PurchasePrice = 100.00M });
            context.Transactions.Add(new Transaction { TransactionID = 3, InvestmentID = 2, UserID = 2, SharesPurchased = 3, PurchaseDate = new DateTime(2021, 11, 15), PurchasePrice = 120.00M });
            context.Transactions.Add(new Transaction { TransactionID = 4, InvestmentID = 1, UserID = 3, SharesPurchased = 3, PurchaseDate = new DateTime(2021, 11, 15), PurchasePrice = 250.00M });

            context.SaveChanges();
        }
    } 
}
