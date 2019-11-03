using MagacinskoRobnoMaterijalno.Classes;
using MagacinskoRobnoMaterijalno.Models;
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
        BindingList<Client> _bindinglist;
        ClientLogic _clientLogic;
        public frmNewClient()
        {
            InitializeComponent();
            _bindinglist = new BindingList<Client>();
            _bindinglist.Add(new Client());
            InitNewClient();
        }

        public frmNewClient(Client client)
        {
            InitializeComponent();
            _bindinglist = new BindingList<Client>();
            _bindinglist.Add(client);
            InitNewClient();
            btnAddClient.Text = "Sačuvaj izmenu";
            this.Text = "Izmena klijenta";
            btnAddClient.Click -= btnAddClient_Click;
            btnAddClient.Click += btnEditClient_Click;
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            _clientLogic.EditClient(_bindinglist[0]);
            var result = _clientLogic.SaveAllChanges();
            if (result == true)
            {
                MessageBox.Show("Uspesno ste izmenili klijenta.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Nesto nije u redu, pokusajte ponovo.");
            }

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            _clientLogic.AddClient(_bindinglist[0]);
            var result = _clientLogic.SaveAllChanges();
            if (result == true)
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
