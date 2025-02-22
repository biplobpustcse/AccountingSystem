using AccountingSystem.BLL;
using AccountingSystem.Models.Entities;
using System;
using System.Windows.Forms;

namespace AccountingSystem.UI
{
    public partial class CurrencyForm : Form
    {
        private readonly ICurrencyService _currencyService;

        public CurrencyForm(ICurrencyService currencyService)
        {
            InitializeComponent();
            _currencyService = currencyService;
            LoadCurrencies();
        }

        private void LoadCurrencies()
        {
            try
            {
                currencyDataGridView.DataSource = _currencyService.GetAllCurrencys();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading currencies: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Currency currency = new Currency
                {
                    CurrencyCode = currencyCodeTextBox.Text,
                    ExchangeRate = exchangeRateNumericUpDown.Value
                };
                _currencyService.InsertCurrency(currency);
                LoadCurrencies(); // Refresh the DataGridView
                ClearInputFields(); // Clear the input fields after successful addition
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding currency: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currencyIdTextBox.Text))
            {
                MessageBox.Show("Please select a currency to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Currency currency = new Currency
                {
                    CurrencyID = int.Parse(currencyIdTextBox.Text),
                    CurrencyCode = currencyCodeTextBox.Text,
                    ExchangeRate = exchangeRateNumericUpDown.Value
                };
                _currencyService.UpdateCurrency(currency);
                LoadCurrencies();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating currency: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currencyIdTextBox.Text))
            {
                MessageBox.Show("Please select a currency to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int currencyId = int.Parse(currencyIdTextBox.Text);
                _currencyService.DeleteCurrency(currencyId);
                LoadCurrencies();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting currency: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void currencyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = currencyDataGridView.Rows[e.RowIndex];
                currencyIdTextBox.Text = row.Cells["CurrencyID"].Value.ToString();
                currencyCodeTextBox.Text = row.Cells["CurrencyCode"].Value.ToString();
                exchangeRateNumericUpDown.Value = Convert.ToDecimal(row.Cells["ExchangeRate"].Value);
            }
        }

        private void ClearInputFields()
        {
            currencyIdTextBox.Clear();
            currencyCodeTextBox.Clear();
            exchangeRateNumericUpDown.Value = 0;
        }
    }
}