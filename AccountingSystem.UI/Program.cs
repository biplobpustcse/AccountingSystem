using AccountingSystem.DAL;
using AccountingSystem.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AccountingSystem.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            var host = CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();

            // Retrieve the main form from the DI container
            var mainForm = host.Services.GetRequiredService<MainForm>();

            // Run the application
            Application.Run(mainForm);

            // Dispose of the host to ensure graceful shutdown
            host.Dispose();
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Retrieve the connection string from configuration
                    var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
                    //var connectionString = "Server=BIPLOB\\SQL2019;Database=DualAccountingDB;User Id=sa;Password=data;";

                    // Register the DbContext with the connection string
                    services.AddDbContext<AccountingDbContext>(options =>
                        options.UseSqlServer(connectionString));

                    //// Register repositories, Unit of Work, and forms
                    //services.AddScoped<IChartOfAccountsRepository, ChartOfAccountsRepository>();
                    //services.AddScoped<IUnitOfWork, UnitOfWork>();
                    services.AddTransient<MainForm>();
                    // Register other forms as needed
                });
        }

    }
}