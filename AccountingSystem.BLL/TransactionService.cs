using AccountingSystem.DAL.Repositories;
using AccountingSystem.Models.Entities;
using System.Data;

namespace AccountingSystem.BLL
{
    public class TransactionService : ITransactionService
    {
        private readonly TransactionRepository _repository;
        private readonly IChartOfAccountService _chartOfAccountService;
        private readonly IVATTaxService _vatTaxService;
        public TransactionService(TransactionRepository repository, IChartOfAccountService chartOfAccountService, IVATTaxService vatTaxService)
        {
            _repository = repository;
            _chartOfAccountService = chartOfAccountService;
            _vatTaxService = vatTaxService;
        }
        public IDbConnection GetConnection() => _repository.GetConnection();
        public IEnumerable<Transaction> GetAllTransactions()=> _repository.GetAll();
        public Transaction GetTransactionById(int transactionId) => _repository.GetById(transactionId);
        public int InsertTransaction(Transaction transaction)
        {
            // 1. Validate that the Debit account is not the same as the credit account.
            if (transaction.DebitAccountID == transaction.CreditAccountID)
            {
                throw new Exception("Debit account cannot be the same as credit account.");
            }        
            // 2. Validate VAT Tax.
            if (transaction.VATID != null)
            {
                var vatTax = _vatTaxService.GetVATTaxById((int)transaction.VATID);
                if (vatTax == null || transaction.TransactionDate.Date < vatTax.EffectiveDate.Date)
                {
                    throw new Exception("VAT Tax is not valid for this transaction date.");
                }
            }
            // 3. Calculate VATAmount.
            if (transaction.VATID != null)
            {
                var vatTax = _vatTaxService.GetVATTaxById((int)transaction.VATID);
                transaction.VATAmount = transaction.Amount * (vatTax.VATRate / 100);
            }
            else
            {
                transaction.VATAmount = 0;
            }

            return _repository.Insert(transaction);
        }
        public int UpdateTransaction(Transaction transaction)
        {
            // 1. Validate that the Debit account is not the same as the credit account.
            if (transaction.DebitAccountID == transaction.CreditAccountID)
            {
                throw new Exception("Debit account cannot be the same as credit account.");
            }
            // 2. Validate VAT Tax.
            if (transaction.VATID != null)
            {
                var vatTax = _vatTaxService.GetVATTaxById((int)transaction.VATID);
                if (vatTax == null || transaction.TransactionDate.Date < vatTax.EffectiveDate.Date)
                {
                    throw new Exception("VAT Tax is not valid for this transaction date.");
                }
            }
            // 3. Calculate VATAmount.
            if (transaction.VATID != null)
            {
                var vatTax = _vatTaxService.GetVATTaxById((int)transaction.VATID);
                transaction.VATAmount = transaction.Amount * (vatTax.VATRate / 100);
            }
            else
            {
                transaction.VATAmount = 0;
            }

            return _repository.Update(transaction);
        }
        public void DeleteTransaction(int transactionId) => _repository.Delete(transactionId);
        public IEnumerable<Transaction> SearchTransactions(DateTime? startDate, DateTime? endDate, string descriptionFilter, int? debitAccountId, int? creditAccountId) => _repository.SearchTransactions(startDate, endDate,descriptionFilter,debitAccountId,creditAccountId);
    }
}
