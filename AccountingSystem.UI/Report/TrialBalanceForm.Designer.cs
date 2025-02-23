namespace AccountingSystem.UI
{
    partial class TrialBalanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            endDatePicker = new DateTimePicker();
            generateButton = new Button();
            trialBalanceDataGridView = new DataGridView();
            endDateLabel = new Label();
            exportPdfButton = new Button();
            btnExportExcel = new Button();
            btnExportCSV = new Button();
            ((System.ComponentModel.ISupportInitialize)trialBalanceDataGridView).BeginInit();
            SuspendLayout();
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(96, 14);
            endDatePicker.Margin = new Padding(4, 3, 4, 3);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(233, 23);
            endDatePicker.TabIndex = 0;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(336, 12);
            generateButton.Margin = new Padding(4, 3, 4, 3);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(88, 27);
            generateButton.TabIndex = 1;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // trialBalanceDataGridView
            // 
            trialBalanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            trialBalanceDataGridView.Location = new Point(14, 44);
            trialBalanceDataGridView.Margin = new Padding(4, 3, 4, 3);
            trialBalanceDataGridView.Name = "trialBalanceDataGridView";
            trialBalanceDataGridView.Size = new Size(905, 462);
            trialBalanceDataGridView.TabIndex = 0;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(14, 17);
            endDateLabel.Margin = new Padding(4, 0, 4, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(57, 15);
            endDateLabel.TabIndex = 3;
            endDateLabel.Text = "End Date:";
            // 
            // exportPdfButton
            // 
            exportPdfButton.Location = new Point(13, 512);
            exportPdfButton.Margin = new Padding(4, 3, 4, 3);
            exportPdfButton.Name = "exportPdfButton";
            exportPdfButton.Size = new Size(88, 27);
            exportPdfButton.TabIndex = 4;
            exportPdfButton.Text = "Export PDF";
            exportPdfButton.UseVisualStyleBackColor = true;
            exportPdfButton.Click += exportPdfButton_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(109, 512);
            btnExportExcel.Margin = new Padding(4, 3, 4, 3);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(88, 27);
            btnExportExcel.TabIndex = 5;
            btnExportExcel.Text = "Export Excel";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnExportCSV
            // 
            btnExportCSV.Location = new Point(205, 514);
            btnExportCSV.Margin = new Padding(4, 3, 4, 3);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(88, 27);
            btnExportCSV.TabIndex = 6;
            btnExportCSV.Text = "Export CSV";
            btnExportCSV.UseVisualStyleBackColor = true;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // TrialBalanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 570);
            Controls.Add(btnExportCSV);
            Controls.Add(btnExportExcel);
            Controls.Add(exportPdfButton);
            Controls.Add(endDateLabel);
            Controls.Add(trialBalanceDataGridView);
            Controls.Add(generateButton);
            Controls.Add(endDatePicker);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TrialBalanceForm";
            Text = "Trial Balance";
            ((System.ComponentModel.ISupportInitialize)trialBalanceDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.DataGridView trialBalanceDataGridView;
        private System.Windows.Forms.Label endDateLabel;
        private Button exportPdfButton;
        private Button btnExportExcel;
        private Button btnExportCSV;
    }
}