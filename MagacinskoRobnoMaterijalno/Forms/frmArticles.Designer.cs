using System.Windows.Forms;

namespace MagacinskoRobnoMaterijalno.Forms
{
    partial class FrmArticles
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityItemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbSearchItemNo = new System.Windows.Forms.TextBox();
            this.lblSearchItemNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SelectedRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVArticles
            // 
            this.DGVArticles.AutoGenerateColumns = false;
            this.DGVArticles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.articleNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.quantityItemPriceDataGridViewTextBoxColumn,
            this.articleTypeIDDataGridViewTextBoxColumn});
            this.DGVArticles.DataSource = this.articleBindingSource;
            this.DGVArticles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVArticles.GridColor = System.Drawing.SystemColors.Control;
            this.DGVArticles.Location = new System.Drawing.Point(3, 16);
            this.DGVArticles.MultiSelect = false;
            this.DGVArticles.Name = "DGVArticles";
            this.DGVArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVArticles.Size = new System.Drawing.Size(472, 445);
            this.DGVArticles.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // articleNoDataGridViewTextBoxColumn
            // 
            this.articleNoDataGridViewTextBoxColumn.DataPropertyName = "ArticleNo";
            this.articleNoDataGridViewTextBoxColumn.HeaderText = "Sifra artikla";
            this.articleNoDataGridViewTextBoxColumn.Name = "articleNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Naziv artikla";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // quantityItemPriceDataGridViewTextBoxColumn
            // 
            this.quantityItemPriceDataGridViewTextBoxColumn.DataPropertyName = "QuantityItemPrice";
            this.quantityItemPriceDataGridViewTextBoxColumn.HeaderText = "Cena";
            this.quantityItemPriceDataGridViewTextBoxColumn.Name = "quantityItemPriceDataGridViewTextBoxColumn";
            // 
            // articleTypeIDDataGridViewTextBoxColumn
            // 
            this.articleTypeIDDataGridViewTextBoxColumn.DataPropertyName = "ArticleTypeID";
            this.articleTypeIDDataGridViewTextBoxColumn.HeaderText = "ArticleTypeID";
            this.articleTypeIDDataGridViewTextBoxColumn.Name = "articleTypeIDDataGridViewTextBoxColumn";
            this.articleTypeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataSource = typeof(MagacinskoRobnoMaterijalno.Models.Article);
            // 
            // tbSearchItemNo
            // 
            this.tbSearchItemNo.Location = new System.Drawing.Point(96, 40);
            this.tbSearchItemNo.Name = "tbSearchItemNo";
            this.tbSearchItemNo.Size = new System.Drawing.Size(100, 20);
            this.tbSearchItemNo.TabIndex = 1;
            // 
            // lblSearchItemNo
            // 
            this.lblSearchItemNo.AutoSize = true;
            this.lblSearchItemNo.Location = new System.Drawing.Point(23, 43);
            this.lblSearchItemNo.Name = "lblSearchItemNo";
            this.lblSearchItemNo.Size = new System.Drawing.Size(59, 13);
            this.lblSearchItemNo.TabIndex = 2;
            this.lblSearchItemNo.Text = "Šifra artikla";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(352, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Pretraži";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // SelectedRow
            // 
            this.SelectedRow.Name = "SelectedRow";
            this.SelectedRow.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGVArticles);
            this.groupBox1.Location = new System.Drawing.Point(0, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 464);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artikli";
            // 
            // frmArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSearchItemNo);
            this.Controls.Add(this.tbSearchItemNo);
            this.Name = "frmArticles";
            this.Text = "Artikli";
            ((System.ComponentModel.ISupportInitialize)(this.DGVArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVArticles;
        private System.Windows.Forms.TextBox tbSearchItemNo;
        private System.Windows.Forms.Label lblSearchItemNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ContextMenuStrip SelectedRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityItemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentItemsDataGridViewTextBoxColumn;

        public FrmArticles(DataGridViewTextBoxColumn documentItemsDataGridViewTextBoxColumn)
        {
            this.documentItemsDataGridViewTextBoxColumn = documentItemsDataGridViewTextBoxColumn;
        }

        private System.Windows.Forms.BindingSource articleBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}