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
    public partial class FrmClients : Form
    {
        ClientLogic _clientLogic;
        Client _itemForDelete;

        public bool SelectionMode { get; internal set; }
        public Client SelectedClient { get; internal set; }

        public FrmClients(bool selectionMode = false)
        {
            SelectionMode = selectionMode;
            InitializeComponent();
            InitClients();
        }

        private void InitClients()
        {
            _clientLogic = new ClientLogic();
            DGVClients.DataSource = _clientLogic.GetAllClients();
            if (!SelectionMode)
            {
                DGVClients.AllowUserToAddRows = false;
                DGVClients.ReadOnly = true;
                DGVClients.AllowUserToDeleteRows = false;
                DGVClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DGVClients.DoubleClick += SelectedRow_DoubleClick;
            }
            else
            {
                DGVClients.AllowUserToAddRows = false;
                DGVClients.ReadOnly = true;
                DGVClients.AllowUserToDeleteRows = true;
                DGVClients.Click += Right_Click;
                DGVClients.UserDeletingRow += DGVClients_UserDeletingRow;
                DGVClients.UserDeletedRow += DGVClients_UserDeletedRow;
                DGVClients.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyDataGridView_MouseDown);
                SelectedRow.Click += new System.EventHandler(this.SelectedRow_Click);
            }
        }

        private void SelectedRow_DoubleClick(object sender, EventArgs e)
        {
            var selected = DGVClients.SelectedRows[0];
            if (selected != null)
            {
                SelectedClient = (Client)((DataGridViewRow)selected).DataBoundItem;
                this.Close();
            }
        }

        private void SelectedRow_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = DGVClients.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DGVClients.Rows.RemoveAt(rowToDelete);
            DGVClients.ClearSelection();
        }

        private void MyDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = DGVClients.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    DGVClients.ClearSelection();
                    DGVClients.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void DGVClients_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            _clientLogic.DeleteClient(_itemForDelete);
        }

        private void DGVClients_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da izbrišete ovog klijenta", "Brisanje klijenta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _itemForDelete = _clientLogic.GetClientByClientPIB(e.Row.Cells["PIB"].Value.ToString());
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add("Dodaj klijenta", new EventHandler(AddNewClient_Click));
                if (DGVClients.SelectedRows.Count == 1)
                {
                    cm.MenuItems.Add("Izmeni klijenta", new EventHandler(EditRow_Click));
                }
                cm.Show(DGVClients, new Point(me.X, me.Y));
            }
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            if(DGVClients.SelectedRows.Count == 1)
            {
                var clientForEdit = (Client)DGVClients.SelectedRows[0].DataBoundItem;
                frmNewClient editClient = new frmNewClient(clientForEdit);
                editClient.ShowDialog();
                DGVClients.DataSource = new BindingList<Client>(_clientLogic.GetClientByName(tbSearchName.Text));
                DGVClients.ClearSelection();
            }
        }

        private void AddNewClient_Click(object sender, EventArgs e)
        {
            var newItemForm = new frmNewClient();
            newItemForm.ShowDialog();
            RefreshDGVSource();
        }

        private void RefreshDGVSource()
        {
            DGVClients.DataSource = _clientLogic.GetAllClients();
            DGVClients.RefreshEdit();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DGVClients.DataSource = new BindingList<Client>(_clientLogic.GetClientByName(tbSearchName.Text));
        }
    }
}
