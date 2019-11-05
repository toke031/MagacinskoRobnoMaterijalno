using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagacinskoRobnoMaterijalno.Classes;

namespace MagacinskoRobnoMaterijalno.Forms
{
    public partial class frmNewReceiptsDespatchs : Form
    {
        public frmNewReceiptsDespatchs()
        {
            InitializeComponent();
        }

        private void btnNewDespatch_Click(object sender, EventArgs e)
        {
            frmReceiptsDespatchs _despatch = new frmReceiptsDespatchs((int)Lib.DocumentType.Despatch);
            _despatch.Show();
        }

        private void btnNewReceipt_Click(object sender, EventArgs e)
        {
            frmReceiptsDespatchs _receipt = new frmReceiptsDespatchs((int)Lib.DocumentType.Receipt);
            _receipt.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
