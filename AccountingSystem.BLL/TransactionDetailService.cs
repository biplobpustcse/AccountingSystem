using AccountingSystem.DAL.Repositories;
using AccountingSystem.Models.Entities;
using Microsoft.Identity.Client;

namespace AccountingSystem.BLL
{
    public class TransactionDetailDetailService : ITransactionDetailService
    {
        private readonly TransactionDetailRepository _repository;
        public TransactionDetailDetailService(TransactionDetailRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<TransactionDetail> GetAllTransactionDetails()=> _repository.GetAll();
        public TransactionDetail GetTransactionDetailById(int transactionDetailId) => _repository.GetById(transactionDetailId);
        public int InsertTransactionDetail(TransactionDetail transactionDetail) => _repository.Insert(transactionDetail);
        public int UpdateTransactionDetail(TransactionDetail transactionDetail) => _repository.Update(transactionDetail);
        public int DeleteTransactionDetail(int transactionDetailId) => _repository.Delete(transactionDetailId);
    }
}
