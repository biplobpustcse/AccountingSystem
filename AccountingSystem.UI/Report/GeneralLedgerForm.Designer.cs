namespace AccountingSystem.UI
{
    partial class GeneralLedgerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            generateButton = new Button();
            generalLedgerDataGridView = new DataGridView();
            startDateLabel = new Label();
            endDateLabel = new Label();
            accountIdLabel = new Label();
            exportPdfButton = new Button();
            btnExportExcel = new Button();
            btnExportCSV = new Button();
            accountSearchComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)generalLedgerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(93, 14);
            startDatePicker.Margin = new Padding(4, 3, 4, 3);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(233, 23);
            startDatePicker.TabIndex = 0;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(420, 14);
            endDatePicker.Margin = new Padding(4, 3, 4, 3);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(233, 23);
            endDatePicker.TabIndex = 1;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(976, 10);
            generateButton.Margin = new Padding(4, 3, 4, 3);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(88, 27);
            generateButton.TabIndex = 2;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // generalLedgerDataGridView
            // 
            generalLedgerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            generalLedgerDataGridView.Location = new Point(14, 46);
            generalLedgerDataGridView.Margin = new Padding(4, 3, 4, 3);
            generalLedgerDataGridView.Name = "generalLedgerDataGridView";
            generalLedgerDataGridView.Size = new Size(1050, 462);
            generalLedgerDataGridView.TabIndex = 3;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(14, 17);
            startDateLabel.Margin = new Padding(4, 0, 4, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(61, 15);
            startDateLabel.TabIndex = 4;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(341, 17);
            endDateLabel.Margin = new Padding(4, 0, 4, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(57, 15);
            endDateLabel.TabIndex = 5;
            endDateLabel.Text = "End Date:";
            // 
            // accountIdLabel
            // 
            accountIdLabel.AutoSize = true;
            accountIdLabel.Location = new Point(665, 17);
            accountIdLabel.Margin = new Padding(4, 0, 4, 0);
            accountIdLabel.Name = "accountIdLabel";
            accountIdLabel.Size = new Size(69, 15);
            accountIdLabel.TabIndex = 7;
            accountIdLabel.Text = "Account ID:";
            // 
            // exportPdfButton
            // 
            exportPdfButton.Location = new Point(14, 515);
            exportPdfButton.Margin = new Padding(4, 3, 4, 3);
            exportPdfButton.Name = "exportPdfButton";
            exportPdfButton.Size = new Size(88, 27);
            exportPdfButton.TabIndex = 8;
            exportPdfButton.Text = "Export PDF";
            exportPdfButton.UseVisualStyleBackColor = true;
            exportPdfButton.Click += exportPdfButton_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(108, 515);
            btnExportExcel.Margin = new Padding(4, 3, 4, 3);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(88, 27);
            btnExportExcel.TabIndex = 9;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Location = new Point(203, 515);
            btnExportCSV.Margin = new Padding(4, 3, 4, 3);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(88, 27);
            btnExportCSV.TabIndex = 10;
            btnExportCSV.Text = "Export CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // accountSearchComboBox
            // 
            accountSearchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            accountSearchComboBox.FormattingEnabled = true;
            accountSearchComboBox.Location = new Point(735, 13);
            accountSearchComboBox.Margin = new Padding(4, 3, 4, 3);
            accountSearchComboBox.Name = "accountSearchComboBox";
            accountSearchComboBox.Size = new Size(233, 23);
            accountSearchComboBox.TabIndex = 30;
            // 
            // GeneralLedgerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 555);
            Controls.Add(accountSearchComboBox);
            Controls.Add(btnExportCSV);
            Controls.Add(btnExportExcel);
            Controls.Add(exportPdfButton);
            Controls.Add(accountIdLabel);
            Controls.Add(endDateLabel);
            Controls.Add(startDateLabel);
            Controls.Add(generalLedgerDataGridView);
            Controls.Add(generateButton);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
            Margin = new Padding(4, 3, 4, 3);
            Name = "GeneralLedgerForm";
            Text = "General Ledger";
            ((System.ComponentModel.ISupportInitialize)generalLedgerDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.DataGridView generalLedgerDataGridView;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label accountIdLabel;
        private System.Windows.Forms.Button exportPdfButton;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportCSV;
        private ComboBox accountSearchComboBox;
    }
}