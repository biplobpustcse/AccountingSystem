using AccountingSystem.BLL;
using AccountingSystem.UI.Operation;
using System;
using System.Windows.Forms;

namespace AccountingSystem.UI
{
    public partial class MainForm : Form
    {
        private readonly IChartOfAccountService _chartOfAccountService;
        private readonly ITransactionService _transactionService;
        private readonly ITransactionDetailService _transactionDetailService;
        private readonly ICurrencyService _currencyService;
        private readonly IVATTaxService _vatTaxService;

        public MainForm(IChartOfAccountService chartOfAccountService,
            ITransactionService transactionService,
            ITransactionDetailService transactionDetailService,
            ICurrencyService currencyService,
            IVATTaxService vatTaxService)
        {
            InitializeComponent();
            _chartOfAccountService = chartOfAccountService;
            _transactionService = transactionService;
            _transactionDetailService = transactionDetailService;
            _currencyService = currencyService;
            _vatTaxService = vatTaxService;
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
            OpenForm(new TransactionsForm(_transactionService));
        }

        private void transactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new TransactionDetailsForm(_transactionDetailService));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenForm(Form form)
        {
            form.ShowDialog();
        }
    }
}