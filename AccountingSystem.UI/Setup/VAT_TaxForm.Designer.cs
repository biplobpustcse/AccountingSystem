namespace AccountingSystem.UI
{
    partial class VAT_TaxForm
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
            vatDataGridView = new DataGridView();
            vatIdLabel = new Label();
            vatRateLabel = new Label();
            effectiveDateLabel = new Label();
            vatIdTextBox = new TextBox();
            vatRateNumericUpDown = new NumericUpDown();
            effectiveDateTimePicker = new DateTimePicker();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            lblVATList = new Label();
            ((System.ComponentModel.ISupportInitialize)vatDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vatRateNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // vatDataGridView
            // 
            vatDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vatDataGridView.Location = new Point(14, 43);
            vatDataGridView.Margin = new Padding(4, 3, 4, 3);
            vatDataGridView.Name = "vatDataGridView";
            vatDataGridView.Size = new Size(642, 288);
            vatDataGridView.TabIndex = 0;
            vatDataGridView.CellClick += vatDataGridView_CellClick;
            // 
            // vatIdLabel
            // 
            vatIdLabel.AutoSize = true;
            vatIdLabel.Location = new Point(14, 346);
            vatIdLabel.Margin = new Padding(4, 0, 4, 0);
            vatIdLabel.Name = "vatIdLabel";
            vatIdLabel.Size = new Size(43, 15);
            vatIdLabel.TabIndex = 1;
            vatIdLabel.Text = "VAT ID:";
            // 
            // vatRateLabel
            // 
            vatRateLabel.AutoSize = true;
            vatRateLabel.Location = new Point(14, 381);
            vatRateLabel.Margin = new Padding(4, 0, 4, 0);
            vatRateLabel.Name = "vatRateLabel";
            vatRateLabel.Size = new Size(55, 15);
            vatRateLabel.TabIndex = 2;
            vatRateLabel.Text = "VAT Rate:";
            // 
            // effectiveDateLabel
            // 
            effectiveDateLabel.AutoSize = true;
            effectiveDateLabel.Location = new Point(14, 416);
            effectiveDateLabel.Margin = new Padding(4, 0, 4, 0);
            effectiveDateLabel.Name = "effectiveDateLabel";
            effectiveDateLabel.Size = new Size(82, 15);
            effectiveDateLabel.TabIndex = 3;
            effectiveDateLabel.Text = "Effective Date:";
            // 
            // vatIdTextBox
            // 
            vatIdTextBox.Enabled = false;
            vatIdTextBox.Location = new Point(117, 343);
            vatIdTextBox.Margin = new Padding(4, 3, 4, 3);
            vatIdTextBox.Name = "vatIdTextBox";
            vatIdTextBox.Size = new Size(139, 23);
            vatIdTextBox.TabIndex = 4;
            // 
            // vatRateNumericUpDown
            // 
            vatRateNumericUpDown.DecimalPlaces = 2;
            vatRateNumericUpDown.Location = new Point(117, 377);
            vatRateNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            vatRateNumericUpDown.Name = "vatRateNumericUpDown";
            vatRateNumericUpDown.Size = new Size(140, 23);
            vatRateNumericUpDown.TabIndex = 5;
            // 
            // effectiveDateTimePicker
            // 
            effectiveDateTimePicker.Location = new Point(117, 412);
            effectiveDateTimePicker.Margin = new Padding(4, 3, 4, 3);
            effectiveDateTimePicker.Name = "effectiveDateTimePicker";
            effectiveDateTimePicker.Size = new Size(233, 23);
            effectiveDateTimePicker.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.Location = new Point(373, 343);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 27);
            addButton.TabIndex = 7;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(467, 343);
            updateButton.Margin = new Padding(4, 3, 4, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 27);
            updateButton.TabIndex = 8;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(560, 343);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 27);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // lblVATList
            // 
            lblVATList.AutoSize = true;
            lblVATList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVATList.Location = new Point(14, 9);
            lblVATList.Margin = new Padding(4, 0, 4, 0);
            lblVATList.Name = "lblVATList";
            lblVATList.Size = new Size(64, 19);
            lblVATList.TabIndex = 11;
            lblVATList.Text = "VAT List:";
            // 
            // VAT_TaxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 474);
            Controls.Add(lblVATList);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(effectiveDateTimePicker);
            Controls.Add(vatRateNumericUpDown);
            Controls.Add(vatIdTextBox);
            Controls.Add(effectiveDateLabel);
            Controls.Add(vatRateLabel);
            Controls.Add(vatIdLabel);
            Controls.Add(vatDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "VAT_TaxForm";
            Text = "VAT Tax";
            ((System.ComponentModel.ISupportInitialize)vatDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)vatRateNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView vatDataGridView;
        private System.Windows.Forms.Label vatIdLabel;
        private System.Windows.Forms.Label vatRateLabel;
        private System.Windows.Forms.Label effectiveDateLabel;
        private System.Windows.Forms.TextBox vatIdTextBox;
        private System.Windows.Forms.NumericUpDown vatRateNumericUpDown;
        private System.Windows.Forms.DateTimePicker effectiveDateTimePicker;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private Label lblVATList;
    }
}