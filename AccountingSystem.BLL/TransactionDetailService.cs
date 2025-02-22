using AccountingSystem.DAL.Repositories;
using AccountingSystem.Models.Entities;
using Microsoft.Identity.Client;
using System.Data;

namespace AccountingSystem.BLL
{
    public class TransactionDetailDetailService : ITransactionDetailService
    {
        private readonly TransactionDetailRepository _repository;
        public TransactionDetailDetailService(TransactionDetailRepository repository)
        {
            _repository = repository;
        }
        public IDbConnection GetConnection()=> _repository.GetConnection();
        public IEnumerable<TransactionDetail> GetAllTransactionDetails()=> _repository.GetAll();
        public TransactionDetail GetTransactionDetailById(int transactionDetailId) => _repository.GetById(transactionDetailId);
        public IEnumerable<TransactionDetail> GetTransactionDetailByTransactionId(int transactionId) => _repository.GetByTransactionId(transactionId);
        public int InsertTransactionDetail(TransactionDetail transactionDetail) => _repository.Insert(transactionDetail);
        public int UpdateTransactionDetail(TransactionDetail transactionDetail) => _repository.Update(transactionDetail);
        public void DeleteTransactionDetail(int transactionDetailId, IDbTransaction transaction) => _repository.Delete(transactionDetailId, transaction);
        public void DeleteTransactionDetailByTransactionId(int transactionId, IDbTransaction transaction) => _repository.DeleteByTransactionId(transactionId, transaction);
    }
}
