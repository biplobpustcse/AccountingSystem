using System.Data;
using AccountingSystem.BLL;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AccountingSystem.UI
{
    public partial class BalanceSheetForm : Form
    {
        private readonly IReportService _reportService;

        public BalanceSheetForm(IReportService reportService)
        {
            InitializeComponent();
            _reportService = reportService;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            DateTime endDate = endDatePicker.Value;

            try
            {
                balanceSheetDataGridView.Columns.Clear();
                var balanceSheetData = _reportService.GetBalanceSheet(endDate).ToList();
                balanceSheetDataGridView.DataSource = balanceSheetData;

                balanceSheetDataGridView.Columns["AccountNumber"].DataPropertyName = "AccountNumber";
                balanceSheetDataGridView.Columns["AccountName"].DataPropertyName = "AccountName";
                balanceSheetDataGridView.Columns["Balance"].DataPropertyName = "Balance";
                balanceSheetDataGridView.Columns["AccountType"].DataPropertyName = "AccountType";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating balance sheet: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportPdfButton_Click(object sender, EventArgs e)
        {
            if (balanceSheetDataGridView.Rows.Count > 0)
            {
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string fileName = "BalanceSheet" + Guid.NewGuid() + ".pdf";
                string filePath = Path.Combine(downloadsPath, fileName);
                ExportBalanceSheetToPdf(filePath);
            }
        }

        private void ExportBalanceSheetToPdf(string filePath)
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

                            PdfPTable table = new PdfPTable(balanceSheetDataGridView.Columns.Count); // Dynamic columns
                            table.WidthPercentage = 100;

                            foreach (DataGridViewColumn column in balanceSheetDataGridView.Columns)
                            {
                                table.AddCell(column.HeaderText);
                            }

                            foreach (DataGridViewRow row in balanceSheetDataGridView.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    for (int col = 0; col < balanceSheetDataGridView.Columns.Count; col++)
                                    {
                                        table.AddCell(row.Cells[col].Value?.ToString() ?? "");
                                    }
                                }
                            }

                            document.Add(table);
                            document.Close();
                        }
                    }
                }

                MessageBox.Show("Balance Sheet exported to PDF successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (balanceSheetDataGridView.Rows.Count > 0)
            {
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string fileName = "BalanceSheet" + Guid.NewGuid() + ".XLS";
                string filePath = Path.Combine(downloadsPath, fileName);
                ExportBalanceSheetToExcel(filePath);
            }
        }

        private void ExportBalanceSheetToExcel(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Header Row
                    string headerRow = string.Join(",", balanceSheetDataGridView.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText));
                    sw.WriteLine(headerRow);

                    // Data Rows
                    foreach (DataGridViewRow row in balanceSheetDataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string dataRow = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value));
                            sw.WriteLine(dataRow);
                        }
                    }
                }

                MessageBox.Show("Balance Sheet exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (balanceSheetDataGridView.Rows.Count > 0)
            {
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string fileName = "BalanceSheet" + Guid.NewGuid() + ".csv";
                string filePath = Path.Combine(downloadsPath, fileName);
                ExportBalanceSheetToCsv(filePath);
            }
        }

        private void ExportBalanceSheetToCsv(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    string headerRow = string.Join(",", balanceSheetDataGridView.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText));
                    sw.WriteLine(headerRow);

                    for (int row = 0; row < balanceSheetDataGridView.Rows.Count; row++)
                    {
                        if (!balanceSheetDataGridView.Rows[row].IsNewRow)
                        {
                            string dataRow = string.Join(",", balanceSheetDataGridView.Rows[row].Cells.Cast<DataGridViewCell>().Select(cell => cell.Value));
                            sw.WriteLine(dataRow);
                        }
                    }
                }

                MessageBox.Show("Balance Sheet exported to CSV successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}