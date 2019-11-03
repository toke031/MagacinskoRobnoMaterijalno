namespace MagacinskoRobnoMaterijalno.Forms
{
    partial class frmNewClient
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMB = new System.Windows.Forms.TextBox();
            this.tbPIB = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbBankAccount = new System.Windows.Forms.TextBox();
            this.tbPhoneFax = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPIB = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBankAccount = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPhoneFax = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(78, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbMB
            // 
            this.tbMB.Location = new System.Drawing.Point(78, 51);
            this.tbMB.Name = "tbMB";
            this.tbMB.Size = new System.Drawing.Size(100, 20);
            this.tbMB.TabIndex = 2;
            // 
            // tbPIB
            // 
            this.tbPIB.Location = new System.Drawing.Point(278, 12);
            this.tbPIB.Name = "tbPIB";
            this.tbPIB.Size = new System.Drawing.Size(100, 20);
            this.tbPIB.TabIndex = 3;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(278, 51);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 4;
            // 
            // tbBankAccount
            // 
            this.tbBankAccount.Location = new System.Drawing.Point(78, 92);
            this.tbBankAccount.Name = "tbBankAccount";
            this.tbBankAccount.Size = new System.Drawing.Size(300, 20);
            this.tbBankAccount.TabIndex = 5;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(78, 130);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(300, 20);
            this.tbEmail.TabIndex = 6;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(78, 166);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(100, 20);
            this.tbPhone.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(2, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 13);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Naziv klijenta";
            // 
            // lblPIB
            // 
            this.lblPIB.AutoSize = true;
            this.lblPIB.Location = new System.Drawing.Point(196, 15);
            this.lblPIB.Name = "lblPIB";
            this.lblPIB.Size = new System.Drawing.Size(24, 13);
            this.lblPIB.TabIndex = 12;
            this.lblPIB.Text = "PIB";
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(2, 54);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(23, 13);
            this.lblMB.TabIndex = 13;
            this.lblMB.Text = "MB";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(196, 54);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 13);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Adresa klijenta";
            // 
            // lblBankAccount
            // 
            this.lblBankAccount.AutoSize = true;
            this.lblBankAccount.Location = new System.Drawing.Point(2, 95);
            this.lblBankAccount.Name = "lblBankAccount";
            this.lblBankAccount.Size = new System.Drawing.Size(61, 13);
            this.lblBankAccount.TabIndex = 15;
            this.lblBankAccount.Text = "Broj računa";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(2, 133);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(2, 169);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Telefon";
            // 
            // tbPhoneFax
            // 
            this.tbPhoneFax.Location = new System.Drawing.Point(278, 166);
            this.tbPhoneFax.Name = "tbPhoneFax";
            this.tbPhoneFax.Size = new System.Drawing.Size(100, 20);
            this.tbPhoneFax.TabIndex = 18;
            // 
            // lblPhoneFax
            // 
            this.lblPhoneFax.AutoSize = true;
            this.lblPhoneFax.Location = new System.Drawing.Point(196, 169);
            this.lblPhoneFax.Name = "lblPhoneFax";
            this.lblPhoneFax.Size = new System.Drawing.Size(24, 13);
            this.lblPhoneFax.TabIndex = 19;
            this.lblPhoneFax.Text = "Fax";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(278, 202);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(100, 34);
            this.btnAddClient.TabIndex = 20;
            this.btnAddClient.Text = "Dodaj klijenta";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 248);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.lblPhoneFax);
            this.Controls.Add(this.tbPhoneFax);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBankAccount);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblMB);
            this.Controls.Add(this.lblPIB);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbBankAccount);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPIB);
            this.Controls.Add(this.tbMB);
            this.Controls.Add(this.tbName);
            this.Name = "frmNewClient";
            this.Text = "Dodavanje novog klijenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbMB;
        private System.Windows.Forms.TextBox tbPIB;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbBankAccount;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPIB;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBankAccount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbPhoneFax;
        private System.Windows.Forms.Label lblPhoneFax;
        private System.Windows.Forms.Button btnAddClient;
    }
}