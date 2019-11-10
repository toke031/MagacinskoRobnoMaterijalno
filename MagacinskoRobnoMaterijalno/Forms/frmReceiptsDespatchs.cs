﻿using MagacinskoRobnoMaterijalno.Classes;
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
        ArticalLogic _articalLogic;
        Document _document;
        List<Article> listaArtikla;
        BindingList<DocumentItem> listaStavki = new BindingList<DocumentItem>();
        public frmReceiptsDespatchs(int documentTypeID)
        {
            DocumentTypeID = documentTypeID;
            InitializeComponent();
            InitDocument();
        }
        public frmReceiptsDespatchs(Document document)
        {
            SelectedDocument = document;
            this.FormMode = FormMode.Modifying;
            InitializeComponent();
            InitDocument();
        }

        private void InitDocument()
        {
            _articalLogic = new ArticalLogic();
            _documentLogic = new DocumentLogic();
            _warehouseLogic = new WarehouseLogic();
            if (FormMode == FormMode.New)
            {
                    _document = new Document();
                    _documentLogic.AddDocument(_document);
               
                // datum
                _document.DocumentDateTime = DateTime.Now;
                _document.PaymentEndDate = DateTime.Now;
                _document.PaymentDate = DateTime.Now;
                _document.DocumentType = DocumentTypeID;
                _document.DocumentNo = (DocumentTypeID == 0 ? "P" : "O") + "-" + _documentLogic.GetLastNoForDoument(_document.DocumentDateTime.Year, DocumentTypeID) + "-" + DateTime.Now.Year;
            }
            else if (FormMode == FormMode.Modifying || FormMode == FormMode.ReadOnly)
            {
                _document = _documentLogic.GetDocument(SelectedDocument.ID);
                if (FormMode == FormMode.ReadOnly)
                {
                    SetAllControlsReadOnly();
                }
            }

            if (_document.Client != null)
            {
                BindClientProperties();
            }

            tbTotalWithVAT.DataBindings.Clear();
            tbTotalWithVAT.DataBindings.Add("Text", _document, "TotalPrice");
            tbDocumentNo.DataBindings.Clear();
            tbDocumentNo.DataBindings.Add("Text", _document, "DocumentNo");

            dtpCreationDate.DataBindings.Clear();
            dtpCreationDate.DataBindings.Add("Value", _document, "DocumentDateTime");
            dtpEndDateForPayment.DataBindings.Clear();
            dtpEndDateForPayment.DataBindings.Add("Value", _document, "PaymentEndDate");
            dtpPaymentDate.DataBindings.Clear();
            dtpPaymentDate.DataBindings.Add("Value", _document, "PaymentDate");

            // status
            cmbStatus.DisplayMember = "Description";
            cmbStatus.DataSource = Enum.GetValues(typeof(Classes.Lib.StatusEnum))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    v = (int)(Enum.Parse(typeof(Classes.Lib.StatusEnum), value.ToString()))
                })
                .OrderBy(item => item.v)
                .ToList();
            // magacini
            cmbWarehouse.DataSource = _warehouseLogic.GetAllWarehouse();
            cmbWarehouse.DisplayMember = "Name";
            cmbWarehouse.ValueMember = "WarehouseTypeID";
            cmbWarehouse.SelectedIndexChanged += CmbWarehouse_ValuseChanged;

            // tip dokumenta
            cmbDocumentType.DisplayMember = "Description";
            cmbDocumentType.DataSource = Enum.GetValues(typeof(Classes.Lib.DocumentType))
                .Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    v = (int)(Enum.Parse(typeof(Classes.Lib.DocumentType), value.ToString()))
                })
                .OrderBy(item => item.v)
                .ToList();
            cmbDocumentType.Enabled = false;
            cmbDocumentType.SelectedIndex = _document.DocumentType;
            this.Text = cmbDocumentType.Text;

            listaArtikla = _articalLogic.GetAllArticlesByWarehouseType(cmbWarehouse.SelectedIndex).ToList();

            documentItemBindingSource.DataSource = _document.DocumentItems;
            articleBindingSource.DataSource = listaArtikla;
            documentItemBindingSource.ListChanged += DocumentItemBindingSource_ListChanged;
            documentItemBindingSource.CurrentChanged += DocumentItemBindingSource_CurrentChanged;

            DGVReceiptsDespatchsItems.DataError += DGVReceiptsDespatchsItems_DataError;
            DGVReceiptsDespatchsItems.CellValueChanged += DGVReceiptsDespatchsItems_CellValueChanged;
            DGVReceiptsDespatchsItems.CellContentClick += DGVReceiptsDespatchsItems_CellContentClick;
        }

        private void CmbWarehouse_ValuseChanged(object sender, EventArgs e)
        {
            listaArtikla = _articalLogic.GetAllArticlesByWarehouseType(cmbWarehouse.SelectedIndex).ToList();
            articleBindingSource.DataSource = listaArtikla;
        }

        private void Calculate()
        {
            decimal totalWithWAT = _document.DocumentItems.Sum(x => (x.Quantity * x.QuantityItemPrice) * (((x.Height * x.Width) != 0) ? ((x.Height / 100) * (x.Width / 100)) : 1));

            tbTotal.Text = (totalWithWAT - (totalWithWAT * 0.2M)).ToString("N2");
            tbVat.Text = (totalWithWAT * 0.2M).ToString("N2");
            _document.TotalPrice = totalWithWAT;
            tbTotalWithVAT.Text = _document.TotalPrice.ToString("N2");
            tbTotalWithVAT.Update();

        }
        private void DocumentItemBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void CalculateSumOfRow(ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                DocumentItem doci = ((DocumentItem)DGVReceiptsDespatchsItems.Rows[e.NewIndex].DataBoundItem);
                decimal povrsina = (doci.Width / 100) * (doci.Height / 100);
                doci.ItemPrice = doci.Quantity * doci.QuantityItemPrice * ((povrsina != 0) ? (povrsina) : 1);
            }
        }

        private void DocumentItemBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            CalculateSumOfRow(e);
            Calculate();
            SetRb();
        }

        private void SetRb()
        {
            int i = 1;
            foreach (DataGridViewRow row in DGVReceiptsDespatchsItems.Rows)
                row.Cells["Rb"].Value = i++;
        }

        private void DGVReceiptsDespatchsItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //throw new NotImplementedException();
        }

        bool inload = false;
        private void DGVReceiptsDespatchsItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (inload)
                return;
            inload = true;
            if (DGVReceiptsDespatchsItems.Columns[e.ColumnIndex].Name == "ArticleNoUnbound")
            {
                if (DGVReceiptsDespatchsItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null || DGVReceiptsDespatchsItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == "")
                {
                    ((DocumentItem)DGVReceiptsDespatchsItems.Rows[e.RowIndex].DataBoundItem).Item = null;
                    ((DocumentItem)DGVReceiptsDespatchsItems.Rows[e.RowIndex].DataBoundItem).ArticleNo = null;
                    ((DocumentItem)DGVReceiptsDespatchsItems.Rows[e.RowIndex].DataBoundItem).QuantityItemPrice = 0;
                }
                else
                {
                    Article pronadjen = listaArtikla.FirstOrDefault(x => x.ArticleNo == DGVReceiptsDespatchsItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    if (pronadjen != null)
                    {
                        ((DocumentItem)DGVReceiptsDespatchsItems.Rows[e.RowIndex].DataBoundItem).Item = (pronadjen);
                        ((DocumentItem)DGVReceiptsDespatchsItems.Rows[e.RowIndex].DataBoundItem).ArticleNo = pronadjen.ArticleNo;
                        ((DocumentItem)DGVReceiptsDespatchsItems.Rows[e.RowIndex].DataBoundItem).QuantityItemPrice = pronadjen.QuantityItemPrice;
                    }
                    else
                    {
                        DGVReceiptsDespatchsItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "";
                        DGVReceiptsDespatchsItems.Refresh();
                    }
                    
                }

            }
            if (DGVReceiptsDespatchsItems.Columns[e.ColumnIndex].Name == "ArticleNo")
            {
                var stavka = ((DocumentItem)DGVReceiptsDespatchsItems.Rows[e.RowIndex].DataBoundItem);
                Article pronadjen = listaArtikla.FirstOrDefault(x => x.ArticleNo == stavka.ArticleNo);
                //Article pronadjen = stavka.Item;
                if (pronadjen != null)
                {
                    stavka.Item = (pronadjen);
                    stavka.ArticleNo = pronadjen.ArticleNo;
                    stavka.QuantityItemPrice = pronadjen.QuantityItemPrice;
                    DGVReceiptsDespatchsItems.Rows[e.RowIndex].Cells["ArticleNoUnbound"].Value = pronadjen.ArticleNo;
                }

            }

            inload = false;
            DGVReceiptsDespatchsItems.Refresh();
        }
        private void DGVReceiptsDespatchsItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex].Name == "DeleteDocumentItem")
            {
                var stavka = ((DocumentItem)DGVReceiptsDespatchsItems.Rows[e.RowIndex].DataBoundItem);
                if (stavka != null)
                {
                    _document.DocumentItems.Remove(stavka);
                }
            }
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
                _document.ClientID = fc.SelectedClient.ID;
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
            Sacuvaj();
        }
        private void Sacuvaj()
        {
            if(_document.DocumentItems.Any(x=>x.Item == null))
            {
                MessageBox.Show("Niste izabrali artikal");
                return;
            }
            _document.StatusID = (int)cmbStatus.SelectedItem.GetType().GetProperty("v").GetValue(cmbStatus.SelectedItem, null);
            _documentLogic.SaveAllChanges();
            MessageBox.Show("Dokument je sacuvan", "Cuvanje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            _document.Warehouse = (Warehouse)cmbWarehouse.SelectedItem;
        }

        private void frmReceiptsDespatchs_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dres = MessageBox.Show("Da li zelite da sacuvate dokument", "Izlaz", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dres == DialogResult.Yes)
            {
                Sacuvaj();
            }
            else if (dres == DialogResult.No)
            {
                e.Cancel = false;
            }
            else if (dres == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
