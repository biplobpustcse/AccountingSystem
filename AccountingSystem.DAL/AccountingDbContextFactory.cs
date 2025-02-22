using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AccountingSystem.DAL
{
    public class AccountingDbContextFactory : IDesignTimeDbContextFactory<AccountingDbContext>
    {
        public AccountingDbContext CreateDbContext(string[] args)
        {
            //// Build configuration from appsettings.json
            //var configuration = new ConfigurationBuilder()
            //    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)  // Set base path for configuration
            //    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Add json config file
            //    .Build();

            var aaa = Directory.GetCurrentDirectory();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // This is where SetBasePath is used
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection"); // Replace with your connection string name

            var optionsBuilder = new DbContextOptionsBuilder<AccountingDbContext>();
            optionsBuilder.UseSqlServer(connectionString); // Replace with your database provider

            return new AccountingDbContext(optionsBuilder.Options);
        }
    }
}
