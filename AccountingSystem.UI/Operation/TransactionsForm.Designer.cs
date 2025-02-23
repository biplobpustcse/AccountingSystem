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
            startDatePicker = new DateTimePicker();
            endDatePicker = new DateTimePicker();
            descriptionSearchTextBox = new TextBox();
            debitAccountSearchComboBox = new ComboBox();
            creditAccountSearchComboBox = new ComboBox();
            searchButton = new Button();
            clearSearchButton = new Button();
            startDateLabel = new Label();
            endDateLabel = new Label();
            descriptionSearchLabel = new Label();
            debitAccountSearchLabel = new Label();
            creditAccountSearchLabel = new Label();
            label1 = new Label();
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
            transactionDateLabel.Location = new Point(14, 390);
            transactionDateLabel.Margin = new Padding(4, 0, 4, 0);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new Size(97, 15);
            transactionDateLabel.TabIndex = 1;
            transactionDateLabel.Text = "Transaction Date:";
            // 
            // transactionNumberLabel
            // 
            transactionNumberLabel.AutoSize = true;
            transactionNumberLabel.Location = new Point(14, 425);
            transactionNumberLabel.Margin = new Padding(4, 0, 4, 0);
            transactionNumberLabel.Name = "transactionNumberLabel";
            transactionNumberLabel.Size = new Size(117, 15);
            transactionNumberLabel.TabIndex = 2;
            transactionNumberLabel.Text = "Transaction Number:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(14, 459);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // referenceLabel
            // 
            referenceLabel.AutoSize = true;
            referenceLabel.Location = new Point(14, 494);
            referenceLabel.Margin = new Padding(4, 0, 4, 0);
            referenceLabel.Name = "referenceLabel";
            referenceLabel.Size = new Size(62, 15);
            referenceLabel.TabIndex = 4;
            referenceLabel.Text = "Reference:";
            // 
            // transactionDateDateTimePicker
            // 
            transactionDateDateTimePicker.Location = new Point(149, 393);
            transactionDateDateTimePicker.Margin = new Padding(4, 3, 4, 3);
            transactionDateDateTimePicker.Name = "transactionDateDateTimePicker";
            transactionDateDateTimePicker.Size = new Size(233, 23);
            transactionDateDateTimePicker.TabIndex = 5;
            // 
            // transactionNumberTextBox
            // 
            transactionNumberTextBox.Location = new Point(149, 427);
            transactionNumberTextBox.Margin = new Padding(4, 3, 4, 3);
            transactionNumberTextBox.Name = "transactionNumberTextBox";
            transactionNumberTextBox.ReadOnly = true;
            transactionNumberTextBox.Size = new Size(233, 23);
            transactionNumberTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(149, 462);
            descriptionTextBox.Margin = new Padding(4, 3, 4, 3);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(233, 23);
            descriptionTextBox.TabIndex = 7;
            // 
            // referenceTextBox
            // 
            referenceTextBox.Location = new Point(149, 497);
            referenceTextBox.Margin = new Padding(4, 3, 4, 3);
            referenceTextBox.Name = "referenceTextBox";
            referenceTextBox.Size = new Size(233, 23);
            referenceTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Location = new Point(149, 705);
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
            updateButton.Location = new Point(245, 705);
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
            deleteButton.Location = new Point(341, 705);
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
            transactionIdLabel.Location = new Point(14, 362);
            transactionIdLabel.Margin = new Padding(4, 0, 4, 0);
            transactionIdLabel.Name = "transactionIdLabel";
            transactionIdLabel.Size = new Size(84, 15);
            transactionIdLabel.TabIndex = 12;
            transactionIdLabel.Text = "Transaction ID:";
            // 
            // transactionIdTextBox
            // 
            transactionIdTextBox.Enabled = false;
            transactionIdTextBox.Location = new Point(148, 359);
            transactionIdTextBox.Margin = new Padding(4, 3, 4, 3);
            transactionIdTextBox.Name = "transactionIdTextBox";
            transactionIdTextBox.Size = new Size(234, 23);
            transactionIdTextBox.TabIndex = 13;
            // 
            // debitAccountLabel
            // 
            debitAccountLabel.AutoSize = true;
            debitAccountLabel.Location = new Point(14, 528);
            debitAccountLabel.Margin = new Padding(4, 0, 4, 0);
            debitAccountLabel.Name = "debitAccountLabel";
            debitAccountLabel.Size = new Size(86, 15);
            debitAccountLabel.TabIndex = 14;
            debitAccountLabel.Text = "Debit Account:";
            // 
            // creditAccountLabel
            // 
            creditAccountLabel.AutoSize = true;
            creditAccountLabel.Location = new Point(14, 563);
            creditAccountLabel.Margin = new Padding(4, 0, 4, 0);
            creditAccountLabel.Name = "creditAccountLabel";
            creditAccountLabel.Size = new Size(90, 15);
            creditAccountLabel.TabIndex = 15;
            creditAccountLabel.Text = "Credit Account:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new Point(14, 598);
            amountLabel.Margin = new Padding(4, 0, 4, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(54, 15);
            amountLabel.TabIndex = 16;
            amountLabel.Text = "Amount:";
            // 
            // vatLabel
            // 
            vatLabel.AutoSize = true;
            vatLabel.Location = new Point(14, 629);
            vatLabel.Margin = new Padding(4, 0, 4, 0);
            vatLabel.Name = "vatLabel";
            vatLabel.Size = new Size(29, 15);
            vatLabel.TabIndex = 17;
            vatLabel.Text = "VAT:";
            // 
            // amountNumericUpDown
            // 
            amountNumericUpDown.DecimalPlaces = 2;
            amountNumericUpDown.Location = new Point(149, 601);
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
            debitAccountComboBox.Location = new Point(149, 531);
            debitAccountComboBox.Margin = new Padding(4, 3, 4, 3);
            debitAccountComboBox.Name = "debitAccountComboBox";
            debitAccountComboBox.Size = new Size(233, 23);
            debitAccountComboBox.TabIndex = 19;
            // 
            // creditAccountComboBox
            // 
            creditAccountComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            creditAccountComboBox.FormattingEnabled = true;
            creditAccountComboBox.Location = new Point(149, 566);
            creditAccountComboBox.Margin = new Padding(4, 3, 4, 3);
            creditAccountComboBox.Name = "creditAccountComboBox";
            creditAccountComboBox.Size = new Size(233, 23);
            creditAccountComboBox.TabIndex = 20;
            // 
            // vatComboBox
            // 
            vatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vatComboBox.FormattingEnabled = true;
            vatComboBox.Location = new Point(149, 636);
            vatComboBox.Margin = new Padding(4, 3, 4, 3);
            vatComboBox.Name = "vatComboBox";
            vatComboBox.Size = new Size(233, 23);
            vatComboBox.TabIndex = 21;
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new Point(14, 668);
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
            currencyComboBox.Location = new Point(149, 671);
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
            // startDatePicker
            // 
            startDatePicker.Location = new Point(546, 365);
            startDatePicker.Margin = new Padding(4, 3, 4, 3);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(233, 23);
            startDatePicker.TabIndex = 26;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(546, 399);
            endDatePicker.Margin = new Padding(4, 3, 4, 3);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(233, 23);
            endDatePicker.TabIndex = 27;
            // 
            // descriptionSearchTextBox
            // 
            descriptionSearchTextBox.Location = new Point(546, 434);
            descriptionSearchTextBox.Margin = new Padding(4, 3, 4, 3);
            descriptionSearchTextBox.Name = "descriptionSearchTextBox";
            descriptionSearchTextBox.Size = new Size(233, 23);
            descriptionSearchTextBox.TabIndex = 28;
            // 
            // debitAccountSearchComboBox
            // 
            debitAccountSearchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            debitAccountSearchComboBox.FormattingEnabled = true;
            debitAccountSearchComboBox.Location = new Point(546, 469);
            debitAccountSearchComboBox.Margin = new Padding(4, 3, 4, 3);
            debitAccountSearchComboBox.Name = "debitAccountSearchComboBox";
            debitAccountSearchComboBox.Size = new Size(233, 23);
            debitAccountSearchComboBox.TabIndex = 29;
            // 
            // creditAccountSearchComboBox
            // 
            creditAccountSearchComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            creditAccountSearchComboBox.FormattingEnabled = true;
            creditAccountSearchComboBox.Location = new Point(546, 503);
            creditAccountSearchComboBox.Margin = new Padding(4, 3, 4, 3);
            creditAccountSearchComboBox.Name = "creditAccountSearchComboBox";
            creditAccountSearchComboBox.Size = new Size(233, 23);
            creditAccountSearchComboBox.TabIndex = 30;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(546, 538);
            searchButton.Margin = new Padding(4, 3, 4, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(88, 27);
            searchButton.TabIndex = 31;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // clearSearchButton
            // 
            clearSearchButton.Location = new Point(642, 538);
            clearSearchButton.Margin = new Padding(4, 3, 4, 3);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(88, 27);
            clearSearchButton.TabIndex = 32;
            clearSearchButton.Text = "Clear";
            clearSearchButton.UseVisualStyleBackColor = true;
            clearSearchButton.Click += clearSearchButton_Click;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(446, 368);
            startDateLabel.Margin = new Padding(4, 0, 4, 0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(61, 15);
            startDateLabel.TabIndex = 33;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(446, 403);
            endDateLabel.Margin = new Padding(4, 0, 4, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(57, 15);
            endDateLabel.TabIndex = 34;
            endDateLabel.Text = "End Date:";
            // 
            // descriptionSearchLabel
            // 
            descriptionSearchLabel.AutoSize = true;
            descriptionSearchLabel.Location = new Point(446, 438);
            descriptionSearchLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionSearchLabel.Name = "descriptionSearchLabel";
            descriptionSearchLabel.Size = new Size(70, 15);
            descriptionSearchLabel.TabIndex = 35;
            descriptionSearchLabel.Text = "Description:";
            // 
            // debitAccountSearchLabel
            // 
            debitAccountSearchLabel.AutoSize = true;
            debitAccountSearchLabel.Location = new Point(446, 473);
            debitAccountSearchLabel.Margin = new Padding(4, 0, 4, 0);
            debitAccountSearchLabel.Name = "debitAccountSearchLabel";
            debitAccountSearchLabel.Size = new Size(86, 15);
            debitAccountSearchLabel.TabIndex = 36;
            debitAccountSearchLabel.Text = "Debit Account:";
            // 
            // creditAccountSearchLabel
            // 
            creditAccountSearchLabel.AutoSize = true;
            creditAccountSearchLabel.Location = new Point(446, 507);
            creditAccountSearchLabel.Margin = new Padding(4, 0, 4, 0);
            creditAccountSearchLabel.Name = "creditAccountSearchLabel";
            creditAccountSearchLabel.Size = new Size(90, 15);
            creditAccountSearchLabel.TabIndex = 37;
            creditAccountSearchLabel.Text = "Credit Account:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(446, 334);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 19);
            label1.TabIndex = 38;
            label1.Text = "Search Info:";
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 760);
            Controls.Add(label1);
            Controls.Add(creditAccountSearchLabel);
            Controls.Add(debitAccountSearchLabel);
            Controls.Add(descriptionSearchLabel);
            Controls.Add(endDateLabel);
            Controls.Add(startDateLabel);
            Controls.Add(clearSearchButton);
            Controls.Add(searchButton);
            Controls.Add(creditAccountSearchComboBox);
            Controls.Add(debitAccountSearchComboBox);
            Controls.Add(descriptionSearchTextBox);
            Controls.Add(endDatePicker);
            Controls.Add(startDatePicker);
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
        private System.Windows.Forms.Label lblTransactionList;
        private System.Windows.Forms.Label lblTransactionInfo;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.TextBox descriptionSearchTextBox;
        private System.Windows.Forms.ComboBox debitAccountSearchComboBox;
        private System.Windows.Forms.ComboBox creditAccountSearchComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label descriptionSearchLabel;
        private System.Windows.Forms.Label debitAccountSearchLabel;
        private System.Windows.Forms.Label creditAccountSearchLabel;
        private Label label1;
    }
}