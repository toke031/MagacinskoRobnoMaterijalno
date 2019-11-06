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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVNewReceiptDespatch = new System.Windows.Forms.DataGridView();
            this.tbPIB = new System.Windows.Forms.TextBox();
            this.lblPIB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDocumentType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDocumentStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.btnNewDespatch = new System.Windows.Forms.Button();
            this.btnNewReceipt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewReceiptDespatch)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVNewReceiptDespatch);
            this.groupBox1.Location = new System.Drawing.Point(12, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dokumenti";
            // 
            // DGVNewReceiptDespatch
            // 
            this.DGVNewReceiptDespatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVNewReceiptDespatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVNewReceiptDespatch.Location = new System.Drawing.Point(3, 16);
            this.DGVNewReceiptDespatch.Name = "DGVNewReceiptDespatch";
            this.DGVNewReceiptDespatch.Size = new System.Drawing.Size(770, 277);
            this.DGVNewReceiptDespatch.TabIndex = 0;
            // 
            // tbPIB
            // 
            this.tbPIB.Location = new System.Drawing.Point(88, 12);
            this.tbPIB.Name = "tbPIB";
            this.tbPIB.Size = new System.Drawing.Size(93, 20);
            this.tbPIB.TabIndex = 1;
            // 
            // lblPIB
            // 
            this.lblPIB.AutoSize = true;
            this.lblPIB.Location = new System.Drawing.Point(19, 19);
            this.lblPIB.Name = "lblPIB";
            this.lblPIB.Size = new System.Drawing.Size(63, 13);
            this.lblPIB.TabIndex = 2;
            this.lblPIB.Text = "PIB klijenta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmbDocumentType);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbDocumentStatus);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtCreatedDate);
            this.groupBox2.Controls.Add(this.lblPIB);
            this.groupBox2.Controls.Add(this.tbPIB);
            this.groupBox2.Location = new System.Drawing.Point(15, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 116);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tip dokumenta:";
            // 
            // cmbDocumentType
            // 
            this.cmbDocumentType.FormattingEnabled = true;
            this.cmbDocumentType.Location = new System.Drawing.Point(288, 53);
            this.cmbDocumentType.Name = "cmbDocumentType";
            this.cmbDocumentType.Size = new System.Drawing.Size(118, 21);
            this.cmbDocumentType.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status dokumenta:";
            // 
            // cmbDocumentStatus
            // 
            this.cmbDocumentStatus.FormattingEnabled = true;
            this.cmbDocumentStatus.Location = new System.Drawing.Point(288, 12);
            this.cmbDocumentStatus.Name = "cmbDocumentStatus";
            this.cmbDocumentStatus.Size = new System.Drawing.Size(118, 21);
            this.cmbDocumentStatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datum kreiranja:";
            // 
            // dtCreatedDate
            // 
            this.dtCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreatedDate.Location = new System.Drawing.Point(88, 53);
            this.dtCreatedDate.Name = "dtCreatedDate";
            this.dtCreatedDate.Size = new System.Drawing.Size(93, 20);
            this.dtCreatedDate.TabIndex = 3;
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
            // frmNewReceiptsDespatchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.btnNewReceipt);
            this.Controls.Add(this.btnNewDespatch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNewReceiptsDespatchs";
            this.ShowIcon = false;
            this.Text = "Prijemnice/Otpremnice";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVNewReceiptDespatch)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVNewReceiptDespatch;
        private System.Windows.Forms.TextBox tbPIB;
        private System.Windows.Forms.Label lblPIB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDocumentType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDocumentStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtCreatedDate;
        private System.Windows.Forms.Button btnNewDespatch;
        private System.Windows.Forms.Button btnNewReceipt;
    }
}