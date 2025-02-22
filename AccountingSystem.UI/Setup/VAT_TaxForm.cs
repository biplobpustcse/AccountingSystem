using AccountingSystem.BLL;
using AccountingSystem.Models.Entities;
using System;
using System.Windows.Forms;

namespace AccountingSystem.UI
{
    public partial class VAT_TaxForm : Form
    {
        private readonly IVATTaxService _vatTaxService;

        public VAT_TaxForm(IVATTaxService vatTaxService)
        {
            InitializeComponent();
            _vatTaxService = vatTaxService;
            LoadVATTaxes();
        }

        private void LoadVATTaxes()
        {
            try
            {
                vatDataGridView.DataSource = _vatTaxService.GetAllVATTaxs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading VAT taxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                VATTax vatTax = new VATTax
                {
                    VATRate = vatRateNumericUpDown.Value,
                    EffectiveDate = effectiveDateTimePicker.Value.Date
                };
                _vatTaxService.InsertVATTax(vatTax);
                LoadVATTaxes();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding VAT tax: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vatIdTextBox.Text))
            {
                MessageBox.Show("Please select a VAT tax to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                VATTax vatTax = new VATTax
                {
                    VATID = int.Parse(vatIdTextBox.Text),
                    VATRate = vatRateNumericUpDown.Value,
                    EffectiveDate = effectiveDateTimePicker.Value.Date
                };
                _vatTaxService.UpdateVATTax(vatTax);
                LoadVATTaxes();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating VAT tax: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(vatIdTextBox.Text))
            {
                MessageBox.Show("Please select a VAT tax to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int vatId = int.Parse(vatIdTextBox.Text);
                _vatTaxService.DeleteVATTax(vatId);
                LoadVATTaxes();
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting VAT tax: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void vatDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = vatDataGridView.Rows[e.RowIndex];
                vatIdTextBox.Text = row.Cells["VATID"].Value.ToString();
                vatRateNumericUpDown.Value = Convert.ToDecimal(row.Cells["VATRate"].Value);
                effectiveDateTimePicker.Value = Convert.ToDateTime(row.Cells["EffectiveDate"].Value);
            }
        }

        private void ClearInputFields()
        {
            vatIdTextBox.Clear();
            vatRateNumericUpDown.Value = 0;
            effectiveDateTimePicker.Value = DateTime.Now;
        }
    }
}