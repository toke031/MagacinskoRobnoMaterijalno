namespace MagacinskoRobnoMaterijalno.Forms
{
    partial class frmMainForm
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
            this.Clients = new System.Windows.Forms.Button();
            this.ReceiptsDespatchs = new System.Windows.Forms.Button();
            this.Articles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clients
            // 
            this.Clients.Location = new System.Drawing.Point(21, 136);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(188, 139);
            this.Clients.TabIndex = 0;
            this.Clients.Text = "Klijenti";
            this.Clients.UseVisualStyleBackColor = true;
            this.Clients.Click += new System.EventHandler(this.Clients_Click);
            // 
            // ReceiptsDespatchs
            // 
            this.ReceiptsDespatchs.Location = new System.Drawing.Point(262, 136);
            this.ReceiptsDespatchs.Name = "ReceiptsDespatchs";
            this.ReceiptsDespatchs.Size = new System.Drawing.Size(207, 139);
            this.ReceiptsDespatchs.TabIndex = 1;
            this.ReceiptsDespatchs.Text = "Prijenmnice/Otoremnice";
            this.ReceiptsDespatchs.UseVisualStyleBackColor = true;
            this.ReceiptsDespatchs.Click += new System.EventHandler(this.ReceiptsDespatchs_Click);
            // 
            // Articles
            // 
            this.Articles.Location = new System.Drawing.Point(531, 136);
            this.Articles.Name = "Articles";
            this.Articles.Size = new System.Drawing.Size(206, 139);
            this.Articles.TabIndex = 2;
            this.Articles.Text = "Artikli";
            this.Articles.UseVisualStyleBackColor = true;
            this.Articles.Click += new System.EventHandler(this.Articles_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Articles);
            this.Controls.Add(this.ReceiptsDespatchs);
            this.Controls.Add(this.Clients);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Glavna forma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button ReceiptsDespatchs;
        private System.Windows.Forms.Button Articles;
    }
}

