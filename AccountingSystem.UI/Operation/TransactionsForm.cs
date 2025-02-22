using AccountingSystem.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSystem.UI.Operation
{
    public partial class TransactionsForm : Form
    {
        private readonly ITransactionService _transactionService;
        public TransactionsForm(ITransactionService transactionService)
        {
            InitializeComponent();
            _transactionService = transactionService;
        }
    }
}
