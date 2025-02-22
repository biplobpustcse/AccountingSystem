using System.ComponentModel.DataAnnotations;

namespace AccountingSystem.Models.Entities
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required, MaxLength(50)]
        public string TransactionNumber { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [MaxLength(255)]
        public string Reference { get; set; }

        public ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
