using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AccountingSystem.Models.Entities
{
    public class VATTax
    {
        public int VATID { get; set; }
        public decimal VATRate { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
