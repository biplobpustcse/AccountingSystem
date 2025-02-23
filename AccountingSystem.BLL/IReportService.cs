using AccountingSystem.Models.Entities;

namespace AccountingSystem.BLL
{
    public interface IReportService
    {
        IEnumerable<TrialBalance> GetTrialBalance(DateTime endDate);
        IEnumerable<GeneralLedger> GetGeneralLedger(int accountId, DateTime startDate, DateTime endDate);
        IEnumerable<dynamic> GetBalanceSheet(DateTime asOfDate);
        IEnumerable<dynamic> GetIncomeStatement(DateTime startDate, DateTime endDate);
    }
}