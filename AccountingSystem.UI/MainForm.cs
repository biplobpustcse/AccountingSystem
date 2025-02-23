using AccountingSystem.BLL;

namespace AccountingSystem.UI
{
    public partial class MainForm : Form
    {
        private readonly IChartOfAccountService _chartOfAccountService;
        private readonly ITransactionService _transactionService;
        private readonly ICurrencyService _currencyService;
        private readonly IVATTaxService _vatTaxService;
        private readonly IReportService _reportService;
        private int _transactionId;

        public MainForm(IChartOfAccountService chartOfAccountService,
            ITransactionService transactionService,
            ICurrencyService currencyService,
            IVATTaxService vatTaxService,
            IReportService reportService)
        {
            InitializeComponent();
            _chartOfAccountService = chartOfAccountService;
            _transactionService = transactionService;
            _currencyService = currencyService;
            _vatTaxService = vatTaxService;
            _reportService = reportService;
        }

        private void currenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new CurrencyForm(_currencyService));
        }

        private void chartOfAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new ChartOfAccountsForm(_chartOfAccountService, _currencyService));
        }

        private void vATTaxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new VAT_TaxForm(_vatTaxService));
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new TransactionsForm(_transactionService, _chartOfAccountService, _vatTaxService, _currencyService));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenForm(Form form)
        {
            form.ShowDialog();
        }
        // Method to set the transaction ID from TransactionsForm
        public void SetTransactionId(int transactionId)
        {
            _transactionId = transactionId;
        }
        private void TrialBalancetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new TrialBalanceForm(_reportService));
        }

        private void generalLedgerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new GeneralLedgerForm(_reportService, _chartOfAccountService));
        }
    }
}