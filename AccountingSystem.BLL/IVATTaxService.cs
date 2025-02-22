using AccountingSystem.Models.Entities;

namespace AccountingSystem.BLL
{
    public interface IVATTaxService
    {
        public IEnumerable<VATTax> GetAllVATTaxs();
        public VATTax GetVATTaxById(int vatId);
        public int InsertVATTax(VATTax vatTax);
        public int UpdateVATTax(VATTax vatTax);
        public int DeleteVATTax(int vatId);
    }
}
