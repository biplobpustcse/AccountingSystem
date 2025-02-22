using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccountingSystem.Models.Entities
{
    public class TransactionDetail
    {
        public int DetailID { get; set; }
        public int TransactionID { get; set; }
        public int DebitAccountID { get; set; }
        public int CreditAccountID { get; set; }
        public decimal Amount { get; set; }
        public int? VATID { get; set; }
        public decimal VATAmount { get; set; }
        public int CurrencyID { get; set; }
    }
}
