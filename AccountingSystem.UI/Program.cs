using AccountingSystem.BLL;
using AccountingSystem.DAL;
using AccountingSystem.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace AccountingSystem.UI
{
    internal static class Program
    {
        #region Main method
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug() // Set your desired minimum log level
                .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day) // Log to a file
                .CreateLogger();

            try
            {
                Log.Information("Application starting up");

                var host = CreateHostBuilder().Build();

                ApplicationConfiguration.Initialize();

                // Retrieve the main form from the DI container
                var mainForm = host.Services.GetRequiredService<MainForm>();

                // Run the application
                Application.Run(mainForm);

                // Dispose of the host to ensure graceful shutdown
                host.Dispose();

                Log.Information("Application shutting down gracefully");
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Application terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
        #endregion

        #region Dependencies
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .UseSerilog() // Integrate Serilog into the host
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<DapperContext>();
                    services.AddTransient<ChartOfAccountsRepository>();
                    services.AddTransient<IChartOfAccountService, ChartOfAccountService>();
                    services.AddTransient<TransactionRepository>();
                    services.AddTransient<ITransactionService, TransactionService>();
                    services.AddTransient<CurrencyRepository>();
                    services.AddTransient<ICurrencyService, CurrencyService>();
                    services.AddTransient<VATTaxRepository>();
                    services.AddTransient<IVATTaxService, VATTaxService>();
                    services.AddTransient<ReportRepository>();
                    services.AddTransient<IReportService, ReportService>();

                    services.AddTransient<MainForm>();
                });
        } 
        #endregion
    }
}