using System.Data;
using AccountingSystem.BLL;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AccountingSystem.UI
{
    public partial class IncomeStatementForm : Form
    {
        private readonly IReportService _reportService;

        public IncomeStatementForm(IReportService reportService)
        {
            InitializeComponent();
            _reportService = reportService;
        }

        #region Method

        private void generateButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            try
            {
                incomeStatementDataGridView.Columns.Clear();
                var incomeStatementData = _reportService.GetIncomeStatement(startDate, endDate).ToList();
                incomeStatementDataGridView.DataSource = incomeStatementData;

                incomeStatementDataGridView.Columns["AccountNumber"].DataPropertyName = "AccountNumber";
                incomeStatementDataGridView.Columns["AccountName"].DataPropertyName = "AccountName";
                incomeStatementDataGridView.Columns["Balance"].DataPropertyName = "Balance";
                incomeStatementDataGridView.Columns["AccountType"].DataPropertyName = "AccountType";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating income statement: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportPdfButton_Click(object sender, EventArgs e)
        {
            if (incomeStatementDataGridView.Rows.Count > 0)
            {
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string fileName = "IncomeStatement" + Guid.NewGuid() + ".pdf";
                string filePath = Path.Combine(downloadsPath, fileName);
                ExportIncomeStatementToPdf(filePath);
            }
        }

        private void ExportIncomeStatementToPdf(string filePath)
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

                            PdfPTable table = new PdfPTable(incomeStatementDataGridView.Columns.Count);
                            table.WidthPercentage = 100;

                            foreach (DataGridViewColumn column in incomeStatementDataGridView.Columns)
                            {
                                table.AddCell(column.HeaderText);
                            }

                            foreach (DataGridViewRow row in incomeStatementDataGridView.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    for (int col = 0; col < incomeStatementDataGridView.Columns.Count; col++)
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

                MessageBox.Show("Income Statement exported to PDF successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (incomeStatementDataGridView.Rows.Count > 0)
            {
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string fileName = "IncomeStatement" + Guid.NewGuid() + ".XLS";
                string filePath = Path.Combine(downloadsPath, fileName);
                ExportIncomeStatementToExcel(filePath);
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (incomeStatementDataGridView.Rows.Count > 0)
            {
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                string fileName = "IncomeStatement" + Guid.NewGuid() + ".csv";
                string filePath = Path.Combine(downloadsPath, fileName);
                ExportIncomeStatementToExcel(filePath);
            }
        }

        private void ExportIncomeStatementToExcel(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Header Row
                    string headerRow = string.Join(",", incomeStatementDataGridView.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText));
                    sw.WriteLine(headerRow);

                    // Data Rows
                    foreach (DataGridViewRow row in incomeStatementDataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string dataRow = string.Join(",", row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value));
                            sw.WriteLine(dataRow);
                        }
                    }
                }

                MessageBox.Show("Income Statement exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
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