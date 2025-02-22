using AccountingSystem.BLL;
using AccountingSystem.Models.Entities;

namespace AccountingSystem.UI
{
    public partial class TransactionsForm : Form
    {
        private readonly ITransactionService _transactionService;
        private readonly ITransactionDetailService _transactionDetailService;
        private readonly IChartOfAccountService _chartOfAccountService;
        private readonly IVATTaxService _vatTaxService;
        private readonly ICurrencyService _currencyService;
        private MainForm _mainForm; // Add a field to store a reference to MainForm
        private int transactionCounter = 1;

        public TransactionsForm(ITransactionService transactionService, ITransactionDetailService transactionDetailService, IChartOfAccountService chartOfAccountService, IVATTaxService vatTaxService, ICurrencyService currencyService, MainForm mainForm)
        {
            InitializeComponent();
            _transactionService = transactionService;
            _transactionDetailService = transactionDetailService;
            _chartOfAccountService = chartOfAccountService;
            _vatTaxService = vatTaxService;
            _currencyService = currencyService;
            _mainForm = mainForm;
            LoadTransactions();
        }

        private void LoadTransactions()
        {
            try
            {
                transactionsDataGridView.DataSource = _transactionService.GetAllTransactions();
                GenerateTransactionNumber();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading transactions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Transaction transaction = new Transaction
                {
                    TransactionDate = transactionDateDateTimePicker.Value.Date,
                    TransactionNumber = transactionNumberTextBox.Text,
                    Description = descriptionTextBox.Text,
                    Reference = referenceTextBox.Text
                };

                transaction.TransactionID = _transactionService.InsertTransaction(transaction);
                LoadTransactions();
                ClearInputFields();

                // Pass the transaction ID back to MainForm
                _mainForm.SetTransactionId(transaction.TransactionID);
                // Open Transaction Details Form
                TransactionDetailsForm detailsForm = new TransactionDetailsForm(_transactionDetailService, _chartOfAccountService, _vatTaxService, _currencyService, transaction.TransactionID);
                detailsForm.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(transactionIdTextBox.Text))
            {
                MessageBox.Show("Please select a transaction to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Transaction transaction = new Transaction
                {
                    TransactionID = int.Parse(transactionIdTextBox.Text),
                    TransactionDate = transactionDateDateTimePicker.Value.Date,
                    TransactionNumber = transactionNumberTextBox.Text,
                    Description = descriptionTextBox.Text,
                    Reference = referenceTextBox.Text
                };

                _transactionService.UpdateTransaction(transaction);
                LoadTransactions();
                ClearInputFields();

                // Pass the transaction ID back to MainForm
                _mainForm.SetTransactionId(transaction.TransactionID);
                // Open Transaction Details Form
                TransactionDetailsForm detailsForm = new TransactionDetailsForm(_transactionDetailService, _chartOfAccountService, _vatTaxService, _currencyService, transaction.TransactionID);
                detailsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(transactionIdTextBox.Text))
            {
                MessageBox.Show("Please select a transaction to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int transactionId = int.Parse(transactionIdTextBox.Text);

                using (var connection = _transactionService.GetConnection()) // Get a connection
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction()) // Begin a transaction
                    {
                        try
                        {
                            _transactionDetailService.DeleteTransactionDetail(transactionId, transaction);
                            _transactionService.DeleteTransaction(transactionId, transaction);

                            transaction.Commit(); // Commit the transaction
                            LoadTransactions();
                            ClearInputFields();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Rollback on error
                            MessageBox.Show($"Error deleting transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                //_transactionService.DeleteTransaction(transactionId);
                //_transactionDetailService.DeleteTransactionDetail(transactionId);
                LoadTransactions();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            }
        }
        private void GenerateTransactionNumber()
        {
            string datePart = DateTime.Now.ToString("yyyyMMdd");
            string counterPart = transactionCounter.ToString("D5"); // 5 digits
            transactionCounter++;
            transactionNumberTextBox.Text = $"TXN-{datePart}-{counterPart}";
        }

        private void ClearInputFields()
        {
            transactionIdTextBox.Clear();
            transactionDateDateTimePicker.Value = DateTime.Now;
            transactionNumberTextBox.Clear();
            descriptionTextBox.Clear();
            referenceTextBox.Clear();
        }
    }
}