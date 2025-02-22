using AccountingSystem.DAL.Repositories;

namespace AccountingSystem.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IChartOfAccountsRepository ChartOfAccounts { get; }
        // Add other repositories here
        Task<int> CompleteAsync();
    }
}
