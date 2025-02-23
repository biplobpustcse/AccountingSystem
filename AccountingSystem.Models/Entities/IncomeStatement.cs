using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccountingSystem.Models.Entities
{
    public class IncomeStatement
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
    }
}
