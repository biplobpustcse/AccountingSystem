using AccountingSystem.DAL.Repositories;
using AccountingSystem.Models.Entities;
using Microsoft.Identity.Client;

namespace AccountingSystem.BLL
{
    public class ChartOfAccountService: IChartOfAccountService
    {
        private readonly ChartOfAccountsRepository _repository;
        public ChartOfAccountService(ChartOfAccountsRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<ChartOfAccount> GetAllChartOfAccounts()=> _repository.GetAll();
        public ChartOfAccount GetChartOfAccountById(int accountId)=> _repository.GetById(accountId);
        public int InsertChartOfAccount(ChartOfAccount account)=> _repository.Insert(account);
        public int UpdateChartOfAccount(ChartOfAccount account)=> _repository.Update(account);
        public int DeleteChartOfAccount(int accountId)=> _repository.Delete(accountId);
    }
}
