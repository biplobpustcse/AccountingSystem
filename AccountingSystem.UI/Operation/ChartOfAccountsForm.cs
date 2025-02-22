using AccountingSystem.BLL;
using AccountingSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

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
    }
}