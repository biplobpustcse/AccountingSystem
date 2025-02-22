using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccountingSystem.Models.Entities
{
    public class GeneralLedger
    {
        [Key]
        public int LedgerID { get; set; }

        [Required]
        public int AccountID { get; set; }
        public ChartOfAccount Account { get; set; }

        [Required]
        public int TransactionID { get; set; }
        public Transaction Transaction { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DebitAmount { get; set; } = 0;

        [Column(TypeName = "decimal(18,2)")]
        public decimal CreditAmount { get; set; } = 0;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; } = 0;
    }
}
