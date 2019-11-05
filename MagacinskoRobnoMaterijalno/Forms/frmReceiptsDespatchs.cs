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
using static MagacinskoRobnoMaterijalno.Classes.Lib;

namespace MagacinskoRobnoMaterijalno.Forms
{
    public partial class frmReceiptsDespatchs : Form
    {
        public FormMode FormMode { get; set; }
        public Document SelectedDocument { get; set; }
        public int DocumentTypeID { get; set; }
        DocumentLogic _documentLogic;
        WarehouseLogic _warehouseLogic;
        Document _document;
        public frmReceiptsDespatchs(int documentTypeID)
        {
            DocumentTypeID = documentTypeID;
            InitializeComponent();
            InitDocument();
        }

        private void InitDocument()
        {
            _documentLogic = new DocumentLogic();
            _warehouseLogic = new WarehouseLogic();
            if (FormMode == FormMode.New)
            {
                _document = new Document();
                _documentLogic.AddDocument(_document);
            }
            else if (FormMode == FormMode.Modifying || FormMode == FormMode.ReadOnly)
            {
                _document = _documentLogic.GetDocument(SelectedDocument.ID);
                if (FormMode == FormMode.ReadOnly)
                {
                    SetAllControlsReadOnly();
                }
            }

            // status
            cmbStatus.DisplayMember = "Description";
            cmbStatus.DataSource = Enum.GetValues(typeof(Classes.Lib.StatusEnum))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cmbStatus.DataBindings.Add("SelectedItem", _document, "StatusID");
            // magacini
            cmbWarehouse.DataSource = _warehouseLogic.GetAllWarehouse();
            cmbWarehouse.DisplayMember = "Name";
            cmbWarehouse.ValueMember = "WarehouseTypeID";

            //tip dokumenta
            cbDocumentType.Enabled = false;
            cbDocumentType.DisplayMember = "Description";
            cbDocumentType.ValueMember = "Value";
            cbDocumentType.DataSource = Enum.GetValues(typeof(Classes.Lib.DocumentType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();
            cbDocumentType.SelectedIndex = DocumentTypeID;


            DGVReceiptsDespatchsItems.AutoGenerateColumns = false;
            BindingSource bs = new BindingSource();
            bs.DataSource = _document.DocumentItems;
            bs.AllowNew = true;
            DGVReceiptsDespatchsItems.DataSource = bs;
            DGVReceiptsDespatchsItems.AllowUserToAddRows = true;
            DGVReceiptsDespatchsItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            DGVReceiptsDespatchsItems.Columns.Add("ItemName", "Naziv artikla");
            DGVReceiptsDespatchsItems.Columns.Add("Quantity", "Kolicina");
            DGVReceiptsDespatchsItems.Columns.Add("ItemPrice", "Cena");
            DGVReceiptsDespatchsItems.Columns.Add("Width", "Sirina");
            DGVReceiptsDespatchsItems.Columns.Add("Height", "Visina");

            DGVReceiptsDespatchsItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGVReceiptsDespatchsItems.ReadOnly = false;
            DGVReceiptsDespatchsItems.AllowUserToDeleteRows = true;
            bs.AddingNew += Bs_AddingNew;
            DGVReceiptsDespatchsItems.Click += Right_Click;
            DGVReceiptsDespatchsItems.UserDeletingRow += DGVReceiptsDespatchs_UserDeletingRow;
            DGVReceiptsDespatchsItems.UserDeletedRow += DGVReceiptsDespatchs_UserDeletedRow;
            DGVReceiptsDespatchsItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyDataGridView_MouseDown);
            SelectedRow.Click += new System.EventHandler(this.SelectedRow_Click);
            DGVReceiptsDespatchsItems.Refresh();
        }

        private void Bs_AddingNew(object sender, AddingNewEventArgs e)
        {
            //DocumentItem newObj = new DocumentItem();
            //_document.DocumentItems.Add(newObj);
            //e.NewObject = new Warehouse();
        }

        private void SetAllControlsReadOnly()
        {
            foreach (var cntrl in this.Controls)
            {
                ((Control)cntrl).Enabled = false;
            }
            btnCancel.Enabled = true;
        }

        private void SelectedRow_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = DGVReceiptsDespatchsItems.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            DGVReceiptsDespatchsItems.Rows.RemoveAt(rowToDelete);
            DGVReceiptsDespatchsItems.ClearSelection();
        }

        private void MyDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = DGVReceiptsDespatchsItems.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0)
                {
                    DGVReceiptsDespatchsItems.ClearSelection();
                    DGVReceiptsDespatchsItems.Rows[hti.RowIndex].Selected = true;
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
                //_document = _documentLogic.GetDocumentByDocumentID( Int32.Parse(e.Row.Cells["ID"].Value.ToString()));
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
                cm.MenuItems.Add("Dodaj dokument", new EventHandler(AddNewDocumentItem_Click));
                if (DGVReceiptsDespatchsItems.SelectedRows.Count == 1)
                {
                    cm.MenuItems.Add("Izmeni dokument", new EventHandler(EditRow_Click));
                }
                cm.Show(DGVReceiptsDespatchsItems, new Point(me.X, me.Y));
            }
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            if (DGVReceiptsDespatchsItems.SelectedRows.Count == 1)
            {
                var clientForEdit = (Client)DGVReceiptsDespatchsItems.SelectedRows[0].DataBoundItem;
                //frmNewReceiptsDespatchs editClient = new frmNewReceiptsDespatchs(clientForEdit);
                frmNewReceiptsDespatchs editClient = new frmNewReceiptsDespatchs();
                editClient.ShowDialog();
                DGVReceiptsDespatchsItems.ClearSelection();
            }
        }

        private void AddNewDocumentItem_Click(object sender, EventArgs e)
        {
            var newItemForm = new frmNewClient();
            newItemForm.ShowDialog();
            RefreshDGVSource();
        }
        private void RefreshDGVSource()
        {
            //DGVReceiptsDespatchs.DataSource = _documentLogic.GetAllDocuments();
            DGVReceiptsDespatchsItems.RefreshEdit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //    DGVReceiptsDespatchs.DataSource = new BindingList<Client>(_documentLogic.GetClientByName(tbSearchName.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClients fc = new frmClients();
            fc.SelectionMode = true;
            fc.ShowDialog();
            if (fc.SelectedClient != null)
            {
                _document.Client = fc.SelectedClient;
                BindClientProperties();
            }
        }

        private void BindClientProperties()
        {
            tbName.DataBindings.Clear();
            tbName.DataBindings.Add("Text", _document.Client, "Name");

            tbMB.DataBindings.Clear();
            tbMB.DataBindings.Add("Text", _document.Client, "MB");

            tbPIB.DataBindings.Clear();
            tbPIB.DataBindings.Add("Text", _document.Client, "PIB");

            tbAddress.DataBindings.Clear();
            tbAddress.DataBindings.Add("Text", _document.Client, "Address");

            tbBankAccount.DataBindings.Clear();
            tbBankAccount.DataBindings.Add("Text", _document.Client, "BankAccount");

            tbPhoneFax.DataBindings.Clear();
            tbPhoneFax.DataBindings.Add("Text", _document.Client, "PhoneFax");

            tbEmail.DataBindings.Clear();
            tbEmail.DataBindings.Add("Text", _document.Client, "Email");

            tbPhone.DataBindings.Clear();
            tbPhone.DataBindings.Add("Text", _document.Client, "Phone");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            _document.Warehouse = (Warehouse)cmbWarehouse.SelectedItem;
        }
    }
}
