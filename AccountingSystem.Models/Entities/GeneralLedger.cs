namespace AccountingSystem.Models.Entities
{
    public class GeneralLedger
    {
        public DateTime TransactionDate { get; set; }
        public string TransactionNumber { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }        
    }
}
