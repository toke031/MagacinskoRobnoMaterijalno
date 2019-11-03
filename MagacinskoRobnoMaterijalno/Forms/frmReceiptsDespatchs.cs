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
    public partial class frmReceiptsDespatchs : Form
    {
        DocumentLogic _documentLogic;
        Document _document;
        public frmReceiptsDespatchs()
        {
            InitializeComponent();
            InitDocument();
        }

        private void InitDocument()
        {
            _documentLogic = new DocumentLogic();
            DGVReceiptsDespatchs.DataSource = _documentLogic.GetAllDocuments();
            DGVReceiptsDespatchs.AllowUserToAddRows = false;
            DGVReceiptsDespatchs.ReadOnly = true;
            DGVReceiptsDespatchs.AllowUserToDeleteRows = true;
            DGVReceiptsDespatchs.Click += Right_Click;
            DGVReceiptsDespatchs.UserDeletingRow += DGVReceiptsDespatchs_UserDeletingRow;
            DGVReceiptsDespatchs.UserDeletedRow += DGVReceiptsDespatchs_UserDeletedRow;
            DGVReceiptsDespatchs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyDataGridView_MouseDown);
            SelectedRow.Click += new System.EventHandler(this.SelectedRow_Click);
        }
        private void SelectedRow_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = DGVReceiptsDespatchs.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DGVReceiptsDespatchs.Rows.RemoveAt(rowToDelete);
            DGVReceiptsDespatchs.ClearSelection();
        }
        private void MyDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = DGVReceiptsDespatchs.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    DGVReceiptsDespatchs.ClearSelection();
                    DGVReceiptsDespatchs.Rows[hti.RowIndex].Selected = true;
                }
            }
        }
        private void DGVReceiptsDespatchs_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            _documentLogic.DeleteDocument(_document);
        }
        private void DGVReceiptsDespatchs_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Da li ste sigurni da želite da izbrišete ovaj dokument.", "Brisanje dokumenta", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _document = _documentLogic.GetDocumentByDocumentID( Int32.Parse(e.Row.Cells["ID"].Value.ToString()));
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
                cm.MenuItems.Add("Dodaj dokument", new EventHandler(AddNewDocument_Click));
                if (DGVReceiptsDespatchs.SelectedRows.Count == 1)
                {
                    cm.MenuItems.Add("Izmeni dokument", new EventHandler(EditRow_Click));
                }
                cm.Show(DGVReceiptsDespatchs, new Point(me.X, me.Y));
            }
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            if (DGVReceiptsDespatchs.SelectedRows.Count == 1)
            {
                var clientForEdit = (Client)DGVReceiptsDespatchs.SelectedRows[0].DataBoundItem;
                frmNewReceiptsDespatchs editClient = new frmNewReceiptsDespatchs(clientForEdit);
                editClient.ShowDialog();
                DGVReceiptsDespatchs.ClearSelection();
            }
        }

        private void AddNewDocument_Click(object sender, EventArgs e)
        {
            var newItemForm = new frmNewClient();
            newItemForm.ShowDialog();
            RefreshDGVSource();
        }
        private void RefreshDGVSource()
        {
            DGVReceiptsDespatchs.DataSource = _documentLogic.GetAllDocuments();
            DGVReceiptsDespatchs.RefreshEdit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        //    DGVReceiptsDespatchs.DataSource = new BindingList<Client>(_documentLogic.GetClientByName(tbSearchName.Text));
        }
    }
}
