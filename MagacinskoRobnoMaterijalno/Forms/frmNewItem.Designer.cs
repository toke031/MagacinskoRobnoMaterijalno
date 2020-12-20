namespace MagacinskoRobnoMaterijalno.Forms
{
    partial class FrmNewItem
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
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.lblSirfa = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cmbItemType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(106, 20);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(100, 20);
            this.tbSifra.TabIndex = 0;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(106, 46);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(199, 20);
            this.tbNaziv.TabIndex = 1;
            // 
            // lblSirfa
            // 
            this.lblSirfa.AutoSize = true;
            this.lblSirfa.Location = new System.Drawing.Point(21, 23);
            this.lblSirfa.Name = "lblSirfa";
            this.lblSirfa.Size = new System.Drawing.Size(28, 13);
            this.lblSirfa.TabIndex = 5;
            this.lblSirfa.Text = "Sifra";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(21, 49);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "Naziv";
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(163, 134);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(142, 30);
            this.btnAddArticle.TabIndex = 4;
            this.btnAddArticle.Text = "Dodaj artikal";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.BtnAddArticle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Jedinicna cena";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(106, 72);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 2;
            // 
            // cmbItemType
            // 
            this.cmbItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItemType.FormattingEnabled = true;
            this.cmbItemType.Location = new System.Drawing.Point(106, 98);
            this.cmbItemType.Name = "cmbItemType";
            this.cmbItemType.Size = new System.Drawing.Size(121, 21);
            this.cmbItemType.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tip artikla";
            // 
            // frmNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 176);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbItemType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblSirfa);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbSifra);
            this.Name = "frmNewItem";
            this.Text = "Novi artiakl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label lblSirfa;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.ComboBox cmbItemType;
        private System.Windows.Forms.Label label2;
    }
}