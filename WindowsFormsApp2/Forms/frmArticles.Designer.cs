namespace MagacinskoRobnoMaterijalno.Forms
{
    partial class frmArticles
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
            this.DGVArticles = new System.Windows.Forms.DataGridView();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SelectedRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVArticles
            // 
            this.DGVArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArticles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVArticles.GridColor = System.Drawing.SystemColors.Control;
            this.DGVArticles.Location = new System.Drawing.Point(0, 91);
            this.DGVArticles.Name = "DGVArticles";
            this.DGVArticles.Size = new System.Drawing.Size(482, 438);
            this.DGVArticles.TabIndex = 0;
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(96, 40);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(100, 20);
            this.tbSearchName.TabIndex = 1;
            // 
            // lblSearchName
            // 
            this.lblSearchName.AutoSize = true;
            this.lblSearchName.Location = new System.Drawing.Point(23, 43);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(65, 13);
            this.lblSearchName.TabIndex = 2;
            this.lblSearchName.Text = "Naziv artikla";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(352, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // SelectedRow
            // 
            this.SelectedRow.Name = "SelectedRow";
            this.SelectedRow.Size = new System.Drawing.Size(181, 26);
            // 
            // frmArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 529);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchName);
            this.Controls.Add(this.tbSearchName);
            this.Controls.Add(this.DGVArticles);
            this.Name = "frmArticles";
            this.Text = "Artikli";
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVArticles;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip SelectedRow;
    }
}