using AccountingSystem.BLL;

namespace AccountingSystem.UI
{
    public partial class ChartOfAccountsForm : Form
    {
        private readonly IChartOfAccountService _chartOfAccountService;
        public ChartOfAccountsForm(IChartOfAccountService chartOfAccountService)
        {
            InitializeComponent();
            _chartOfAccountService = chartOfAccountService;
        }
    }
}
