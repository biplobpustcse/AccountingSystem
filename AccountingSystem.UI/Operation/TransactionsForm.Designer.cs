namespace AccountingSystem.UI
{
    partial class TransactionsForm
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
            transactionsDataGridView = new DataGridView();
            transactionDateLabel = new Label();
            transactionNumberLabel = new Label();
            descriptionLabel = new Label();
            referenceLabel = new Label();
            transactionDateDateTimePicker = new DateTimePicker();
            transactionNumberTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            referenceTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            transactionIdLabel = new Label();
            transactionIdTextBox = new TextBox();
            debitAccountLabel = new Label();
            creditAccountLabel = new Label();
            amountLabel = new Label();
            vatLabel = new Label();
            amountNumericUpDown = new NumericUpDown();
            debitAccountComboBox = new ComboBox();
            creditAccountComboBox = new ComboBox();
            vatComboBox = new ComboBox();
            currencyLabel = new Label();
            currencyComboBox = new ComboBox();
            lblTransactionList = new Label();
            lblTransactionInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // transactionsDataGridView
            // 
            transactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionsDataGridView.Location = new Point(14, 40);
            transactionsDataGridView.Margin = new Padding(4, 3, 4, 3);
            transactionsDataGridView.Name = "transactionsDataGridView";
            transactionsDataGridView.Size = new Size(905, 288);
            transactionsDataGridView.TabIndex = 0;
            transactionsDataGridView.CellClick += transactionsDataGridView_CellClick;
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Location = new Point(14, 396);
            transactionDateLabel.Margin = new Padding(4, 0, 4, 0);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new Size(97, 15);
            transactionDateLabel.TabIndex = 1;
            transactionDateLabel.Text = "Transaction Date:";
            // 
            // transactionNumberLabel
            // 
            transactionNumberLabel.AutoSize = true;
            transactionNumberLabel.Location = new Point(14, 431);
            transactionNumberLabel.Margin = new Padding(4, 0, 4, 0);
            transactionNumberLabel.Name = "transactionNumberLabel";
            transactionNumberLabel.Size = new Size(117, 15);
            transactionNumberLabel.TabIndex = 2;
            transactionNumberLabel.Text = "Transaction Number:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(14, 465);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // referenceLabel
            // 
            referenceLabel.AutoSize = true;
            referenceLabel.Location = new Point(14, 500);
            referenceLabel.Margin = new Padding(4, 0, 4, 0);
            referenceLabel.Name = "referenceLabel";
            referenceLabel.Size = new Size(62, 15);
            referenceLabel.TabIndex = 4;
            referenceLabel.Text = "Reference:";
            // 
            // transactionDateDateTimePicker
            // 
            transactionDateDateTimePicker.Location = new Point(152, 422);
            transactionDateDateTimePicker.Margin = new Padding(4, 3, 4, 3);
            transactionDateDateTimePicker.Name = "transactionDateDateTimePicker";
            transactionDateDateTimePicker.Size = new Size(233, 23);
            transactionDateDateTimePicker.TabIndex = 5;
            // 
            // transactionNumberTextBox
            // 
            transactionNumberTextBox.Location = new Point(152, 456);
            transactionNumberTextBox.Margin = new Padding(4, 3, 4, 3);
            transactionNumberTextBox.Name = "transactionNumberTextBox";
            transactionNumberTextBox.ReadOnly = true;
            transactionNumberTextBox.Size = new Size(233, 23);
            transactionNumberTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(152, 491);
            descriptionTextBox.Margin = new Padding(4, 3, 4, 3);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(233, 23);
            descriptionTextBox.TabIndex = 7;
            // 
            // referenceTextBox
            // 
            referenceTextBox.Location = new Point(152, 526);
            referenceTextBox.Margin = new Padding(4, 3, 4, 3);
            referenceTextBox.Name = "referenceTextBox";
            referenceTextBox.Size = new Size(233, 23);
            referenceTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Location = new Point(152, 734);
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
            updateButton.Location = new Point(248, 734);
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
            deleteButton.Location = new Point(344, 734);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 27);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // transactionIdLabel
            // 
            transactionIdLabel.AutoSize = true;
            transactionIdLabel.Location = new Point(14, 367);
            transactionIdLabel.Margin = new Padding(4, 0, 4, 0);
            transactionIdLabel.Name = "transactionIdLabel";
            transactionIdLabel.Size = new Size(84, 15);
            transactionIdLabel.TabIndex = 12;
            transactionIdLabel.Text = "Transaction ID:";
            // 
            // transactionIdTextBox
            // 
            transactionIdTextBox.Enabled = false;
            transactionIdTextBox.Location = new Point(152, 393);
            transactionIdTextBox.Margin = new Padding(4, 3, 4, 3);
            transactionIdTextBox.Name = "transactionIdTextBox";
            transactionIdTextBox.Size = new Size(233, 23);
            transactionIdTextBox.TabIndex = 13;
            // 
            // debitAccountLabel
            // 
            debitAccountLabel.AutoSize = true;
            debitAccountLabel.Location = new Point(14, 534);
            debitAccountLabel.Margin = new Padding(4, 0, 4, 0);
            debitAccountLabel.Name = "debitAccountLabel";
            debitAccountLabel.Size = new Size(86, 15);
            debitAccountLabel.TabIndex = 14;
            debitAccountLabel.Text = "Debit Account:";
            // 
            // creditAccountLabel
            // 
            creditAccountLabel.AutoSize = true;
            creditAccountLabel.Location = new Point(14, 569);
            creditAccountLabel.Margin = new Padding(4, 0, 4, 0);
            creditAccountLabel.Name = "creditAccountLabel";
            creditAccountLabel.Size = new Size(90, 15);
            creditAccountLabel.TabIndex = 15;
            creditAccountLabel.Text = "Credit Account:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(14, 604);
            amountLabel.Margin = new Padding(4, 0, 4, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(54, 15);
            amountLabel.TabIndex = 16;
            amountLabel.Text = "Amount:";
            // 
            // vatLabel
            // 
            vatLabel.AutoSize = true;
            vatLabel.Location = new Point(14, 639);
            vatLabel.Margin = new Padding(4, 0, 4, 0);
            vatLabel.Name = "vatLabel";
            vatLabel.Size = new Size(29, 15);
            vatLabel.TabIndex = 17;
            vatLabel.Text = "VAT:";
            // 
            // amountNumericUpDown
            // 
            amountNumericUpDown.DecimalPlaces = 2;
            amountNumericUpDown.Location = new Point(152, 630);
            amountNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            amountNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            amountNumericUpDown.Name = "amountNumericUpDown";
            amountNumericUpDown.Size = new Size(233, 23);
            amountNumericUpDown.TabIndex = 18;
            // 
            // debitAccountComboBox
            // 
            debitAccountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            debitAccountComboBox.FormattingEnabled = true;
            debitAccountComboBox.Location = new Point(152, 560);
            debitAccountComboBox.Margin = new Padding(4, 3, 4, 3);
            debitAccountComboBox.Name = "debitAccountComboBox";
            debitAccountComboBox.Size = new Size(233, 23);
            debitAccountComboBox.TabIndex = 19;
            // 
            // creditAccountComboBox
            // 
            creditAccountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            creditAccountComboBox.FormattingEnabled = true;
            creditAccountComboBox.Location = new Point(152, 595);
            creditAccountComboBox.Margin = new Padding(4, 3, 4, 3);
            creditAccountComboBox.Name = "creditAccountComboBox";
            creditAccountComboBox.Size = new Size(233, 23);
            creditAccountComboBox.TabIndex = 20;
            // 
            // vatComboBox
            // 
            vatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vatComboBox.FormattingEnabled = true;
            vatComboBox.Location = new Point(152, 665);
            vatComboBox.Margin = new Padding(4, 3, 4, 3);
            vatComboBox.Name = "vatComboBox";
            vatComboBox.Size = new Size(233, 23);
            vatComboBox.TabIndex = 21;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(14, 674);
            currencyLabel.Margin = new Padding(4, 0, 4, 0);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new Size(58, 15);
            currencyLabel.TabIndex = 22;
            currencyLabel.Text = "Currency:";
            // 
            // currencyComboBox
            // 
            currencyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            currencyComboBox.FormattingEnabled = true;
            currencyComboBox.Location = new Point(152, 700);
            currencyComboBox.Margin = new Padding(4, 3, 4, 3);
            currencyComboBox.Name = "currencyComboBox";
            currencyComboBox.Size = new Size(233, 23);
            currencyComboBox.TabIndex = 23;
            // 
            // lblTransactionList
            // 
            lblTransactionList.AutoSize = true;
            lblTransactionList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTransactionList.Location = new Point(14, 9);
            lblTransactionList.Margin = new Padding(4, 0, 4, 0);
            lblTransactionList.Name = "lblTransactionList";
            lblTransactionList.Size = new Size(115, 19);
            lblTransactionList.TabIndex = 24;
            lblTransactionList.Text = "Transaction List:";
            // 
            // lblTransactionInfo
            // 
            lblTransactionInfo.AutoSize = true;
            lblTransactionInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTransactionInfo.Location = new Point(13, 334);
            lblTransactionInfo.Margin = new Padding(4, 0, 4, 0);
            lblTransactionInfo.Name = "lblTransactionInfo";
            lblTransactionInfo.Size = new Size(119, 19);
            lblTransactionInfo.TabIndex = 25;
            lblTransactionInfo.Text = "Transaction Info:";
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 782);
            Controls.Add(lblTransactionInfo);
            Controls.Add(lblTransactionList);
            Controls.Add(currencyComboBox);
            Controls.Add(currencyLabel);
            Controls.Add(vatComboBox);
            Controls.Add(creditAccountComboBox);
            Controls.Add(debitAccountComboBox);
            Controls.Add(amountNumericUpDown);
            Controls.Add(vatLabel);
            Controls.Add(amountLabel);
            Controls.Add(creditAccountLabel);
            Controls.Add(debitAccountLabel);
            Controls.Add(transactionIdTextBox);
            Controls.Add(transactionIdLabel);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(referenceTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(transactionNumberTextBox);
            Controls.Add(transactionDateDateTimePicker);
            Controls.Add(referenceLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(transactionNumberLabel);
            Controls.Add(transactionDateLabel);
            Controls.Add(transactionsDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TransactionsForm";
            Text = "Transactions";
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView transactionsDataGridView;
        private System.Windows.Forms.Label transactionDateLabel;
        private System.Windows.Forms.Label transactionNumberLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label referenceLabel;
        private System.Windows.Forms.DateTimePicker transactionDateDateTimePicker;
        private System.Windows.Forms.TextBox transactionNumberTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label transactionIdLabel;
        private System.Windows.Forms.TextBox transactionIdTextBox;
        private System.Windows.Forms.Label debitAccountLabel;
        private System.Windows.Forms.Label creditAccountLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.ComboBox debitAccountComboBox;
        private System.Windows.Forms.ComboBox creditAccountComboBox;
        private System.Windows.Forms.ComboBox vatComboBox;
        private System.Windows.Forms.Label currencyLabel;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private Label lblTransactionList;
        private Label lblTransactionInfo;
    }
}