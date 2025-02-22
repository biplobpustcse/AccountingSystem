using AccountingSystem.DAL.Repositories;
using AccountingSystem.Models.Entities;
using Microsoft.Identity.Client;

namespace AccountingSystem.BLL
{
    public class TransactionService : ITransactionService
    {
        private readonly TransactionRepository _repository;
        public TransactionService(TransactionRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Transaction> GetAllTransactions()=> _repository.GetAll();
        public Transaction GetTransactionById(int transactionId) => _repository.GetById(transactionId);
        public int InsertTransaction(Transaction transaction) => _repository.Insert(transaction);
        public int UpdateTransaction(Transaction transaction) => _repository.Update(transaction);
        public int DeleteTransaction(int transactionId) => _repository.Delete(transactionId);
    }
}
