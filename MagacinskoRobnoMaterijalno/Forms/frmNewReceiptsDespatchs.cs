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
using MagacinskoRobnoMaterijalno.Models;

namespace MagacinskoRobnoMaterijalno.Forms
{
    public partial class frmNewReceiptsDespatchs : Form
    {
        private DocumentLogic _documentLogic;
        private ClientLogic _clientLogic;
        private WarehouseLogic _warehouseLogic;
        private Dictionary<int, string> documentTypeDictionary;
        private Dictionary<int, string> documentStatusDictionary;
        public frmNewReceiptsDespatchs()
        {
            InitializeComponent();
            InitNewReceiptsDespatchs();
        }

        private void InitNewReceiptsDespatchs()
        {
            _documentLogic = new DocumentLogic();
            documentTypeDictionary = new Dictionary<int, string>();
            documentStatusDictionary = new Dictionary<int, string>();
            _clientLogic = new ClientLogic();
            _warehouseLogic = new WarehouseLogic();
            documentTypeDictionary.Add(2, "Svi");
            documentTypeDictionary.Add(0, "Prijemnica");
            documentTypeDictionary.Add(1, "Otpremnica");
            cmbDocumentType.DisplayMember = "Value";
            cmbDocumentType.ValueMember = "Key";
            cmbDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDocumentType.DataSource = documentTypeDictionary.ToList();


            documentStatusDictionary = new Dictionary<int, string>();
            documentStatusDictionary.Add(3, "Svi");
            documentStatusDictionary.Add(0, "Neplaćeni");
            documentStatusDictionary.Add(1, "Plaćeni");
            documentStatusDictionary.Add(2, "Storno");
            cmbDocumentStatus.DisplayMember = "Value";
            cmbDocumentStatus.ValueMember = "Key";
            cmbDocumentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDocumentStatus.DataSource = documentStatusDictionary.ToList();

            var statuses = new List<Status>() { new Status() { ID = 0, Name = "Neplaćeni" }, new Status() { ID = 1, Name = "Plaćeni" }, new Status() { ID = 2, Name = "Storno" } };

            documentTypeBindingSource.DataSource = statuses.ToList();
            documentBindingSource.DataSource = _documentLogic.GetAllDocuments();
            clientBindingSource.DataSource = _clientLogic.GetAllClients();
            warehouseBindingSource.DataSource = _warehouseLogic.GetAllWarehouse();

            DGVNewReceiptDespatch.DataError += DGVNewReceiptDespatch_DataError;
            DGVNewReceiptDespatch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVNewReceiptDespatch.DoubleClick += SelectedRow_DoubleClick;
            DGVNewReceiptDespatch.CellFormatting += DGVNewReceiptDespatch_CellFormatting;

        }

        private void DGVNewReceiptDespatch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = DGVNewReceiptDespatch.Rows[e.RowIndex];
            if (((Document)(row.DataBoundItem)).DocumentType == (int)Lib.DocumentType.Payment)
            {
                row.DefaultCellStyle.BackColor = Color.PapayaWhip;
            }
            if (DGVNewReceiptDespatch.Columns[e.ColumnIndex].Name == "Payed" && e.Value == null)
            {
                if (((Document)(row.DataBoundItem)).DocumentType == (int)Lib.DocumentType.Despatch)
                {
                    decimal sum = _documentLogic.GetAllDocuments()
                        .Where(x => x.LinkDocumentNo == ((Document)(row.DataBoundItem)).DocumentNo)
                        .Where(x => x.StatusID == (int)Lib.StatusEnum.Vazeci)
                        .Sum(x => x.TotalPrice);
                    e.Value = sum.ToString("N2");
                }
            }
        }


        private void SelectedRow_DoubleClick(object sender, EventArgs e)
        {
            var selected = DGVNewReceiptDespatch.SelectedRows[0];
            if (selected != null)
            {
                frmReceiptsDespatchs EditDocument = new frmReceiptsDespatchs((Document)((DataGridViewRow)selected).DataBoundItem, this);
                EditDocument.Show();
            }
        }
        public void RefreshFromAnotherForm()
        {
            DGVNewReceiptDespatch.DataSource = null;
            documentBindingSource = new BindingSource();
            documentBindingSource.DataSource = _documentLogic.GetAllDocuments();
            DGVNewReceiptDespatch.DataSource = documentBindingSource;
            DGVNewReceiptDespatch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void DGVNewReceiptDespatch_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnNewDespatch_Click(object sender, EventArgs e)
        {
            frmReceiptsDespatchs _despatch = new frmReceiptsDespatchs((int)Lib.DocumentType.Despatch, this);
            _despatch.Show();
        }

        private void btnNewReceipt_Click(object sender, EventArgs e)
        {
            frmReceiptsDespatchs _receipt = new frmReceiptsDespatchs((int)Lib.DocumentType.Receipt, this);
            _receipt.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void DGVNewReceiptDespatch_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                int currentMouseOverRow = DGVNewReceiptDespatch.HitTest(e.X, e.Y).RowIndex;
                Document selDoc = (Document)DGVNewReceiptDespatch.Rows[currentMouseOverRow].DataBoundItem;
                if (selDoc.DocumentType == (int)Lib.DocumentType.Despatch)
                {
                    MenuItem mi = new MenuItem(string.Format("Napravi delimicnu otplatu za {0}", selDoc.DocumentNo));
                    mi.Tag = selDoc;
                    mi.Click += new System.EventHandler(this.menuItem1_Click);
                    m.MenuItems.Add(mi);
                }
                m.Show(DGVNewReceiptDespatch, new Point(e.X, e.Y));
            }
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            frmReceiptsDespatchs _despatch = new frmReceiptsDespatchs((int)Lib.DocumentType.Payment, (Document)(((MenuItem)sender).Tag), this);
            _despatch.FormMode = Lib.FormMode.New;
            _despatch.Show();
        }
    }
}
