using AccountingSystem.Models.Entities;

namespace AccountingSystem.BLL
{
    public interface ITransactionDetailService
    {
        public IEnumerable<TransactionDetail> GetAllTransactionDetails();
        public TransactionDetail GetTransactionDetailById(int transactionDetailId);
        public int InsertTransactionDetail(TransactionDetail transactionDetail);
        public int UpdateTransactionDetail(TransactionDetail transactionDetail);
        public int DeleteTransactionDetail(int transactionDetailId);
    }
}
