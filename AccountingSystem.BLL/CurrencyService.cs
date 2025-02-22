using AccountingSystem.DAL.Repositories;
using AccountingSystem.Models.Entities;
using Microsoft.Identity.Client;

namespace AccountingSystem.BLL
{
    public class CurrencyService : ICurrencyService
    {
        private readonly CurrencyRepository _repository;
        public CurrencyService(CurrencyRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Currency> GetAllCurrencys()=> _repository.GetAll();
        public Currency GetCurrencyById(int currencyId) => _repository.GetById(currencyId);
        public Currency GetCurrencyByCode(string currencyCode) => _repository.GetByCode(currencyCode);
        public int InsertCurrency(Currency currency) => _repository.Insert(currency);
        public int UpdateCurrency(Currency currency) => _repository.Update(currency);
        public int DeleteCurrency(int currencyId) => _repository.Delete(currencyId);
    }
}
