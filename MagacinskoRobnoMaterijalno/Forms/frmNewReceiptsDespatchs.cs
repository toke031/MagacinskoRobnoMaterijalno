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

            documentBindingSource.DataSource = _documentLogic.GetAllDocuments();
            clientBindingSource.DataSource = _clientLogic.GetAllClients();

            DGVNewReceiptDespatch.DataError += DGVNewReceiptDespatch_DataError;
            DGVNewReceiptDespatch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVNewReceiptDespatch.DoubleClick += SelectedRow_DoubleClick;
        }

        private void SelectedRow_DoubleClick(object sender, EventArgs e)
        {
            var selected = DGVNewReceiptDespatch.SelectedRows[0];
            if (selected != null)
            {
                frmReceiptsDespatchs EditDocument = new frmReceiptsDespatchs((Document)((DataGridViewRow)selected).DataBoundItem);
                EditDocument.Show();
            }
        }


        private void DGVNewReceiptDespatch_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnNewDespatch_Click(object sender, EventArgs e)
        {
            frmReceiptsDespatchs _despatch = new frmReceiptsDespatchs((int)Lib.DocumentType.Despatch);
            _despatch.Show();
        }

        private void btnNewReceipt_Click(object sender, EventArgs e)
        {
            frmReceiptsDespatchs _receipt = new frmReceiptsDespatchs((int)Lib.DocumentType.Receipt);
            _receipt.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
