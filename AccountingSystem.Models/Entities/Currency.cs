namespace AccountingSystem.Models.Entities
{
    public class Currency
    {
        public int CurrencyID { get; set; }
        public string CurrencyCode { get; set; } = "CHF";
        public decimal ExchangeRate { get; set; }
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    }
}
