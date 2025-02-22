namespace AccountingSystem.UI
{
    partial class ChartOfAccountsForm
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
            chartOfAccountsDataGridView = new DataGridView();
            accountIdLabel = new Label();
            accountNumberLabel = new Label();
            accountNameLabel = new Label();
            accountTypeLabel = new Label();
            accountGroupLabel = new Label();
            openingBalanceLabel = new Label();
            currencyIdLabel = new Label();
            isActiveLabel = new Label();
            accountIdTextBox = new TextBox();
            accountNumberTextBox = new TextBox();
            accountNameTextBox = new TextBox();
            accountTypeComboBox = new ComboBox();
            accountGroupTextBox = new TextBox();
            openingBalanceNumericUpDown = new NumericUpDown();
            isActiveCheckBox = new CheckBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            currencyComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)chartOfAccountsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openingBalanceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // chartOfAccountsDataGridView
            // 
            chartOfAccountsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            chartOfAccountsDataGridView.Location = new Point(14, 14);
            chartOfAccountsDataGridView.Margin = new Padding(4, 3, 4, 3);
            chartOfAccountsDataGridView.Name = "chartOfAccountsDataGridView";
            chartOfAccountsDataGridView.Size = new Size(875, 288);
            chartOfAccountsDataGridView.TabIndex = 0;
            chartOfAccountsDataGridView.CellClick += chartOfAccountsDataGridView_CellClick;
            // 
            // accountIdLabel
            // 
            accountIdLabel.AutoSize = true;
            accountIdLabel.Location = new Point(14, 317);
            accountIdLabel.Margin = new Padding(4, 0, 4, 0);
            accountIdLabel.Name = "accountIdLabel";
            accountIdLabel.Size = new Size(69, 15);
            accountIdLabel.TabIndex = 1;
            accountIdLabel.Text = "Account ID:";
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new Point(14, 346);
            accountNumberLabel.Margin = new Padding(4, 0, 4, 0);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new Size(102, 15);
            accountNumberLabel.TabIndex = 2;
            accountNumberLabel.Text = "Account Number:";
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Location = new Point(14, 375);
            accountNameLabel.Margin = new Padding(4, 0, 4, 0);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(90, 15);
            accountNameLabel.TabIndex = 3;
            accountNameLabel.Text = "Account Name:";
            // 
            // accountTypeLabel
            // 
            accountTypeLabel.AutoSize = true;
            accountTypeLabel.Location = new Point(14, 404);
            accountTypeLabel.Margin = new Padding(4, 0, 4, 0);
            accountTypeLabel.Name = "accountTypeLabel";
            accountTypeLabel.Size = new Size(82, 15);
            accountTypeLabel.TabIndex = 4;
            accountTypeLabel.Text = "Account Type:";
            // 
            // accountGroupLabel
            // 
            accountGroupLabel.AutoSize = true;
            accountGroupLabel.Location = new Point(14, 433);
            accountGroupLabel.Margin = new Padding(4, 0, 4, 0);
            accountGroupLabel.Name = "accountGroupLabel";
            accountGroupLabel.Size = new Size(91, 15);
            accountGroupLabel.TabIndex = 5;
            accountGroupLabel.Text = "Account Group:";
            // 
            // openingBalanceLabel
            // 
            openingBalanceLabel.AutoSize = true;
            openingBalanceLabel.Location = new Point(14, 462);
            openingBalanceLabel.Margin = new Padding(4, 0, 4, 0);
            openingBalanceLabel.Name = "openingBalanceLabel";
            openingBalanceLabel.Size = new Size(100, 15);
            openingBalanceLabel.TabIndex = 6;
            openingBalanceLabel.Text = "Opening Balance:";
            // 
            // currencyIdLabel
            // 
            currencyIdLabel.AutoSize = true;
            currencyIdLabel.Location = new Point(14, 490);
            currencyIdLabel.Margin = new Padding(4, 0, 4, 0);
            currencyIdLabel.Name = "currencyIdLabel";
            currencyIdLabel.Size = new Size(58, 15);
            currencyIdLabel.TabIndex = 7;
            currencyIdLabel.Text = "Currency:";
            // 
            // isActiveLabel
            // 
            isActiveLabel.AutoSize = true;
            isActiveLabel.Location = new Point(14, 519);
            isActiveLabel.Margin = new Padding(4, 0, 4, 0);
            isActiveLabel.Name = "isActiveLabel";
            isActiveLabel.Size = new Size(54, 15);
            isActiveLabel.TabIndex = 8;
            isActiveLabel.Text = "Is Active:";
            // 
            // accountIdTextBox
            // 
            accountIdTextBox.Enabled = false;
            accountIdTextBox.Location = new Point(140, 314);
            accountIdTextBox.Margin = new Padding(4, 3, 4, 3);
            accountIdTextBox.Name = "accountIdTextBox";
            accountIdTextBox.Size = new Size(174, 23);
            accountIdTextBox.TabIndex = 9;
            // 
            // accountNumberTextBox
            // 
            accountNumberTextBox.Location = new Point(140, 343);
            accountNumberTextBox.Margin = new Padding(4, 3, 4, 3);
            accountNumberTextBox.Name = "accountNumberTextBox";
            accountNumberTextBox.Size = new Size(174, 23);
            accountNumberTextBox.TabIndex = 10;
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Location = new Point(140, 372);
            accountNameTextBox.Margin = new Padding(4, 3, 4, 3);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.Size = new Size(174, 23);
            accountNameTextBox.TabIndex = 11;
            // 
            // accountTypeComboBox
            // 
            accountTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            accountTypeComboBox.FormattingEnabled = true;
            accountTypeComboBox.Items.AddRange(new object[] { "Asset", "Liability", "Equity", "Revenue", "Expense" });
            accountTypeComboBox.Location = new Point(140, 400);
            accountTypeComboBox.Margin = new Padding(4, 3, 4, 3);
            accountTypeComboBox.Name = "accountTypeComboBox";
            accountTypeComboBox.Size = new Size(174, 23);
            accountTypeComboBox.TabIndex = 12;
            // 
            // accountGroupTextBox
            // 
            accountGroupTextBox.Location = new Point(140, 429);
            accountGroupTextBox.Margin = new Padding(4, 3, 4, 3);
            accountGroupTextBox.Name = "accountGroupTextBox";
            accountGroupTextBox.Size = new Size(174, 23);
            accountGroupTextBox.TabIndex = 13;
            // 
            // openingBalanceNumericUpDown
            // 
            openingBalanceNumericUpDown.DecimalPlaces = 2;
            openingBalanceNumericUpDown.Location = new Point(140, 458);
            openingBalanceNumericUpDown.Margin = new Padding(4, 3, 4, 3);
            openingBalanceNumericUpDown.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            openingBalanceNumericUpDown.Name = "openingBalanceNumericUpDown";
            openingBalanceNumericUpDown.Size = new Size(175, 23);
            openingBalanceNumericUpDown.TabIndex = 14;
            // 
            // isActiveCheckBox
            // 
            isActiveCheckBox.AutoSize = true;
            isActiveCheckBox.Enabled = false;
            isActiveCheckBox.Location = new Point(140, 517);
            isActiveCheckBox.Margin = new Padding(4, 3, 4, 3);
            isActiveCheckBox.Name = "isActiveCheckBox";
            isActiveCheckBox.Size = new Size(15, 14);
            isActiveCheckBox.TabIndex = 16;
            isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Location = new Point(350, 314);
            addButton.Margin = new Padding(4, 3, 4, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(88, 27);
            addButton.TabIndex = 17;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(443, 314);
            updateButton.Margin = new Padding(4, 3, 4, 3);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(88, 27);
            updateButton.TabIndex = 18;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(537, 314);
            deleteButton.Margin = new Padding(4, 3, 4, 3);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 27);
            deleteButton.TabIndex = 19;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // currencyComboBox
            // 
            currencyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            currencyComboBox.FormattingEnabled = true;
            currencyComboBox.Location = new Point(140, 487);
            currencyComboBox.Margin = new Padding(4, 3, 4, 3);
            currencyComboBox.Name = "currencyComboBox";
            currencyComboBox.Size = new Size(174, 23);
            currencyComboBox.TabIndex = 15;
            // 
            // ChartOfAccountsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 555);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(isActiveCheckBox);
            Controls.Add(currencyComboBox);
            Controls.Add(openingBalanceNumericUpDown);
            Controls.Add(accountGroupTextBox);
            Controls.Add(accountTypeComboBox);
            Controls.Add(accountNameTextBox);
            Controls.Add(accountNumberTextBox);
            Controls.Add(accountIdTextBox);
            Controls.Add(isActiveLabel);
            Controls.Add(currencyIdLabel);
            Controls.Add(openingBalanceLabel);
            Controls.Add(accountGroupLabel);
            Controls.Add(accountTypeLabel);
            Controls.Add(accountNameLabel);
            Controls.Add(accountNumberLabel);
            Controls.Add(accountIdLabel);
            Controls.Add(chartOfAccountsDataGridView);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ChartOfAccountsForm";
            Text = "Chart of Accounts";
            ((System.ComponentModel.ISupportInitialize)chartOfAccountsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)openingBalanceNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView chartOfAccountsDataGridView;
        private System.Windows.Forms.Label accountIdLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.Label accountNameLabel;
        private System.Windows.Forms.Label accountTypeLabel;
        private System.Windows.Forms.Label accountGroupLabel;
        private System.Windows.Forms.Label openingBalanceLabel;
        private System.Windows.Forms.Label currencyIdLabel;
        private System.Windows.Forms.Label isActiveLabel;
        private System.Windows.Forms.TextBox accountIdTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.TextBox accountNameTextBox;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.TextBox accountGroupTextBox;
        private System.Windows.Forms.NumericUpDown openingBalanceNumericUpDown;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox currencyComboBox;
    }
}