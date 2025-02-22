using AccountingSystem.BLL;
using AccountingSystem.Models.Entities;

namespace AccountingSystem.UI
{
    public partial class TransactionDetailsForm : Form
    {
        private readonly ITransactionDetailService _transactionDetailService;
        private readonly IChartOfAccountService _chartOfAccountService;
        private readonly IVATTaxService _vatTaxService;
        private readonly ICurrencyService _currencyService;
        private readonly int _transactionId;

        public TransactionDetailsForm(ITransactionDetailService transactionDetailService, IChartOfAccountService chartOfAccountService, IVATTaxService vatTaxService, ICurrencyService currencyService, int transactionId)
        {
            InitializeComponent();
            _transactionDetailService = transactionDetailService;
            _chartOfAccountService = chartOfAccountService;
            _vatTaxService = vatTaxService;
            _currencyService = currencyService;
            _transactionId = transactionId;
            LoadTransactionDetails();
            LoadAccounts();
            LoadVATTaxes();
            LoadCurrencies();
        }

        private void LoadTransactionDetails()
        {
            try
            {
                transactionDetailsDataGridView.DataSource = _transactionDetailService.GetTransactionDetailByTransactionId(_transactionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transaction details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAccounts()
        {
            try
            {
                List<ChartOfAccount> accounts = _chartOfAccountService.GetAllChartOfAccounts().ToList();
                debitAccountComboBox.DataSource = accounts;
                debitAccountComboBox.DisplayMember = "AccountName";
                debitAccountComboBox.ValueMember = "AccountID";

                creditAccountComboBox.DataSource = accounts.ToList();
                creditAccountComboBox.DisplayMember = "AccountName";
                creditAccountComboBox.ValueMember = "AccountID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading accounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadVATTaxes()
        {
            try
            {
                List<VATTax> vatTaxes = _vatTaxService.GetAllVATTaxs().ToList();
                vatComboBox.DataSource = vatTaxes;
                vatComboBox.DisplayMember = "VATRate";
                vatComboBox.ValueMember = "VATID";

                vatComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading VAT taxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrencies()
        {
            try
            {
                List<Currency> currencies = _currencyService.GetAllCurrencys().ToList();
                currencyComboBox.DataSource = currencies;
                currencyComboBox.DisplayMember = "CurrencyCode";
                currencyComboBox.ValueMember = "CurrencyID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Currencies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionDetail detail = new TransactionDetail
                {
                    TransactionID = _transactionId,
                    DebitAccountID = (int)debitAccountComboBox.SelectedValue,
                    CreditAccountID = (int)creditAccountComboBox.SelectedValue,
                    Amount = amountNumericUpDown.Value,
                    VATID = (int)vatComboBox.SelectedValue,
                    CurrencyID = (int)currencyComboBox.SelectedValue
                };

                _transactionDetailService.InsertTransactionDetail(detail);
                LoadTransactionDetails();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding transaction detail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(detailIdTextBox.Text))
            {
                MessageBox.Show("Please select a transaction detail to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                TransactionDetail detail = new TransactionDetail
                {
                    DetailID = int.Parse(detailIdTextBox.Text),
                    TransactionID = _transactionId,
                    DebitAccountID = (int)debitAccountComboBox.SelectedValue,
                    CreditAccountID = (int)creditAccountComboBox.SelectedValue,
                    Amount = amountNumericUpDown.Value,
                    VATID = (int)vatComboBox.SelectedValue,
                    CurrencyID = (int)currencyComboBox.SelectedValue
                };

                _transactionDetailService.UpdateTransactionDetail(detail);
                LoadTransactionDetails();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating transaction detail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(detailIdTextBox.Text))
            {
                MessageBox.Show("Please select a transaction detail to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int detailId = int.Parse(detailIdTextBox.Text);
               

                using (var connection = _transactionDetailService.GetConnection()) // Get a connection
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction()) // Begin a transaction
                    {
                        try
                        {
                            _transactionDetailService.DeleteTransactionDetail(detailId, transaction);
                            LoadTransactionDetails();
                            ClearInputFields();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Rollback on error
                            MessageBox.Show($"Error deleting transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting transaction detail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void transactionDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = transactionDetailsDataGridView.Rows[e.RowIndex];
                detailIdTextBox.Text = row.Cells["DetailID"].Value.ToString();
                debitAccountComboBox.SelectedValue = row.Cells["DebitAccountID"].Value;
                creditAccountComboBox.SelectedValue = row.Cells["CreditAccountID"].Value;
                amountNumericUpDown.Value = Convert.ToDecimal(row.Cells["Amount"].Value);
                vatComboBox.SelectedValue = row.Cells["VATID"].Value;
                currencyComboBox.SelectedValue = row.Cells["CurrencyID"].Value;
            }
        }

        private void ClearInputFields()
        {
            detailIdTextBox.Clear();
            debitAccountComboBox.SelectedIndex = -1;
            creditAccountComboBox.SelectedIndex = -1;
            amountNumericUpDown.Value = 0;
            vatComboBox.SelectedIndex = 0;
            currencyComboBox.SelectedIndex = -1;
        }
    }
}