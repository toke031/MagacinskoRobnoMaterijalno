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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Clients_Click(object sender, EventArgs e)
        {
            Form clients = new Clients();
            clients.Show();
        }

        private void ReceiptsDespatchs_Click(object sender, EventArgs e)
        {
            Form receiptsDespatchs = new ReceiptsDespatchs();
            receiptsDespatchs.Show();
        }

        private void Articles_Click(object sender, EventArgs e)
        {
            Form articles = new Articles();
            articles.Show();
        }
    }
}
