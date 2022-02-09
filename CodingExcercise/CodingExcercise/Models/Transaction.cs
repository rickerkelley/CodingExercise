using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingExcercise.Models
{
    //Represents a Transcation table that keeps track of when Investment is purchased by a specific user.  Captures a snapshot of information (PurchaseDate, SharesPurchased, and PurchasePrice) from time of purchase.
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        [ForeignKey("Investment")]
        public int InvestmentID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int SharesPurchased { get; set; }
        public decimal PurchasePrice { get; set; }
    }
}
