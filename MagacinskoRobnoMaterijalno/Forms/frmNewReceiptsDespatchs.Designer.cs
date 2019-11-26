namespace MagacinskoRobnoMaterijalno.Forms
{
    partial class frmNewReceiptsDespatchs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVNewReceiptDespatch = new System.Windows.Forms.DataGridView();
            this.documentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkDocumentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.statusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.documentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentEndDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDocumentType = new System.Windows.Forms.Label();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.blbDocumentStatus = new System.Windows.Forms.Label();
            this.cmbDocumentStatus = new System.Windows.Forms.ComboBox();
            this.lblDateOfCreationFrom = new System.Windows.Forms.Label();
            this.dtCreatedDateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnNewDespatch = new System.Windows.Forms.Button();
            this.btnNewReceipt = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lblDateOfCreationTo = new System.Windows.Forms.Label();
            this.dtCreatedDateTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewReceiptDespatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DGVNewReceiptDespatch);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1149, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dokumenti";
            // 
            // DGVNewReceiptDespatch
            // 
            this.DGVNewReceiptDespatch.AllowUserToAddRows = false;
            this.DGVNewReceiptDespatch.AutoGenerateColumns = false;
            this.DGVNewReceiptDespatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNewReceiptDespatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentNoDataGridViewTextBoxColumn,
            this.LinkDocumentNo,
            this.Client,
            this.documentTypeDataGridViewTextBoxColumn,
            this.statusIDDataGridViewTextBoxColumn,
            this.documentDateTimeDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.paymentEndDateDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.warehouseDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.documentItemsDataGridViewTextBoxColumn,
            this.Payed});
            this.DGVNewReceiptDespatch.DataSource = this.documentBindingSource;
            this.DGVNewReceiptDespatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVNewReceiptDespatch.Location = new System.Drawing.Point(3, 16);
            this.DGVNewReceiptDespatch.MultiSelect = false;
            this.DGVNewReceiptDespatch.Name = "DGVNewReceiptDespatch";
            this.DGVNewReceiptDespatch.ReadOnly = true;
            this.DGVNewReceiptDespatch.Size = new System.Drawing.Size(1143, 277);
            this.DGVNewReceiptDespatch.TabIndex = 0;
            this.DGVNewReceiptDespatch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGVNewReceiptDespatch_MouseClick);
            // 
            // documentNoDataGridViewTextBoxColumn
            // 
            this.documentNoDataGridViewTextBoxColumn.DataPropertyName = "DocumentNo";
            this.documentNoDataGridViewTextBoxColumn.HeaderText = "Broj dokumenta";
            this.documentNoDataGridViewTextBoxColumn.Name = "documentNoDataGridViewTextBoxColumn";
            this.documentNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // LinkDocumentNo
            // 
            this.LinkDocumentNo.DataPropertyName = "LinkDocumentNo";
            this.LinkDocumentNo.HeaderText = "Spoljni broj ";
            this.LinkDocumentNo.Name = "LinkDocumentNo";
            this.LinkDocumentNo.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "ClientID";
            this.Client.DataSource = this.clientBindingSource;
            this.Client.DisplayMember = "Name";
            this.Client.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Client.HeaderText = "Klijent";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Client.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Client.ValueMember = "ID";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(MagacinskoRobnoMaterijalno.Models.Client);
            // 
            // documentTypeDataGridViewTextBoxColumn
            // 
            this.documentTypeDataGridViewTextBoxColumn.DataPropertyName = "DocumentType";
            this.documentTypeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.documentTypeDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.documentTypeDataGridViewTextBoxColumn.HeaderText = "Tip dokumenta";
            this.documentTypeDataGridViewTextBoxColumn.Name = "documentTypeDataGridViewTextBoxColumn";
            this.documentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.documentTypeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.documentTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // statusIDDataGridViewTextBoxColumn
            // 
            this.statusIDDataGridViewTextBoxColumn.DataPropertyName = "StatusID";
            this.statusIDDataGridViewTextBoxColumn.DataSource = this.documentTypeBindingSource;
            this.statusIDDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.statusIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusIDDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusIDDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusIDDataGridViewTextBoxColumn.Name = "statusIDDataGridViewTextBoxColumn";
            this.statusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // documentTypeBindingSource
            // 
            this.documentTypeBindingSource.DataSource = typeof(MagacinskoRobnoMaterijalno.Classes.Status);
            // 
            // documentDateTimeDataGridViewTextBoxColumn
            // 
            this.documentDateTimeDataGridViewTextBoxColumn.DataPropertyName = "DocumentDateTime";
            this.documentDateTimeDataGridViewTextBoxColumn.HeaderText = "Datum kreiranja dokumenta";
            this.documentDateTimeDataGridViewTextBoxColumn.Name = "documentDateTimeDataGridViewTextBoxColumn";
            this.documentDateTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "Datum paćanja";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentEndDateDataGridViewTextBoxColumn
            // 
            this.paymentEndDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentEndDate";
            this.paymentEndDateDataGridViewTextBoxColumn.HeaderText = "Krajnji datum plaćanja";
            this.paymentEndDateDataGridViewTextBoxColumn.Name = "paymentEndDateDataGridViewTextBoxColumn";
            this.paymentEndDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // warehouseDataGridViewTextBoxColumn
            // 
            this.warehouseDataGridViewTextBoxColumn.DataPropertyName = "WarehouseID";
            this.warehouseDataGridViewTextBoxColumn.DataSource = this.warehouseBindingSource;
            this.warehouseDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.warehouseDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.warehouseDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warehouseDataGridViewTextBoxColumn.HeaderText = "Magacin";
            this.warehouseDataGridViewTextBoxColumn.Name = "warehouseDataGridViewTextBoxColumn";
            this.warehouseDataGridViewTextBoxColumn.ReadOnly = true;
            this.warehouseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.warehouseDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.warehouseDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataSource = typeof(MagacinskoRobnoMaterijalno.Models.Warehouse);
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Ukupna cena";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentItemsDataGridViewTextBoxColumn
            // 
            this.documentItemsDataGridViewTextBoxColumn.DataPropertyName = "DocumentItems";
            this.documentItemsDataGridViewTextBoxColumn.HeaderText = "DocumentItems";
            this.documentItemsDataGridViewTextBoxColumn.Name = "documentItemsDataGridViewTextBoxColumn";
            this.documentItemsDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentItemsDataGridViewTextBoxColumn.Visible = false;
            // 
            // Payed
            // 
            this.Payed.HeaderText = "Placeno";
            this.Payed.Name = "Payed";
            this.Payed.ReadOnly = true;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataSource = typeof(MagacinskoRobnoMaterijalno.Models.Document);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(88, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(93, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Naziv klijenta:";
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.dtCreatedDateTo);
            this.gbSearch.Controls.Add(this.lblDateOfCreationTo);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.lblDocumentType);
            this.gbSearch.Controls.Add(this.cmbDocumentType);
            this.gbSearch.Controls.Add(this.blbDocumentStatus);
            this.gbSearch.Controls.Add(this.cmbDocumentStatus);
            this.gbSearch.Controls.Add(this.lblDateOfCreationFrom);
            this.gbSearch.Controls.Add(this.dtCreatedDateFrom);
            this.gbSearch.Controls.Add(this.lblName);
            this.gbSearch.Controls.Add(this.tbName);
            this.gbSearch.Location = new System.Drawing.Point(15, 4);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(418, 116);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Pretraga";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(288, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 30);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblDocumentType
            // 
            this.lblDocumentType.AutoSize = true;
            this.lblDocumentType.Location = new System.Drawing.Point(201, 56);
            this.lblDocumentType.Name = "lblDocumentType";
            this.lblDocumentType.Size = new System.Drawing.Size(81, 13);
            this.lblDocumentType.TabIndex = 8;
            this.lblDocumentType.Text = "Tip dokumenta:";
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Location = new System.Drawing.Point(288, 53);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(118, 21);
            this.cmbDocumentType.TabIndex = 7;
            // 
            // blbDocumentStatus
            // 
            this.blbDocumentStatus.AutoSize = true;
            this.blbDocumentStatus.Location = new System.Drawing.Point(187, 16);
            this.blbDocumentStatus.Name = "blbDocumentStatus";
            this.blbDocumentStatus.Size = new System.Drawing.Size(96, 13);
            this.blbDocumentStatus.TabIndex = 6;
            this.blbDocumentStatus.Text = "Status dokumenta:";
            // 
            // cmbDocumentStatus
            // 
            this.cmbDocumentStatus.FormattingEnabled = true;
            this.cmbDocumentStatus.Location = new System.Drawing.Point(288, 12);
            this.cmbDocumentStatus.Name = "cmbDocumentStatus";
            this.cmbDocumentStatus.Size = new System.Drawing.Size(118, 21);
            this.cmbDocumentStatus.TabIndex = 5;
            // 
            // lblDateOfCreationFrom
            // 
            this.lblDateOfCreationFrom.AutoSize = true;
            this.lblDateOfCreationFrom.Location = new System.Drawing.Point(6, 56);
            this.lblDateOfCreationFrom.Name = "lblDateOfCreationFrom";
            this.lblDateOfCreationFrom.Size = new System.Drawing.Size(99, 13);
            this.lblDateOfCreationFrom.TabIndex = 4;
            this.lblDateOfCreationFrom.Text = "Datum kreiranja od:";
            // 
            // dtCreatedDateFrom
            // 
            this.dtCreatedDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreatedDateFrom.Location = new System.Drawing.Point(102, 53);
            this.dtCreatedDateFrom.Name = "dtCreatedDateFrom";
            this.dtCreatedDateFrom.Size = new System.Drawing.Size(93, 20);
            this.dtCreatedDateFrom.TabIndex = 3;
            // 
            // btnNewDespatch
            // 
            this.btnNewDespatch.Location = new System.Drawing.Point(611, 4);
            this.btnNewDespatch.Name = "btnNewDespatch";
            this.btnNewDespatch.Size = new System.Drawing.Size(158, 31);
            this.btnNewDespatch.TabIndex = 4;
            this.btnNewDespatch.Text = "Kreiraj otpremnicu";
            this.btnNewDespatch.UseVisualStyleBackColor = true;
            this.btnNewDespatch.Click += new System.EventHandler(this.btnNewDespatch_Click);
            // 
            // btnNewReceipt
            // 
            this.btnNewReceipt.Location = new System.Drawing.Point(611, 51);
            this.btnNewReceipt.Name = "btnNewReceipt";
            this.btnNewReceipt.Size = new System.Drawing.Size(158, 31);
            this.btnNewReceipt.TabIndex = 5;
            this.btnNewReceipt.Text = "Kreiraj prijemnicu";
            this.btnNewReceipt.UseVisualStyleBackColor = true;
            this.btnNewReceipt.Click += new System.EventHandler(this.btnNewReceipt_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Client";
            this.dataGridViewTextBoxColumn1.HeaderText = "Client";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "Client";
            this.dataGridViewComboBoxColumn1.HeaderText = "Client";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.DataPropertyName = "Client";
            this.dataGridViewComboBoxColumn2.HeaderText = "Client";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lblDateOfCreationTo
            // 
            this.lblDateOfCreationTo.AutoSize = true;
            this.lblDateOfCreationTo.Location = new System.Drawing.Point(9, 89);
            this.lblDateOfCreationTo.Name = "lblDateOfCreationTo";
            this.lblDateOfCreationTo.Size = new System.Drawing.Size(99, 13);
            this.lblDateOfCreationTo.TabIndex = 10;
            this.lblDateOfCreationTo.Text = "Datum kreiranja do:";
            // 
            // dtCreatedDateTo
            // 
            this.dtCreatedDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreatedDateTo.Location = new System.Drawing.Point(102, 89);
            this.dtCreatedDateTo.Name = "dtCreatedDateTo";
            this.dtCreatedDateTo.Size = new System.Drawing.Size(93, 20);
            this.dtCreatedDateTo.TabIndex = 11;
            // 
            // frmNewReceiptsDespatchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 517);
            this.Controls.Add(this.btnNewReceipt);
            this.Controls.Add(this.btnNewDespatch);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNewReceiptsDespatchs";
            this.ShowIcon = false;
            this.Text = "Prijemnice/Otpremnice";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewReceiptDespatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVNewReceiptDespatch;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDocumentType;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.Label blbDocumentStatus;
        private System.Windows.Forms.ComboBox cmbDocumentStatus;
        private System.Windows.Forms.Label lblDateOfCreationFrom;
        private System.Windows.Forms.DateTimePicker dtCreatedDateFrom;
        private System.Windows.Forms.Button btnNewDespatch;
        private System.Windows.Forms.Button btnNewReceipt;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private System.Windows.Forms.BindingSource documentTypeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkDocumentNo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Client;
        private System.Windows.Forms.DataGridViewComboBoxColumn documentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn statusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentEndDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn warehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payed;
        private System.Windows.Forms.DateTimePicker dtCreatedDateTo;
        private System.Windows.Forms.Label lblDateOfCreationTo;
    }
}