using AccountingSystem.Models.Entities;

namespace AccountingSystem.BLL
{
    public interface IChartOfAccountService
    {
        public IEnumerable<ChartOfAccount> GetAllChartOfAccounts();
        public IEnumerable<ChartOfAccount> GetAllActiveChartOfAccounts();
        public ChartOfAccount GetChartOfAccountById(int accountId);
        public int InsertChartOfAccount(ChartOfAccount account);
        public int UpdateChartOfAccount(ChartOfAccount account);
        public int DeleteChartOfAccount(int accountId);
    }
}
