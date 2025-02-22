using AccountingSystem.BLL;

namespace AccountingSystem.UI
{
    public partial class VAT_TaxForm : Form
    {
        private readonly IVATTaxService _vatTaxService;
        public VAT_TaxForm(IVATTaxService vATTaxService)
        {
            InitializeComponent();
            _vatTaxService = vATTaxService;
        }
    }
}
