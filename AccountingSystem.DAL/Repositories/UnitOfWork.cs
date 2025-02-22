
namespace AccountingSystem.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AccountingDbContext _context;

        public UnitOfWork(AccountingDbContext context)
        {
            _context = context;
            ChartOfAccounts = new ChartOfAccountsRepository(_context);
            // Initialize other repositories here
        }

        public IChartOfAccountsRepository ChartOfAccounts { get; private set; }
        // Add other repository properties here

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
