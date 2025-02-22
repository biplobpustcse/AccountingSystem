using AccountingSystem.Models.Entities;

namespace AccountingSystem.BLL
{
    public interface ITransactionService
    {
        public IEnumerable<Transaction> GetAllTransactions();
        public Transaction GetTransactionById(int transactionId);
        public int InsertTransaction(Transaction transaction);
        public int UpdateTransaction(Transaction transaction);
        public int DeleteTransaction(int transactionId);
    }
}
