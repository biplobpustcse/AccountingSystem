using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccountingSystem.Models.Entities
{
    public class ChartOfAccount
    {
        [Key]
        public int AccountID { get; set; }

        [Required, MaxLength(50)]
        public string AccountNumber { get; set; }

        [Required, MaxLength(255)]
        public string AccountName { get; set; }

        [Required, MaxLength(50)]
        public string AccountType { get; set; } // Consider using an enum for AccountType

        [MaxLength(255)]
        public string AccountGroup { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal OpeningBalance { get; set; } = 0;
        public int CurrencyID { get; set; }
        public VATTax VATTax { get; set; }
        public bool IsActive { get; set; } = true;

        public ICollection<TransactionDetail> DebitTransactionDetails { get; set; }
        public ICollection<TransactionDetail> CreditTransactionDetails { get; set; }
        public ICollection<TrialBalance> TrialBalances { get; set; }
        public ICollection<GeneralLedger> GeneralLedgers { get; set; }
        public ICollection<BalanceSheet> BalanceSheets { get; set; }
        public ICollection<IncomeStatement> IncomeStatements { get; set; }
    }
}
