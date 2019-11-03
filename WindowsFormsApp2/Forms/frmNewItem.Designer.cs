namespace MagacinskoRobnoMaterijalno.Forms
{
    partial class frmNewItem
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
            this.SuspendLayout();
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(73, 40);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(100, 20);
            this.tbSifra.TabIndex = 0;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(237, 36);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(100, 20);
            this.tbNaziv.TabIndex = 1;
            // 
            // lblSirfa
            // 
            this.lblSirfa.AutoSize = true;
            this.lblSirfa.Location = new System.Drawing.Point(28, 43);
            this.lblSirfa.Name = "lblSirfa";
            this.lblSirfa.Size = new System.Drawing.Size(28, 13);
            this.lblSirfa.TabIndex = 5;
            this.lblSirfa.Text = "Sifra";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(188, 39);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 6;
            this.lblNaziv.Text = "Naziv";
            // 
            // btnAddArticle
            // 
            this.btnAddArticle.Location = new System.Drawing.Point(195, 74);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(142, 30);
            this.btnAddArticle.TabIndex = 10;
            this.btnAddArticle.Text = "Dodaj artikal";
            this.btnAddArticle.UseVisualStyleBackColor = true;
            this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
            // 
            // frmNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 116);
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
    }
}