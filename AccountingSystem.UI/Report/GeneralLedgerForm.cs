using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using AccountingSystem.Models.Entities;
using AccountingSystem.BLL;

namespace AccountingSystem.UI
{
    public partial class GeneralLedgerForm : Form
    {
        private readonly IReportService _reportService;
        private readonly IChartOfAccountService _chartOfAccountService;

        public GeneralLedgerForm(IReportService reportService, IChartOfAccountService chartOfAccountService)
        {
            InitializeComponent();
            _reportService = reportService;
            _chartOfAccountService = chartOfAccountService;
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            var ChartOfAccountList = _chartOfAccountService.GetAllActiveChartOfAccounts();
            accountSearchComboBox.DataSource = ChartOfAccountList.ToList();
            accountSearchComboBox.DisplayMember = "AccountName";
            accountSearchComboBox.ValueMember = "AccountID";
        }
        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int accountId = (int)accountSearchComboBox.SelectedValue;

                DateTime startDate = startDatePicker.Value.Date;
                DateTime endDate = endDatePicker.Value.Date;

                IEnumerable<GeneralLedger> generalLedgerData = _reportService.GetGeneralLedger(accountId, startDate, endDate);

                generalLedgerDataGridView.DataSource = generalLedgerData.ToList();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string fileName = "GeneralLedger" + Guid.NewGuid() + ".csv";
            string filePath = Path.Combine(downloadsPath, fileName);
            ExportGeneralLedgerToCsv(filePath);
        }

        private void ExportGeneralLedgerToCsv(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("TransactionDate,TransactionNumber,Description,Reference,DebitAmount,CreditAmount");
                    foreach (DataGridViewRow row in generalLedgerDataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            sw.WriteLine($"{row.Cells["TransactionDate"].Value},{row.Cells["TransactionNumber"].Value},{row.Cells["Description"].Value},{row.Cells["Reference"].Value},{row.Cells["DebitAmount"].Value},{row.Cells["CreditAmount"].Value}");
                        }
                    }
                }
                MessageBox.Show("General Ledger exported to CSV successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string fileName = "GeneralLedger" + Guid.NewGuid() + ".xlsx";
            string filePath = Path.Combine(downloadsPath, fileName);
            ExportGeneralLedgerToExcel(filePath);
        }

        private void ExportGeneralLedgerToExcel(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    // Header Row
                    string headerRow = string.Join(",", generalLedgerDataGridView.Columns.Cast<DataGridViewColumn>().Select(column => column.HeaderText));
                    sw.WriteLine(headerRow);

                    // Data Rows
                    for (int row = 0; row < generalLedgerDataGridView.Rows.Count; row++)
                    {
                        if (!generalLedgerDataGridView.Rows[row].IsNewRow)
                        {
                            string dataRow = string.Join(",", generalLedgerDataGridView.Rows[row].Cells.Cast<DataGridViewCell>().Select(cell => cell.Value));
                            sw.WriteLine(dataRow);
                        }
                    }
                }

                MessageBox.Show("General Ledger exported to CSV successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportPdfButton_Click(object sender, EventArgs e)
        {
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string fileName = "GeneralLedger" + Guid.NewGuid() + ".pdf";
            string filePath = Path.Combine(downloadsPath, fileName);
            ExportGeneralLedgerToPdf(filePath);
        }

        private void ExportGeneralLedgerToPdf(string filePath)
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

                            PdfPTable table = new PdfPTable(generalLedgerDataGridView.Columns.Count); // Dynamic columns
                            table.WidthPercentage = 100;

                            // Header Row
                            foreach (DataGridViewColumn column in generalLedgerDataGridView.Columns)
                            {
                                table.AddCell(column.HeaderText);
                            }

                            // Data Rows
                            foreach (DataGridViewRow row in generalLedgerDataGridView.Rows)
                            {
                                if (!row.IsNewRow)
                                {
                                    for (int col = 0; col < generalLedgerDataGridView.Columns.Count; col++)
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

                MessageBox.Show("General Ledger exported to PDF successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting to PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}