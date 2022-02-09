using System.ComponentModel.DataAnnotations;

namespace CodingExcercise.Models
{
    //represents Investment table, an assumption is made on this that a Current Price is periodically updated here rather than calling to an outside API for this info
    public class Investment
    {
        [Key]
        public int InvestmentID { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public decimal CurrentPrice { get; set; }
    }
}
