namespace AccountingSystem.Models.Entities
{
    public class TrialBalance
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal DebitBalance { get; set; }
        public decimal CreditBalance { get; set; }
    }
}
