namespace MagacinskoRobnoMaterijalno.Forms
{
    partial class frmReceiptsDespatchs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVReceiptsDespatchsItems = new System.Windows.Forms.DataGridView();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SelectedRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblPhoneFax = new System.Windows.Forms.Label();
            this.tbPhoneFax = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPIB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbBankAccount = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPIB = new System.Windows.Forms.TextBox();
            this.tbMB = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblMB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbWarehouse = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbTotalWithVAT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDocumentNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEndDateForPayment = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.Rb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleNoUnbound = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticleNo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityItemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteDocumentItem = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReceiptsDespatchsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentItemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVReceiptsDespatchsItems
            // 
            this.DGVReceiptsDespatchsItems.AutoGenerateColumns = false;
            this.DGVReceiptsDespatchsItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReceiptsDespatchsItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rb,
            this.ArticleNoUnbound,
            this.iDDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.documentDataGridViewTextBoxColumn,
            this.ArticleNo,
            this.quantityDataGridViewTextBoxColumn,
            this.quantityItemPriceDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.DeleteDocumentItem});
            this.DGVReceiptsDespatchsItems.DataSource = this.documentItemBindingSource;
            this.DGVReceiptsDespatchsItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVReceiptsDespatchsItems.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGVReceiptsDespatchsItems.Location = new System.Drawing.Point(3, 16);
            this.DGVReceiptsDespatchsItems.Name = "DGVReceiptsDespatchsItems";
            this.DGVReceiptsDespatchsItems.Size = new System.Drawing.Size(776, 260);
            this.DGVReceiptsDespatchsItems.TabIndex = 0;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(MagacinskoRobnoMaterijalno.Models.Article);
            // 
            // documentItemBindingSource
            // 
            this.documentItemBindingSource.DataSource = typeof(MagacinskoRobnoMaterijalno.Models.DocumentItem);
            // 
            // SelectedRow
            // 
            this.SelectedRow.Name = "SelectedRow";
            this.SelectedRow.Size = new System.Drawing.Size(61, 4);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(6, 19);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(127, 21);
            this.cmbStatus.TabIndex = 1;
            // 
            // lblPhoneFax
            // 
            this.lblPhoneFax.AutoSize = true;
            this.lblPhoneFax.Location = new System.Drawing.Point(200, 94);
            this.lblPhoneFax.Name = "lblPhoneFax";
            this.lblPhoneFax.Size = new System.Drawing.Size(24, 13);
            this.lblPhoneFax.TabIndex = 34;
            this.lblPhoneFax.Text = "Fax";
            // 
            // tbPhoneFax
            // 
            this.tbPhoneFax.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPhoneFax.Location = new System.Drawing.Point(230, 91);
            this.tbPhoneFax.Name = "tbPhoneFax";
            this.tbPhoneFax.ReadOnly = true;
            this.tbPhoneFax.Size = new System.Drawing.Size(100, 20);
            this.tbPhoneFax.TabIndex = 33;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 94);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 32;
            this.lblPhone.Text = "Telefon";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Email";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Location = new System.Drawing.Point(331, 42);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(61, 13);
            this.lblBankAccount.TabIndex = 30;
            this.lblBankAccount.Text = "Broj računa";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(225, 16);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 13);
            this.lblAddress.TabIndex = 29;
            this.lblAddress.Text = "Adresa klijenta";
            // 
            // lblPIB
            // 
            this.lblPIB.AutoSize = true;
            this.lblPIB.Location = new System.Drawing.Point(195, 42);
            this.lblPIB.Name = "lblPIB";
            this.lblPIB.Size = new System.Drawing.Size(24, 13);
            this.lblPIB.TabIndex = 28;
            this.lblPIB.Text = "PIB";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 13);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Naziv klijenta";
            // 
            // tbPhone
            // 
            this.tbPhone.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPhone.Location = new System.Drawing.Point(82, 91);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.ReadOnly = true;
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 26;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbEmail.Location = new System.Drawing.Point(82, 65);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(300, 20);
            this.tbEmail.TabIndex = 25;
            // 
            // tbBankAccount
            // 
            this.tbBankAccount.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbBankAccount.Location = new System.Drawing.Point(407, 39);
            this.tbBankAccount.Name = "tbBankAccount";
            this.tbBankAccount.ReadOnly = true;
            this.tbBankAccount.Size = new System.Drawing.Size(182, 20);
            this.tbBankAccount.TabIndex = 24;
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbAddress.Location = new System.Drawing.Point(307, 13);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ReadOnly = true;
            this.tbAddress.Size = new System.Drawing.Size(282, 20);
            this.tbAddress.TabIndex = 23;
            // 
            // tbPIB
            // 
            this.tbPIB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbPIB.Location = new System.Drawing.Point(225, 39);
            this.tbPIB.Name = "tbPIB";
            this.tbPIB.ReadOnly = true;
            this.tbPIB.Size = new System.Drawing.Size(100, 20);
            this.tbPIB.TabIndex = 22;
            // 
            // tbMB
            // 
            this.tbMB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbMB.Location = new System.Drawing.Point(82, 39);
            this.tbMB.Name = "tbMB";
            this.tbMB.ReadOnly = true;
            this.tbMB.Size = new System.Drawing.Size(100, 20);
            this.tbMB.TabIndex = 21;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbName.Location = new System.Drawing.Point(82, 13);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(137, 20);
            this.tbName.TabIndex = 20;
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(6, 42);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(23, 13);
            this.lblMB.TabIndex = 35;
            this.lblMB.Text = "MB";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 55);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status dokumenta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblName);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.lblMB);
            this.groupBox2.Controls.Add(this.tbMB);
            this.groupBox2.Controls.Add(this.lblPhoneFax);
            this.groupBox2.Controls.Add(this.tbPIB);
            this.groupBox2.Controls.Add(this.tbPhoneFax);
            this.groupBox2.Controls.Add(this.tbAddress);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.tbBankAccount);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.lblBankAccount);
            this.groupBox2.Controls.Add(this.tbPhone);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.lblPIB);
            this.groupBox2.Location = new System.Drawing.Point(190, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 116);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klijent";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Izbor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DGVReceiptsDespatchsItems);
            this.groupBox3.Location = new System.Drawing.Point(12, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(782, 279);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stavke";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbWarehouse);
            this.groupBox4.Location = new System.Drawing.Point(12, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 55);
            this.groupBox4.TabIndex = 39;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Magacin";
            // 
            // cmbWarehouse
            // 
            this.cmbWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWarehouse.FormattingEnabled = true;
            this.cmbWarehouse.Location = new System.Drawing.Point(6, 19);
            this.cmbWarehouse.Name = "cmbWarehouse";
            this.cmbWarehouse.Size = new System.Drawing.Size(160, 21);
            this.cmbWarehouse.TabIndex = 1;
            this.cmbWarehouse.SelectedIndexChanged += new System.EventHandler(this.cmbWarehouse_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(716, 534);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbTotalWithVAT
            // 
            this.tbTotalWithVAT.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbTotalWithVAT.Location = new System.Drawing.Point(691, 508);
            this.tbTotalWithVAT.Name = "tbTotalWithVAT";
            this.tbTotalWithVAT.Size = new System.Drawing.Size(100, 20);
            this.tbTotalWithVAT.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(688, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ukupno sa PDV-om:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "PDV:";
            // 
            // tbVat
            // 
            this.tbVat.Location = new System.Drawing.Point(585, 508);
            this.tbVat.Name = "tbVat";
            this.tbVat.Size = new System.Drawing.Size(100, 20);
            this.tbVat.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Osnovica:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(478, 508);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 46;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(635, 534);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Location = new System.Drawing.Point(6, 37);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(160, 21);
            this.cmbDocumentType.TabIndex = 1;
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.CustomFormat = "dd.MM.yyyy";
            this.dtpCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCreationDate.Location = new System.Drawing.Point(178, 38);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpCreationDate.Size = new System.Drawing.Size(108, 20);
            this.dtpCreationDate.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Datum kreiranja";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.tbDocumentNo);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.dtpEndDateForPayment);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.cmbDocumentType);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.dtpPaymentDate);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.dtpCreationDate);
            this.groupBox6.Location = new System.Drawing.Point(12, 134);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(782, 67);
            this.groupBox6.TabIndex = 52;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Detalji dokumenta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(529, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Broj dokumenta";
            // 
            // tbDocumentNo
            // 
            this.tbDocumentNo.Location = new System.Drawing.Point(532, 38);
            this.tbDocumentNo.Name = "tbDocumentNo";
            this.tbDocumentNo.Size = new System.Drawing.Size(100, 20);
            this.tbDocumentNo.TabIndex = 57;
            this.tbDocumentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Datum placanja";
            // 
            // dtpEndDateForPayment
            // 
            this.dtpEndDateForPayment.CustomFormat = "dd.MM.yyyy";
            this.dtpEndDateForPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDateForPayment.Location = new System.Drawing.Point(292, 38);
            this.dtpEndDateForPayment.Name = "dtpEndDateForPayment";
            this.dtpEndDateForPayment.Size = new System.Drawing.Size(108, 20);
            this.dtpEndDateForPayment.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Tip dokumenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Rok placanja";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "dd.MM.yyyy";
            this.dtpPaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPaymentDate.Location = new System.Drawing.Point(406, 38);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(108, 20);
            this.dtpPaymentDate.TabIndex = 52;
            // 
            // Rb
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.Rb.DefaultCellStyle = dataGridViewCellStyle7;
            this.Rb.HeaderText = "Rb";
            this.Rb.Name = "Rb";
            this.Rb.ReadOnly = true;
            this.Rb.Width = 30;
            // 
            // ArticleNoUnbound
            // 
            this.ArticleNoUnbound.HeaderText = "Sifra";
            this.ArticleNoUnbound.Name = "ArticleNoUnbound";
            this.ArticleNoUnbound.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ArticleNoUnbound.Width = 50;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentDataGridViewTextBoxColumn
            // 
            this.documentDataGridViewTextBoxColumn.DataPropertyName = "Document";
            this.documentDataGridViewTextBoxColumn.HeaderText = "Document";
            this.documentDataGridViewTextBoxColumn.Name = "documentDataGridViewTextBoxColumn";
            this.documentDataGridViewTextBoxColumn.Visible = false;
            // 
            // ArticleNo
            // 
            this.ArticleNo.DataPropertyName = "ArticleNo";
            this.ArticleNo.DataSource = this.articleBindingSource;
            this.ArticleNo.DisplayMember = "Name";
            this.ArticleNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArticleNo.HeaderText = "Artikal / Proizvod";
            this.ArticleNo.Name = "ArticleNo";
            this.ArticleNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ArticleNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ArticleNo.ValueMember = "ArticleNo";
            this.ArticleNo.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 60;
            // 
            // quantityItemPriceDataGridViewTextBoxColumn
            // 
            this.quantityItemPriceDataGridViewTextBoxColumn.DataPropertyName = "QuantityItemPrice";
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.quantityItemPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.quantityItemPriceDataGridViewTextBoxColumn.HeaderText = "Jedinicna cena";
            this.quantityItemPriceDataGridViewTextBoxColumn.Name = "quantityItemPriceDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.widthDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.widthDataGridViewTextBoxColumn.HeaderText = "Sirina cm";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.heightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.heightDataGridViewTextBoxColumn.HeaderText = "Visina cm";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.itemPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // DeleteDocumentItem
            // 
            this.DeleteDocumentItem.HeaderText = "Brisanje";
            this.DeleteDocumentItem.Name = "DeleteDocumentItem";
            this.DeleteDocumentItem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteDocumentItem.Text = "X";
            this.DeleteDocumentItem.UseColumnTextForButtonValue = true;
            this.DeleteDocumentItem.Width = 40;
            // 
            // frmReceiptsDespatchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 572);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotalWithVAT);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReceiptsDespatchs";
            this.Text = "Prijemnice/Otpremnice";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReceiptsDespatchs_FormClosing);
            this.Shown += new System.EventHandler(this.frmReceiptsDespatchs_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReceiptsDespatchsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentItemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVReceiptsDespatchsItems;
        private System.Windows.Forms.ContextMenuStrip SelectedRow;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblPhoneFax;
        private System.Windows.Forms.TextBox tbPhoneFax;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPIB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbBankAccount;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPIB;
        private System.Windows.Forms.TextBox tbMB;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbWarehouse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbTotalWithVAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource documentItemBindingSource;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.DateTimePicker dtpCreationDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEndDateForPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDocumentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticleNoUnbound;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ArticleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityItemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteDocumentItem;
    }
}