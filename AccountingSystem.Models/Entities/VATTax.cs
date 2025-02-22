using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccountingSystem.Models.Entities
{
    public class VATTax
    {
        [Key]
        public int VATID { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal VATRate { get; set; }

        [Required]
        public DateTime EffectiveDate { get; set; }

        public ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
