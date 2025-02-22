using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccountingSystem.Models.Entities
{
    public class ChartOfAccount
    {
        public int AccountID { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string AccountGroup { get; set; }
        public decimal OpeningBalance { get; set; }
        public int CurrencyID { get; set; }
        public bool IsActive { get; set; }
    }
}
