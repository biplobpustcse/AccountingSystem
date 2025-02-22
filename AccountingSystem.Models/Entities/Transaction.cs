using System.ComponentModel.DataAnnotations;

namespace AccountingSystem.Models.Entities
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionNumber { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
    }
}
