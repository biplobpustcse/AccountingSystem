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
        public int DebitAccountID { get; set; }
        public int CreditAccountID { get; set; }
        public decimal Amount { get; set; }
        public int? VATID { get; set; }
        public decimal VATAmount { get; set; }
        public int CurrencyID { get; set; }
    }
}
