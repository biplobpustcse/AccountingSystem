using AccountingSystem.DAL.Repositories;
using AccountingSystem.Models.Entities;

namespace AccountingSystem.BLL
{
    public class ReportService : IReportService
    {
        private readonly ReportRepository _repository;

        public ReportService(ReportRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<TrialBalance> GetTrialBalance(DateTime endDate)
        {
            return _repository.GetTrialBalance(endDate);
        }

        public IEnumerable<GeneralLedger> GetGeneralLedger(int accountId, DateTime startDate, DateTime endDate)
        {
            return _repository.GetGeneralLedger(accountId, startDate, endDate);
        }

        public IEnumerable<dynamic> GetBalanceSheet(DateTime asOfDate)
        {
            return _repository.GetBalanceSheet(asOfDate);
        }

        public IEnumerable<dynamic> GetIncomeStatement(DateTime startDate, DateTime endDate)
        {
            return _repository.GetIncomeStatement(startDate, endDate);
        }
    }
}