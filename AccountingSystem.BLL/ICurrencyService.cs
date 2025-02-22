using AccountingSystem.Models.Entities;

namespace AccountingSystem.BLL
{
    public interface ICurrencyService
    {
        public IEnumerable<Currency> GetAllCurrencys();
        public Currency GetCurrencyById(int currencyId);
        public Currency GetCurrencyByCode(string currencyCode);
        public int InsertCurrency(Currency currency);
        public int UpdateCurrency(Currency currency);
        public int DeleteCurrency(int currencyId);
    }
}
