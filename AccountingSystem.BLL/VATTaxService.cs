using AccountingSystem.DAL.Repositories;
using AccountingSystem.Models.Entities;
using Microsoft.Identity.Client;

namespace AccountingSystem.BLL
{
    public class VATTaxService : IVATTaxService
    {
        private readonly VATTaxRepository _repository;
        public VATTaxService(VATTaxRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<VATTax> GetAllVATTaxs()=> _repository.GetAll();
        public VATTax GetVATTaxById(int vatId) => _repository.GetById(vatId);
        public int InsertVATTax(VATTax vatTax) => _repository.Insert(vatTax);
        public int UpdateVATTax(VATTax vatTax) => _repository.Update(vatTax);
        public int DeleteVATTax(int vatId) => _repository.Delete(vatId);
    }
}
