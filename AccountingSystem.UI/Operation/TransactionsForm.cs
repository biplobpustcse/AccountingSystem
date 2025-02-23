using AccountingSystem.Models.Entities;
using AccountingSystem.DAL.Repositories;
using AccountingSystem.BLL;

namespace AccountingSystem.UI
{
    public partial class TransactionsForm : Form
    {
        private readonly IChartOfAccountService _chartOfAccountService;
        private readonly ITransactionService _transactionService;
        private readonly ICurrencyService _currencyService;
        private readonly IVATTaxService _vatTaxService;
        private int transactionCounter = 1;

        public TransactionsForm(ITransactionService transactionService, IChartOfAccountService chartOfAccountService, IVATTaxService vatTaxService, ICurrencyService currencyService)
        {
            InitializeComponent();
            _transactionService = transactionService;
            _chartOfAccountService = chartOfAccountService;
            _vatTaxService = vatTaxService;
            _currencyService = currencyService;

            LoadTransactions();
            LoadComboBoxes();

            addButton.Enabled = true;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        private void LoadTransactions()
        {
            try
            {
                transactionsDataGridView.DataSource = _transactionService.GetAllTransactions();
                transactionNumberTextBox.Text = GenerateTransactionNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            debitAccountComboBox.DataSource = _chartOfAccountService.GetAllChartOfAccounts().ToList();
            debitAccountComboBox.DisplayMember = "AccountName";
            debitAccountComboBox.ValueMember = "AccountID";

            creditAccountComboBox.DataSource = _chartOfAccountService.GetAllChartOfAccounts().ToList();
            creditAccountComboBox.DisplayMember = "AccountName";
            creditAccountComboBox.ValueMember = "AccountID";

            vatComboBox.DataSource = _vatTaxService.GetAllVATTaxs().ToList();
            vatComboBox.DisplayMember = "VATRate";
            vatComboBox.ValueMember = "VATID";
            vatComboBox.SelectedIndex = -1;

            currencyComboBox.DataSource = _currencyService.GetAllCurrencys().ToList();
            currencyComboBox.DisplayMember = "CurrencyCode";
            currencyComboBox.ValueMember = "CurrencyID";
        }

        private void ClearForm()
        {
            transactionIdTextBox.Text = "";
            transactionDateDateTimePicker.Value = DateTime.Now;
            transactionNumberTextBox.Text = "";
            descriptionTextBox.Text = "";
            referenceTextBox.Text = "";
            debitAccountComboBox.SelectedIndex = -1;
            creditAccountComboBox.SelectedIndex = -1;
            amountNumericUpDown.Value = 0;
            vatComboBox.SelectedIndex = -1;
            currencyComboBox.SelectedIndex = -1;
        }

        private void transactionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = transactionsDataGridView.Rows[e.RowIndex];
                transactionIdTextBox.Text = row.Cells["TransactionID"].Value.ToString();
                transactionDateDateTimePicker.Value = Convert.ToDateTime(row.Cells["TransactionDate"].Value);
                transactionNumberTextBox.Text = row.Cells["TransactionNumber"].Value.ToString();
                descriptionTextBox.Text = row.Cells["Description"].Value.ToString();
                referenceTextBox.Text = row.Cells["Reference"].Value.ToString();

                debitAccountComboBox.SelectedValue = row.Cells["DebitAccountID"].Value;
                creditAccountComboBox.SelectedValue = row.Cells["CreditAccountID"].Value;
                amountNumericUpDown.Value = Convert.ToDecimal(row.Cells["Amount"].Value);

                if (row.Cells["VATID"].Value != DBNull.Value)
                {
                    vatComboBox.SelectedValue = row.Cells["VATID"].Value;
                }
                else
                {
                    vatComboBox.SelectedIndex = -1;
                }

                currencyComboBox.SelectedValue = row.Cells["CurrencyID"].Value;

                addButton.Enabled = false;
                updateButton.Enabled = true;
                deleteButton.Enabled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction transaction = new Transaction
                {
                    TransactionDate = transactionDateDateTimePicker.Value,
                    TransactionNumber = transactionNumberTextBox.Text,
                    Description = descriptionTextBox.Text,
                    Reference = referenceTextBox.Text,
                    DebitAccountID = (int)debitAccountComboBox.SelectedValue,
                    CreditAccountID = (int)creditAccountComboBox.SelectedValue,
                    Amount = amountNumericUpDown.Value,
                    VATID = vatComboBox.SelectedValue != null ? (int?)vatComboBox.SelectedValue : null,
                    CurrencyID = (int)currencyComboBox.SelectedValue
                };

                _transactionService.InsertTransaction(transaction);
                ClearForm();
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(transactionIdTextBox.Text))
                {
                    MessageBox.Show("Please select a transaction to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Transaction transaction = new Transaction
                {
                    TransactionID = int.Parse(transactionIdTextBox.Text),
                    TransactionDate = transactionDateDateTimePicker.Value,
                    TransactionNumber = transactionNumberTextBox.Text,
                    Description = descriptionTextBox.Text,
                    Reference = referenceTextBox.Text,
                    DebitAccountID = (int)debitAccountComboBox.SelectedValue,
                    CreditAccountID = (int)creditAccountComboBox.SelectedValue,
                    Amount = amountNumericUpDown.Value,
                    VATID = vatComboBox.SelectedValue != null ? (int?)vatComboBox.SelectedValue : null,
                    CurrencyID = (int)currencyComboBox.SelectedValue
                };

                _transactionService.UpdateTransaction(transaction);
                ClearForm();
                LoadTransactions();

                addButton.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(transactionIdTextBox.Text))
                {
                    MessageBox.Show("Please select a transaction to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int transactionId = int.Parse(transactionIdTextBox.Text);
                _transactionService.DeleteTransaction(transactionId);
                ClearForm();
                LoadTransactions();

                addButton.Enabled = true;
                updateButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateTransactionNumber()
        {
            string datePart = DateTime.Now.ToString("yyyyMMdd");
            string counterPart = transactionCounter.ToString("D5"); // 5 digits
            transactionCounter++;
            return $"TXN-{datePart}-{counterPart}";
        }
    }
}