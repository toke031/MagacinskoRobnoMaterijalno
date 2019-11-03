namespace MagacinskoRobnoMaterijalno.Forms
{
    partial class Articles
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
            this.DGVArticles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVArticles
            // 
            this.DGVArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArticles.Location = new System.Drawing.Point(1, 1);
            this.DGVArticles.Name = "DGVArticles";
            this.DGVArticles.Size = new System.Drawing.Size(800, 341);
            this.DGVArticles.TabIndex = 0;
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVArticles);
            this.Name = "Articles";
            this.Text = "Artikli";
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVArticles;
    }
}