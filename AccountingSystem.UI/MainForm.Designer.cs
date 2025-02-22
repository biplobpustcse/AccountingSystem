namespace AccountingSystem.UI
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            closeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            operationToolStripMenuItem = new ToolStripMenuItem();
            currenciesToolStripMenuItem = new ToolStripMenuItem();
            chartOfAccountsToolStripMenuItem = new ToolStripMenuItem();
            vATTaxToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            transactionDetailsToolStripMenuItem = new ToolStripMenuItem();
            setupToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem, setupToolStripMenuItem,operationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.BackColor = SystemColors.Window;
            closeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            closeToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(48, 20);
            closeToolStripMenuItem.Text = "Close";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(95, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // setupToolStripMenuItem
            //
            setupToolStripMenuItem.BackColor = SystemColors.Window;
            setupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currenciesToolStripMenuItem, vATTaxToolStripMenuItem });
            setupToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            setupToolStripMenuItem.Size = new Size(52, 20);
            setupToolStripMenuItem.Text = "Setup";
            // 
            // currenciesToolStripMenuItem
            // 
            currenciesToolStripMenuItem.Name = "currenciesToolStripMenuItem";
            currenciesToolStripMenuItem.Size = new Size(180, 22);
            currenciesToolStripMenuItem.Text = "Currencies";
            currenciesToolStripMenuItem.Click += currenciesToolStripMenuItem_Click;
            // 
            // vATTaxToolStripMenuItem
            // 
            vATTaxToolStripMenuItem.Name = "vATTaxToolStripMenuItem";
            vATTaxToolStripMenuItem.Size = new Size(180, 22);
            vATTaxToolStripMenuItem.Text = "VAT Tax";
            vATTaxToolStripMenuItem.Click += vATTaxToolStripMenuItem_Click;
            // 
            // operationToolStripMenuItem
            // 
            operationToolStripMenuItem.BackColor = SystemColors.Window;
            operationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { chartOfAccountsToolStripMenuItem, transactionsToolStripMenuItem, transactionDetailsToolStripMenuItem });
            operationToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            operationToolStripMenuItem.Size = new Size(80, 20);
            operationToolStripMenuItem.Text = "Operations";
            // 
            // chartOfAccountsToolStripMenuItem
            // 
            chartOfAccountsToolStripMenuItem.Name = "chartOfAccountsToolStripMenuItem";
            chartOfAccountsToolStripMenuItem.Size = new Size(180, 22);
            chartOfAccountsToolStripMenuItem.Text = "Chart of Accounts";
            chartOfAccountsToolStripMenuItem.Click += chartOfAccountsToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(180, 22);
            transactionsToolStripMenuItem.Text = "Transactions";
            transactionsToolStripMenuItem.Click += transactionsToolStripMenuItem_Click;
            // 
            // transactionDetailsToolStripMenuItem
            // 
            transactionDetailsToolStripMenuItem.Name = "transactionDetailsToolStripMenuItem";
            transactionDetailsToolStripMenuItem.Size = new Size(180, 22);
            transactionDetailsToolStripMenuItem.Text = "Transaction Details";
            transactionDetailsToolStripMenuItem.Click += transactionDetailsToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(933, 519);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Accounting System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currenciesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartOfAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vATTaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDetailsToolStripMenuItem;
        private ToolStripMenuItem setupToolStripMenuItem;
    }
}