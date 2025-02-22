namespace AccountingSystem.UI
{
    partial class TransactionDetailsForm
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
            transactionDetailsDataGridView = new DataGridView();
            debitAccountLabel = new Label();
            creditAccountLabel = new Label();
            amountLabel = new Label();
            vatLabel = new Label();
            amountNumericUpDown = new NumericUpDown();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            debitAccountComboBox = new ComboBox();
            creditAccountComboBox = new ComboBox();
            vatComboBox = new ComboBox();
            detailIdLabel = new Label();
            detailIdTextBox = new TextBox();
            currencyLabel = new Label();
            currencyComboBox = new ComboBox();
            lblTransactionList = new Label();
            ((System.ComponentModel.ISupportInitialize)transactionDetailsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // transactionDetailsDataGridView
            // 
            transactionDetailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDetailsDataGridView.Location = new Point(14, 57);
            transactionDetailsDataGridView.Margin = new Padding(4, 3, 4, 3);
            transactionDetailsDataGridView.Name = "transactionDetailsDataGridView";
            transactionDetailsDataGridView.Size = new Size(905, 288);
            transactionDetailsDataGridView.TabIndex = 0;
            transactionDetailsDataGridView.CellClick += transactionDetailsDataGridView_CellClick;
            // 
            // debitAccountLabel
            // 
            debitAccountLabel.AutoSize = true;
            debitAccountLabel.Location = new Point(14, 389);
            debitAccountLabel.Margin = new Padding(4, 0, 4, 0);
            debitAccountLabel.Name = "debitAccountLabel";
            debitAccountLabel.Size = new Size(86, 15);
            debitAccountLabel.TabIndex = 1;
            debitAccountLabel.Text = "Debit Account:";
            // 
            // creditAccountLabel
            // 
            creditAccountLabel.AutoSize = true;
            creditAccountLabel.Location = new Point(14, 424);
            creditAccountLabel.Margin = new Padding(4, 0, 4, 0);
            creditAccountLabel.Name = "creditAccountLabel";
            creditAccountLabel.Size = new Size(90, 15);
            creditAccountLabel.TabIndex = 2;
            creditAccountLabel.Text = "Credit Account:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(14, 458);
            amountLabel.Margin = new Padding(4, 0, 4, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(54, 15);
            amountLabel.TabIndex = 3;
            amountLabel.Text = "Amount:";
            // 
            // vatLabel
            // 
            vatLabel.AutoSize = true;
            vatLabel.Location = new Point(14, 493);
            vatLabel.Margin = new Padding(4, 0, 4, 0);
            vatLabel.Name = "vatLabel";
            vatLabel.Size = new Size(29, 15);
            vatLabel.TabIndex = 4;
            vatLabel.Text = "VAT:";
            // 
            // amountNumericUpDown
            // 
            amountNumericUpDown.DecimalPlaces = 2;
            amountNumericUpDown.Location = new Point(152, 455);
            amountNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            amountNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            amountNumericUpDown.Name = "amountNumericUpDown";
            amountNumericUpDown.Size = new Size(233, 23);
            amountNumericUpDown.TabIndex = 7;
            // 
            // addButton
            // 
            addButton.Location = new Point(408, 386);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 27);
            addButton.TabIndex = 9;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(502, 386);
            updateButton.Margin = new Padding(4, 3, 4, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 27);
            updateButton.TabIndex = 10;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(595, 386);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 27);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // debitAccountComboBox
            // 
            debitAccountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            debitAccountComboBox.FormattingEnabled = true;
            debitAccountComboBox.Location = new Point(152, 386);
            debitAccountComboBox.Margin = new Padding(4, 3, 4, 3);
            debitAccountComboBox.Name = "debitAccountComboBox";
            debitAccountComboBox.Size = new Size(233, 23);
            debitAccountComboBox.TabIndex = 12;
            // 
            // creditAccountComboBox
            // 
            creditAccountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            creditAccountComboBox.FormattingEnabled = true;
            creditAccountComboBox.Location = new Point(152, 420);
            creditAccountComboBox.Margin = new Padding(4, 3, 4, 3);
            creditAccountComboBox.Name = "creditAccountComboBox";
            creditAccountComboBox.Size = new Size(233, 23);
            creditAccountComboBox.TabIndex = 13;
            // 
            // vatComboBox
            // 
            vatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vatComboBox.FormattingEnabled = true;
            vatComboBox.Location = new Point(152, 490);
            vatComboBox.Margin = new Padding(4, 3, 4, 3);
            vatComboBox.Name = "vatComboBox";
            vatComboBox.Size = new Size(233, 23);
            vatComboBox.TabIndex = 14;
            // 
            // detailIdLabel
            // 
            detailIdLabel.AutoSize = true;
            detailIdLabel.Location = new Point(14, 360);
            detailIdLabel.Margin = new Padding(4, 0, 4, 0);
            detailIdLabel.Name = "detailIdLabel";
            detailIdLabel.Size = new Size(51, 15);
            detailIdLabel.TabIndex = 15;
            detailIdLabel.Text = "DetailID:";
            // 
            // detailIdTextBox
            // 
            detailIdTextBox.Enabled = false;
            detailIdTextBox.Location = new Point(152, 357);
            detailIdTextBox.Margin = new Padding(4, 3, 4, 3);
            detailIdTextBox.Name = "detailIdTextBox";
            detailIdTextBox.Size = new Size(233, 23);
            detailIdTextBox.TabIndex = 16;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(14, 528);
            currencyLabel.Margin = new Padding(4, 0, 4, 0);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(58, 15);
            currencyLabel.TabIndex = 17;
            currencyLabel.Text = "Currency:";
            // 
            // currencyComboBox
            // 
            currencyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            currencyComboBox.FormattingEnabled = true;
            currencyComboBox.Location = new Point(152, 524);
            currencyComboBox.Margin = new Padding(4, 3, 4, 3);
            currencyComboBox.Name = "currencyComboBox";
            currencyComboBox.Size = new Size(233, 23);
            currencyComboBox.TabIndex = 18;
            // 
            // lblTransactionList
            // 
            lblTransactionList.AutoSize = true;
            lblTransactionList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTransactionList.Location = new Point(14, 19);
            lblTransactionList.Margin = new Padding(4, 0, 4, 0);
            lblTransactionList.Name = "lblTransactionList";
            lblTransactionList.Size = new Size(115, 19);
            lblTransactionList.TabIndex = 19;
            lblTransactionList.Text = "Transaction List:";
            // 
            // TransactionDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 573);
            Controls.Add(lblTransactionList);
            Controls.Add(currencyComboBox);
            Controls.Add(currencyLabel);
            Controls.Add(detailIdTextBox);
            Controls.Add(detailIdLabel);
            Controls.Add(vatComboBox);
            Controls.Add(creditAccountComboBox);
            Controls.Add(debitAccountComboBox);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(amountNumericUpDown);
            Controls.Add(vatLabel);
            Controls.Add(amountLabel);
            Controls.Add(creditAccountLabel);
            Controls.Add(debitAccountLabel);
            Controls.Add(transactionDetailsDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TransactionDetailsForm";
            Text = "Transaction Details";
            ((System.ComponentModel.ISupportInitialize)transactionDetailsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView transactionDetailsDataGridView;
        private System.Windows.Forms.Label debitAccountLabel;
        private System.Windows.Forms.Label creditAccountLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox debitAccountComboBox;
        private System.Windows.Forms.ComboBox creditAccountComboBox;
        private System.Windows.Forms.ComboBox vatComboBox;
        private System.Windows.Forms.Label detailIdLabel;
        private System.Windows.Forms.TextBox detailIdTextBox;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private Label lblTransactionList;
    }
}