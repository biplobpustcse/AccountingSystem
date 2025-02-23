using AccountingSystem.Models.Entities;
using System.Data;

namespace AccountingSystem.BLL
{
    public interface ITransactionService
    {
        IDbConnection GetConnection();
        public IEnumerable<Transaction> GetAllTransactions();
        public Transaction GetTransactionById(int transactionId);
        public int InsertTransaction(Transaction transaction);
        public int UpdateTransaction(Transaction transaction);
        public void DeleteTransaction(int transactionId);
        public IEnumerable<Transaction> SearchTransactions(DateTime? startDate, DateTime? endDate, string descriptionFilter, int? debitAccountId, int? creditAccountId);
    }
}
