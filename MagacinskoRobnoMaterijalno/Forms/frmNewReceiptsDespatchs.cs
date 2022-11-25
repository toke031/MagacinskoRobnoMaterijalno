using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using MagacinskoRobnoMaterijalno.Classes;
using MagacinskoRobnoMaterijalno.Data.Model;

namespace MagacinskoRobnoMaterijalno.Forms
{
    public partial class FrmNewReceiptsDespatchs : Form
    {
        private DocumentLogic _documentLogic;
        private ClientLogic _clientLogic;
        private WarehouseLogic _warehouseLogic;
        private Dictionary<int, string> documentTypeDictionary;
        private Dictionary<int, string> documentStatusDictionary;

        public IMapper Mapper;
        public FrmNewReceiptsDespatchs()
        {
            InitializeComponent();
            InitNewReceiptsDespatchs();
            var AutoMapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutomapperConfiguration>();
            });
            Mapper = AutoMapperConfiguration.CreateMapper();
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


            documentStatusDictionary = new Dictionary<int, string>
            {
                { 3, "Svi" },
                { 0, "Neplaćeni" },
                { 1, "Plaćeni" },
                { 2, "Storno" }
            };
            cmbDocumentStatus.DisplayMember = "Value";
            cmbDocumentStatus.ValueMember = "Key";
            cmbDocumentStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            dtCreatedDateFrom.Format = DateTimePickerFormat.Custom;
            dtCreatedDateFrom.Value = DateTime.Today.AddDays(-30);
            dtCreatedDateTo.Format = DateTimePickerFormat.Custom;
            dtCreatedDateFrom.CustomFormat = "MM/dd/yyyy";
            dtCreatedDateTo.CustomFormat = "MM/dd/yyyy";
            cmbDocumentStatus.DataSource = documentStatusDictionary.ToList();

            var statuses = new List<Status>() { new Status() { ID = 0, Name = "Neplaćeni" }, new Status() { ID = 1, Name = "Plaćeni" }, new Status() { ID = 2, Name = "Storno" } };

            documentTypeBindingSource.DataSource = statuses.ToList();
          //  documentBindingSource.DataSource = _documentLogic.GetDocumentForLast30Days();
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
                if (((Document)(row.DataBoundItem)).DocumentType == (int)Lib.DocumentType.Despatch && ((Document)(row.DataBoundItem)).StatusID == (int)Lib.StatusEnum.Vazeci)
                {
                    decimal sum = _documentLogic.GetAllDocuments(x => x.LinkDocumentNo == ((Document)(row.DataBoundItem)).DocumentNo && x.StatusID == (int)Lib.StatusEnum.Vazeci)
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
                FrmReceiptsDespatchs EditDocument = new FrmReceiptsDespatchs((Document)((DataGridViewRow)selected).DataBoundItem, this);
                EditDocument.Show();
            }
        }

        public void SetDataSourceofDataGridView(BindingList<Document> dataSource)
        {
            DGVNewReceiptDespatch.DataSource = null;
            documentBindingSource = new BindingSource
            {
                DataSource = dataSource
            };
            DGVNewReceiptDespatch.DataSource = documentBindingSource;
            DGVNewReceiptDespatch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void RefreshFromAnotherForm()
        {
            DGVNewReceiptDespatch.DataSource = null;
            documentBindingSource = new BindingSource
            {
                DataSource = _documentLogic.GetDocumentForLast30Days()
            };
            DGVNewReceiptDespatch.DataSource = documentBindingSource;
            DGVNewReceiptDespatch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void DGVNewReceiptDespatch_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void BtnNewDespatch_Click(object sender, EventArgs e)
        {
            FrmReceiptsDespatchs _despatch = new FrmReceiptsDespatchs((int)Lib.DocumentType.Despatch, this);
            _despatch.Show();
        }

        private void BtnNewReceipt_Click(object sender, EventArgs e)
        {
            FrmReceiptsDespatchs _receipt = new FrmReceiptsDespatchs((int)Lib.DocumentType.Receipt, this);
            _receipt.Show();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var listOfParams = new Dictionary<string, string>
            {
                { "Name", tbName.Text }
            };
            if (dtCreatedDateFrom.Value.Date > dtCreatedDateTo.Value.Date)
            {
                MessageBox.Show("Datum od ne moze biti veci od datuma do.");
                return;
            }
            listOfParams.Add("CreatedDateFrom", dtCreatedDateFrom.Value.ToString("MM/dd/yyyy"));
            listOfParams.Add("CreatedDateTo", dtCreatedDateTo.Value.ToString("MM/dd/yyyy"));
            if (cmbDocumentStatus.SelectedIndex != 0)
            {
                listOfParams.Add("DocumentStatus", cmbDocumentStatus.SelectedValue.ToString());
            }
            if (cmbDocumentType.SelectedIndex != 0)
            {
                listOfParams.Add("DocumentType", cmbDocumentType.SelectedValue.ToString());
            }
            BindingList<Document> Documents =_documentLogic.SearchDocuments(listOfParams);
            SetDataSourceofDataGridView(Documents);
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
                    MenuItem mi = new MenuItem(string.Format("Napravi delimicnu otplatu za {0}", selDoc.DocumentNo))
                    {
                        Tag = selDoc
                    };
                    mi.Click += new System.EventHandler(this.MenuItem1_Click);
                    m.MenuItems.Add(mi);
                }
                m.Show(DGVNewReceiptDespatch, new Point(e.X, e.Y));
            }
        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            FrmReceiptsDespatchs _despatch = new FrmReceiptsDespatchs((int)Lib.DocumentType.Payment, (Document)(((MenuItem)sender).Tag), this)
            {
                FormMode = Lib.FormMode.New
            };
            _despatch.Show();
        }
    }
}
