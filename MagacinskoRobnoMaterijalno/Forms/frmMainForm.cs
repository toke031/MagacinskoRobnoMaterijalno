using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagacinskoRobnoMaterijalno.Forms
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            Form clients = new FrmClients(true);
            clients.Show();
        }

        private void ReceiptsDespatchs_Click(object sender, EventArgs e)
        {
            Form receiptsDespatchs = new FrmNewReceiptsDespatchs();
            receiptsDespatchs.Show();
        }

        private void Articles_Click(object sender, EventArgs e)
        {
            Form articles = new FrmArticles();
            articles.Show();
        }
    }
}
