namespace AccountingSystem.UI
{
    partial class BalanceSheetForm
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
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.generateButton = new System.Windows.Forms.Button();
            this.balanceSheetDataGridView = new System.Windows.Forms.DataGridView();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.exportPdfButton = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnExportCSV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.balanceSheetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(96, 14);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(233, 23);
            this.endDatePicker.TabIndex = 0;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(336, 12);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(88, 27);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // balanceSheetDataGridView
            // 
            this.balanceSheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.balanceSheetDataGridView.Location = new System.Drawing.Point(14, 44);
            this.balanceSheetDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.balanceSheetDataGridView.Name = "balanceSheetDataGridView";
            this.balanceSheetDataGridView.Size = new System.Drawing.Size(905, 462);
            this.balanceSheetDataGridView.TabIndex = 2;
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(14, 17);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(57, 15);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "End Date:";
            // 
            // exportPdfButton
            // 
            this.exportPdfButton.Location = new System.Drawing.Point(13, 512);
            this.exportPdfButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exportPdfButton.Name = "exportPdfButton";
            this.exportPdfButton.Size = new System.Drawing.Size(88, 27);
            this.exportPdfButton.TabIndex = 4;
            this.exportPdfButton.Text = "Export PDF";
            this.exportPdfButton.UseVisualStyleBackColor = true;
            this.exportPdfButton.Click += new System.EventHandler(this.exportPdfButton_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(109, 512);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(88, 27);
            this.btnExportExcel.TabIndex = 5;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnExportCSV
            // 
            this.btnExportCSV.Location = new System.Drawing.Point(205, 514);
            this.btnExportCSV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExportCSV.Name = "btnExportCSV";
            this.btnExportCSV.Size = new System.Drawing.Size(88, 27);
            this.btnExportCSV.TabIndex = 6;
            this.btnExportCSV.Text = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor = true;
            this.btnExportCSV.Click += new System.EventHandler(this.btnExportCSV_Click);
            // 
            // BalanceSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 570);
            this.Controls.Add(this.btnExportCSV);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.exportPdfButton);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.balanceSheetDataGridView);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.endDatePicker);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BalanceSheetForm";
            this.Text = "Balance Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.balanceSheetDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.DataGridView balanceSheetDataGridView;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button exportPdfButton;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnExportCSV;
    }
}