using MagacinskoRobnoMaterijalno.Classes;
using MagacinskoRobnoMaterijalno.Data.Model;
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
    public partial class frmNewClient : Form
    {
        readonly BindingList<Client> _bindinglist;
        ClientLogic _clientLogic;
        public frmNewClient()
        {
            InitializeComponent();
            _bindinglist = new BindingList<Client>
            {
                new Client()
            };
            InitNewClient();
        }

        public frmNewClient(Client client)
        {
            InitializeComponent();
            _bindinglist = new BindingList<Client>
            {
                client
            };
            InitNewClient();
            btnAddClient.Text = "Sačuvaj izmenu";
            this.Text = "Izmena klijenta";
            btnAddClient.Click -= BtnAddClient_Click;
            btnAddClient.Click += BtnEditClient_Click;
        }

        private void BtnEditClient_Click(object sender, EventArgs e)
        {
            var result = _clientLogic.EditClient(_bindinglist[0]);
            if (result != 0)
            {
                MessageBox.Show("Uspesno ste izmenili klijenta.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nesto nije u redu, pokusajte ponovo.");
            }

        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
           var result = _clientLogic.AddClient(_bindinglist[0]);
            if (result != 0)
            {
                MessageBox.Show("Uspesno ste dodali novog klijenta.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nesto nije u redu, pokusajte ponovo.");
            }
        }

        private void InitNewClient()
        {
            _clientLogic = new ClientLogic();
            BindingClient();
        }
        private void BindingClient()
        {

            tbName.DataBindings.Clear();
            tbName.DataBindings.Add("Text", _bindinglist[0], "Name");

            tbMB.DataBindings.Clear();
            tbMB.DataBindings.Add("Text", _bindinglist[0], "MB");

            tbPIB.DataBindings.Clear();
            tbPIB.DataBindings.Add("Text", _bindinglist[0], "PIB");

            tbAddress.DataBindings.Clear();
            tbAddress.DataBindings.Add("Text", _bindinglist[0], "Address");

            tbBankAccount.DataBindings.Clear();
            tbBankAccount.DataBindings.Add("Text", _bindinglist[0], "BankAccount");

            tbPhoneFax.DataBindings.Clear();
            tbPhoneFax.DataBindings.Add("Text", _bindinglist[0], "PhoneFax");

            tbEmail.DataBindings.Clear();
            tbEmail.DataBindings.Add("Text", _bindinglist[0], "Email");

            tbPhone.DataBindings.Clear();
            tbPhone.DataBindings.Add("Text", _bindinglist[0], "Phone");
        }
    }
}
