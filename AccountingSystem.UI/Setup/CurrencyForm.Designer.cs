namespace AccountingSystem.UI
{
    partial class CurrencyForm
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
            currencyDataGridView = new DataGridView();
            currencyCodeLabel = new Label();
            exchangeRateLabel = new Label();
            currencyCodeTextBox = new TextBox();
            exchangeRateNumericUpDown = new NumericUpDown();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            currencyIdLabel = new Label();
            currencyIdTextBox = new TextBox();
            lblCurrencyList = new Label();
            ((System.ComponentModel.ISupportInitialize)currencyDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exchangeRateNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // currencyDataGridView
            // 
            currencyDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            currencyDataGridView.Location = new Point(14, 45);
            currencyDataGridView.Margin = new Padding(4, 3, 4, 3);
            currencyDataGridView.Name = "currencyDataGridView";
            currencyDataGridView.Size = new Size(642, 288);
            currencyDataGridView.TabIndex = 0;
            currencyDataGridView.CellClick += currencyDataGridView_CellClick;
            // 
            // currencyCodeLabel
            // 
            currencyCodeLabel.AutoSize = true;
            currencyCodeLabel.Location = new Point(14, 348);
            currencyCodeLabel.Margin = new Padding(4, 0, 4, 0);
            currencyCodeLabel.Name = "currencyCodeLabel";
            currencyCodeLabel.Size = new Size(89, 15);
            currencyCodeLabel.TabIndex = 1;
            currencyCodeLabel.Text = "Currency Code:";
            // 
            // exchangeRateLabel
            // 
            exchangeRateLabel.AutoSize = true;
            exchangeRateLabel.Location = new Point(14, 383);
            exchangeRateLabel.Margin = new Padding(4, 0, 4, 0);
            exchangeRateLabel.Name = "exchangeRateLabel";
            exchangeRateLabel.Size = new Size(87, 15);
            exchangeRateLabel.TabIndex = 2;
            exchangeRateLabel.Text = "Exchange Rate:";
            // 
            // currencyCodeTextBox
            // 
            currencyCodeTextBox.Location = new Point(117, 345);
            currencyCodeTextBox.Margin = new Padding(4, 3, 4, 3);
            currencyCodeTextBox.Name = "currencyCodeTextBox";
            currencyCodeTextBox.Size = new Size(139, 23);
            currencyCodeTextBox.TabIndex = 3;
            // 
            // exchangeRateNumericUpDown
            // 
            exchangeRateNumericUpDown.DecimalPlaces = 6;
            exchangeRateNumericUpDown.Location = new Point(117, 379);
            exchangeRateNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            exchangeRateNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            exchangeRateNumericUpDown.Name = "exchangeRateNumericUpDown";
            exchangeRateNumericUpDown.Size = new Size(140, 23);
            exchangeRateNumericUpDown.TabIndex = 4;
            // 
            // addButton
            // 
            addButton.Location = new Point(292, 345);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 27);
            addButton.TabIndex = 5;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(391, 345);
            updateButton.Margin = new Padding(4, 3, 4, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 27);
            updateButton.TabIndex = 6;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(490, 345);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 27);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new Point(14, 418);
            currencyIdLabel.Margin = new Padding(4, 0, 4, 0);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new Size(72, 15);
            currencyIdLabel.TabIndex = 8;
            currencyIdLabel.Text = "Currency ID:";
            // 
            // currencyIdTextBox
            // 
            currencyIdTextBox.Enabled = false;
            currencyIdTextBox.Location = new Point(117, 414);
            currencyIdTextBox.Margin = new Padding(4, 3, 4, 3);
            currencyIdTextBox.Name = "currencyIdTextBox";
            currencyIdTextBox.Size = new Size(139, 23);
            currencyIdTextBox.TabIndex = 9;
            // 
            // lblCurrencyList
            // 
            lblCurrencyList.AutoSize = true;
            lblCurrencyList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCurrencyList.Location = new Point(14, 18);
            lblCurrencyList.Margin = new Padding(4, 0, 4, 0);
            lblCurrencyList.Name = "lblCurrencyList";
            lblCurrencyList.Size = new Size(99, 19);
            lblCurrencyList.TabIndex = 10;
            lblCurrencyList.Text = "Currency List:";
            // 
            // CurrencyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 454);
            Controls.Add(lblCurrencyList);
            Controls.Add(currencyIdTextBox);
            Controls.Add(currencyIdLabel);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(exchangeRateNumericUpDown);
            Controls.Add(currencyCodeTextBox);
            Controls.Add(exchangeRateLabel);
            Controls.Add(currencyCodeLabel);
            Controls.Add(currencyDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CurrencyForm";
            Text = "Currency";
            ((System.ComponentModel.ISupportInitialize)currencyDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)exchangeRateNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView currencyDataGridView;
        private System.Windows.Forms.Label currencyCodeLabel;
        private System.Windows.Forms.Label exchangeRateLabel;
        private System.Windows.Forms.TextBox currencyCodeTextBox;
        private System.Windows.Forms.NumericUpDown exchangeRateNumericUpDown;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label currencyIdLabel;
        private System.Windows.Forms.TextBox currencyIdTextBox;
        private Label lblCurrencyList;
    }
}