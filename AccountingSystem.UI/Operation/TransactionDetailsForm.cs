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
    public partial class TransactionDetailsForm : Form
    {
        private readonly ITransactionDetailService _transactionDetailService;
        public TransactionDetailsForm(ITransactionDetailService transactionDetailService)
        {
            InitializeComponent();
            _transactionDetailService = transactionDetailService;
        }
    }
}
