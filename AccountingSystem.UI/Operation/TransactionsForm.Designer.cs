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
            ((System.ComponentModel.ISupportInitialize)transactionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // transactionsDataGridView
            // 
            transactionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionsDataGridView.Location = new Point(14, 14);
            transactionsDataGridView.Margin = new Padding(4, 3, 4, 3);
            transactionsDataGridView.Name = "transactionsDataGridView";
            transactionsDataGridView.Size = new Size(905, 288);
            transactionsDataGridView.TabIndex = 0;
            transactionsDataGridView.CellClick += transactionsDataGridView_CellClick;
            // 
            // transactionDateLabel
            // 
            transactionDateLabel.AutoSize = true;
            transactionDateLabel.Location = new Point(14, 346);
            transactionDateLabel.Margin = new Padding(4, 0, 4, 0);
            transactionDateLabel.Name = "transactionDateLabel";
            transactionDateLabel.Size = new Size(97, 15);
            transactionDateLabel.TabIndex = 1;
            transactionDateLabel.Text = "Transaction Date:";
            // 
            // transactionNumberLabel
            // 
            transactionNumberLabel.AutoSize = true;
            transactionNumberLabel.Location = new Point(14, 381);
            transactionNumberLabel.Margin = new Padding(4, 0, 4, 0);
            transactionNumberLabel.Name = "transactionNumberLabel";
            transactionNumberLabel.Size = new Size(117, 15);
            transactionNumberLabel.TabIndex = 2;
            transactionNumberLabel.Text = "Transaction Number:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(14, 415);
            descriptionLabel.Margin = new Padding(4, 0, 4, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(70, 15);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // referenceLabel
            // 
            referenceLabel.AutoSize = true;
            referenceLabel.Location = new Point(14, 450);
            referenceLabel.Margin = new Padding(4, 0, 4, 0);
            referenceLabel.Name = "referenceLabel";
            referenceLabel.Size = new Size(62, 15);
            referenceLabel.TabIndex = 4;
            referenceLabel.Text = "Reference:";
            // 
            // transactionDateDateTimePicker
            // 
            transactionDateDateTimePicker.Location = new Point(152, 343);
            transactionDateDateTimePicker.Margin = new Padding(4, 3, 4, 3);
            transactionDateDateTimePicker.Name = "transactionDateDateTimePicker";
            transactionDateDateTimePicker.Size = new Size(233, 23);
            transactionDateDateTimePicker.TabIndex = 5;
            // 
            // transactionNumberTextBox
            // 
            transactionNumberTextBox.Location = new Point(152, 377);
            transactionNumberTextBox.Margin = new Padding(4, 3, 4, 3);
            transactionNumberTextBox.Name = "transactionNumberTextBox";
            transactionNumberTextBox.Size = new Size(233, 23);
            transactionNumberTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(152, 412);
            descriptionTextBox.Margin = new Padding(4, 3, 4, 3);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(233, 23);
            descriptionTextBox.TabIndex = 7;
            // 
            // referenceTextBox
            // 
            referenceTextBox.Location = new Point(152, 447);
            referenceTextBox.Margin = new Padding(4, 3, 4, 3);
            referenceTextBox.Name = "referenceTextBox";
            referenceTextBox.Size = new Size(233, 23);
            referenceTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            addButton.Location = new Point(408, 343);
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
            updateButton.Location = new Point(502, 343);
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
            deleteButton.Location = new Point(595, 343);
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
            transactionIdLabel.Location = new Point(14, 317);
            transactionIdLabel.Margin = new Padding(4, 0, 4, 0);
            transactionIdLabel.Name = "transactionIdLabel";
            transactionIdLabel.Size = new Size(84, 15);
            transactionIdLabel.TabIndex = 12;
            transactionIdLabel.Text = "Transaction ID:";
            // 
            // transactionIdTextBox
            // 
            transactionIdTextBox.Enabled = false;
            transactionIdTextBox.Location = new Point(152, 314);
            transactionIdTextBox.Margin = new Padding(4, 3, 4, 3);
            transactionIdTextBox.Name = "transactionIdTextBox";
            transactionIdTextBox.Size = new Size(233, 23);
            transactionIdTextBox.TabIndex = 13;
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
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
    }
}