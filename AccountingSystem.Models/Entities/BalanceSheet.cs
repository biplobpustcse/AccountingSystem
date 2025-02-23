namespace AccountingSystem.Models.Entities
{
    public class BalanceSheet
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public decimal Balance { get; set; }
        public string AccountType { get; set; }
    }
}
