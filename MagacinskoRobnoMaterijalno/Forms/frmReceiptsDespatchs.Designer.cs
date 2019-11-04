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
            this.DGVReceiptsDespatchsItems = new System.Windows.Forms.DataGridView();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVReceiptsDespatchsItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVReceiptsDespatchsItems
            // 
            this.DGVReceiptsDespatchsItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReceiptsDespatchsItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVReceiptsDespatchsItems.Location = new System.Drawing.Point(3, 16);
            this.DGVReceiptsDespatchsItems.Name = "DGVReceiptsDespatchsItems";
            this.DGVReceiptsDespatchsItems.Size = new System.Drawing.Size(770, 277);
            this.DGVReceiptsDespatchsItems.TabIndex = 0;
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
            this.groupBox2.Size = new System.Drawing.Size(598, 121);
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
            this.groupBox3.Location = new System.Drawing.Point(12, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 296);
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
            this.btnSave.Location = new System.Drawing.Point(710, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Sacuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbTotalWithVAT
            // 
            this.tbTotalWithVAT.Location = new System.Drawing.Point(685, 456);
            this.tbTotalWithVAT.Name = "tbTotalWithVAT";
            this.tbTotalWithVAT.Size = new System.Drawing.Size(100, 20);
            this.tbTotalWithVAT.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ukupno sa PDV-om:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "PDV:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(579, 456);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Osnovica:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 456);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 46;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(629, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "Odustani";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmReceiptsDespatchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotalWithVAT);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReceiptsDespatchs";
            this.Text = "Prijemnice/Otpremnice";
            ((System.ComponentModel.ISupportInitialize)(this.DGVReceiptsDespatchsItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCancel;
    }
}