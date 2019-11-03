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
            this.DGVReceiptsDespatchs = new System.Windows.Forms.DataGridView();
            this.SelectedRow = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DGVReceiptsDespatchs)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVReceiptsDespatchs
            // 
            this.DGVReceiptsDespatchs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVReceiptsDespatchs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGVReceiptsDespatchs.Location = new System.Drawing.Point(0, 109);
            this.DGVReceiptsDespatchs.Name = "DGVReceiptsDespatchs";
            this.DGVReceiptsDespatchs.Size = new System.Drawing.Size(800, 341);
            this.DGVReceiptsDespatchs.TabIndex = 0;
            // 
            // SelectedRow
            // 
            this.SelectedRow.Name = "SelectedRow";
            this.SelectedRow.Size = new System.Drawing.Size(181, 26);
            // 
            // frmReceiptsDespatchs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGVReceiptsDespatchs);
            this.Name = "frmReceiptsDespatchs";
            this.Text = "Prijemnice/Otpremnice";
            ((System.ComponentModel.ISupportInitialize)(this.DGVReceiptsDespatchs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVReceiptsDespatchs;
        private System.Windows.Forms.ContextMenuStrip SelectedRow;
    }
}