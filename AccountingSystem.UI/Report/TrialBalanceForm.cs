using AccountingSystem.BLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using Document = iTextSharp.text.Document;

namespace AccountingSystem.UI
{
    public partial class TrialBalanceForm : Form
    {
        private readonly IReportService _reportService;

        public TrialBalanceForm(IReportService reportService)
        {
            InitializeComponent();
            _reportService = reportService;
        }

        #region Method
        private void generateButton_Click(object sender, EventArgs e)
        {
            DateTime endDate = endDatePicker.Value;

            try
            {
                trialBalanceDataGridView.Columns.Clear();

                var trialBalanceData = _reportService.GetTrialBalance(endDate).ToList(); // Convert to List for easier access

                trialBalanceDataGridView.DataSource = trialBalanceData;

                // Ensure the correct property names are used for data binding
                trialBalanceDataGridView.Columns["AccountNumber"].DataPropertyName = "AccountNumber";
                trialBalanceDataGridView.Columns["AccountName"].DataPropertyName = "AccountName";
                trialBalanceDataGridView.Columns["DebitBalance"].DataPropertyName = "DebitBalance";
                trialBalanceDataGridView.Columns["CreditBalance"].DataPropertyName = "CreditBalance";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating trial balance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportPdfButton_Click(object sender, EventArgs e)
        {
            if (trialBalanceDataGridView.Rows.Count > 0)
            {
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string fileName = "TrialBalance" + Guid.NewGuid() + ".PDF";
                string filePath = Path.Combine(downloadsPath, fileName);
                ExportTrialBalanceToPDF(filePath);
            }
        }
        private void ExportTrialBalanceToPDF(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    using (Document document = new Document(PageSize.A4, 10, 10, 10, 10))
                    {
                        using (PdfWriter writer = PdfWriter.GetInstance(document, fs))
                        {
                            document.Open();

                            PdfPTable table = new PdfPTable(4); // 4 columns
                            table.WidthPercentage = 100;

                            // Header Row
                            table.AddCell("AccountNumber");
                            table.AddCell("AccountName");
                            table.AddCell("DebitBalance");
                            table.AddCell("CreditBalance");

                            // Data Rows
                            foreach (DataGridViewRow row in trialBalanceDataGridView.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    table.AddCell(row.Cells["AccountNumber"].Value?.ToString() ?? "");
                                    table.AddCell(row.Cells["AccountName"].Value?.ToString() ?? "");
                                    table.AddCell(row.Cells["DebitBalance"].Value?.ToString() ?? "");
                                    table.AddCell(row.Cells["CreditBalance"].Value?.ToString() ?? "");
                                }
                            }

                            document.Add(table);
                            document.Close();
                        }
                    }
                }

                MessageBox.Show("Trial Balance exported to PDF successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (trialBalanceDataGridView.Rows.Count > 0)
            {
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string fileName = "TrialBalance" + Guid.NewGuid() + ".XLS";
                string filePath = Path.Combine(downloadsPath, fileName);
                ExportTrialBalanceToExcel(filePath);
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (trialBalanceDataGridView.Rows.Count > 0)
            {
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string fileName = "TrialBalance" + Guid.NewGuid() + ".csv";
                string filePath = Path.Combine(downloadsPath, fileName);
                ExportTrialBalanceToExcel(filePath);
            }
        }
        private void ExportTrialBalanceToExcel(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("AccountNumber,AccountName,DebitBalance,CreditBalance");
                    foreach (DataGridViewRow row in trialBalanceDataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sw.WriteLine($"{row.Cells["AccountNumber"].Value},{row.Cells["AccountName"].Value},{row.Cells["DebitBalance"].Value},{row.Cells["CreditBalance"].Value}");
                        }
                    }
                }
                MessageBox.Show("Trial Balance exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Open the file with its associated application
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion



    }
}