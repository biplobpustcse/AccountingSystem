using AccountingSystem.Models.Entities;
using System.Data;

namespace AccountingSystem.BLL
{
    public interface ITransactionDetailService
    {
        IDbConnection GetConnection();
        public IEnumerable<TransactionDetail> GetAllTransactionDetails();
        public TransactionDetail GetTransactionDetailById(int transactionDetailId);
        public IEnumerable<TransactionDetail> GetTransactionDetailByTransactionId(int transactionId);
        public int InsertTransactionDetail(TransactionDetail transactionDetail);
        public int UpdateTransactionDetail(TransactionDetail transactionDetail);
        public void DeleteTransactionDetail(int transactionDetailId, IDbTransaction transaction);
        public void DeleteTransactionDetailByTransactionId(int transactionId, IDbTransaction transaction);
    }
}
