using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccountingSystem.Models.Entities
{
    public class TransactionDetail
    {
        [Key]
        public int DetailID { get; set; }

        [Required]
        public int TransactionID { get; set; }
        public Transaction Transaction { get; set; }

        [Required]
        public int DebitAccountID { get; set; }
        public ChartOfAccount DebitAccount { get; set; }

        [Required]
        public int CreditAccountID { get; set; }
        public ChartOfAccount CreditAccount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public int? VATID { get; set; }
        public VATTax VATTax { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal VATAmount { get; set; } = 0;
    }
}
