using AccountingSystem.BLL;
using AccountingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace AccountingSystem.UI
{
    public partial class ChartOfAccountsForm : Form
    {
        private readonly IChartOfAccountService _chartOfAccountService;
        private readonly ICurrencyService _currencyService; // Add currency service

        public ChartOfAccountsForm(IChartOfAccountService chartOfAccountService, ICurrencyService currencyService) // Modify constructor
        {
            InitializeComponent();
            _chartOfAccountService = chartOfAccountService;
            _currencyService = currencyService; // Initialize currency service
            LoadChartOfAccounts();
            LoadCurrencies(); // Load currencies into combobox
        }

        private void LoadCurrencies()
        {
            try
            {
                List<Currency> currencies = _currencyService.GetAllCurrencys().ToList();
                currencyComboBox.DataSource = currencies;
                currencyComboBox.DisplayMember = "CurrencyCode"; // Display CurrencyCode
                currencyComboBox.ValueMember = "CurrencyID"; // Store CurrencyID as value
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading currencies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChartOfAccounts()
        {
            try
            {
                chartOfAccountsDataGridView.DataSource = _chartOfAccountService.GetAllChartOfAccounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading chart of accounts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(accountNumberTextBox.Text) && !string.IsNullOrEmpty(accountNameTextBox.Text))
                {
                    ChartOfAccount account = new ChartOfAccount
                    {
                        AccountNumber = accountNumberTextBox.Text,
                        AccountName = accountNameTextBox.Text,
                        AccountType = accountTypeComboBox.SelectedItem.ToString(),
                        AccountGroup = accountGroupTextBox.Text,
                        OpeningBalance = openingBalanceNumericUpDown.Value,
                        CurrencyID = (int)currencyComboBox.SelectedValue, // Get CurrencyID from combobox
                        IsActive = true
                    };
                    _chartOfAccountService.InsertChartOfAccount(account);
                    LoadChartOfAccounts();
                    ClearInputFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding chart of account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(accountIdTextBox.Text))
            {
                MessageBox.Show("Please select an account to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ChartOfAccount account = new ChartOfAccount
                {
                    AccountID = int.Parse(accountIdTextBox.Text),
                    AccountNumber = accountNumberTextBox.Text,
                    AccountName = accountNameTextBox.Text,
                    AccountType = accountTypeComboBox.SelectedItem.ToString(),
                    AccountGroup = accountGroupTextBox.Text,
                    OpeningBalance = openingBalanceNumericUpDown.Value,
                    CurrencyID = (int)currencyComboBox.SelectedValue, // Get CurrencyID from combobox
                    IsActive = isActiveCheckBox.Checked
                };
                _chartOfAccountService.UpdateChartOfAccount(account);
                LoadChartOfAccounts();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating chart of account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(accountIdTextBox.Text))
            {
                MessageBox.Show("Please select an account to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int accountId = int.Parse(accountIdTextBox.Text);
                _chartOfAccountService.DeleteChartOfAccount(accountId);
                LoadChartOfAccounts();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting chart of account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartOfAccountsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = chartOfAccountsDataGridView.Rows[e.RowIndex];
                accountIdTextBox.Text = row.Cells["AccountID"].Value.ToString();
                accountNumberTextBox.Text = row.Cells["AccountNumber"].Value.ToString();
                accountNameTextBox.Text = row.Cells["AccountName"].Value.ToString();
                accountTypeComboBox.SelectedItem = row.Cells["AccountType"].Value.ToString();
                accountGroupTextBox.Text = row.Cells["AccountGroup"].Value.ToString();
                openingBalanceNumericUpDown.Value = Convert.ToDecimal(row.Cells["OpeningBalance"].Value);
                currencyComboBox.SelectedValue = Convert.ToInt32(row.Cells["CurrencyID"].Value); // Set SelectedValue of combobox
                isActiveCheckBox.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);
            }
        }

        private void ClearInputFields()
        {
            accountIdTextBox.Clear();
            accountNumberTextBox.Clear();
            accountNameTextBox.Clear();
            accountTypeComboBox.SelectedIndex = -1;
            accountGroupTextBox.Clear();
            openingBalanceNumericUpDown.Value = 0;
            currencyComboBox.SelectedIndex = -1; // Clear combobox selection
            isActiveCheckBox.Checked = false;
        }

        private void accountNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(accountNumberTextBox.Text))
            {
                lblAccoutNumberValidation.Visible = true;
            }
            else
            {
                lblAccoutNumberValidation.Visible = false;
            }
        }

        private void accountNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(accountNameTextBox.Text))
            {
                accountNameLabelValidation.Visible = true;
            }
            else
            {
                accountNameLabelValidation.Visible = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Export Chart of Accounts to CSV";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToCsv(saveFileDialog.FileName);
            }
        }

        private void ExportToCsv(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("AccountID,AccountNumber,AccountName,AccountType,AccountGroup,OpeningBalance,CurrencyID,IsActive");
                    foreach (DataGridViewRow row in chartOfAccountsDataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sw.WriteLine($"{row.Cells["AccountID"].Value},{row.Cells["AccountNumber"].Value},{row.Cells["AccountName"].Value},{row.Cells["AccountType"].Value},{row.Cells["AccountGroup"].Value},{row.Cells["OpeningBalance"].Value},{row.Cells["CurrencyID"].Value},{row.Cells["IsActive"].Value}");
                        }
                    }
                }
                MessageBox.Show("Chart of Accounts exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.Title = "Import Chart of Accounts from CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportFromCsv(openFileDialog.FileName);
            }
        }

        private void ImportFromCsv(string filePath)
        {
            try
            {
                using (TextFieldParser parser = new TextFieldParser(filePath))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    if (!parser.EndOfData)
                    {
                        parser.ReadLine();
                    }

                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        if (fields != null && fields.Length == 8)
                        {
                            try
                            {
                                ChartOfAccount account = new ChartOfAccount
                                {
                                    AccountNumber = fields[1],
                                    AccountName = fields[2],
                                    AccountType = fields[3],
                                    AccountGroup = fields[4],
                                    OpeningBalance = decimal.Parse(fields[5]),
                                    CurrencyID = int.Parse(fields[6]),
                                    IsActive = bool.Parse(fields[7])
                                };
                                _chartOfAccountService.InsertChartOfAccount(account);
                            }
                            catch (Exception importEx)
                            {
                                MessageBox.Show($"Error importing row: {importEx.Message}", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid CSV format. Each row must have 8 columns.", "Import Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                LoadChartOfAccounts();
                MessageBox.Show("Chart of Accounts imported successfully!", "Import", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error importing: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}