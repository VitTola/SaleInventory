namespace SaleInventory
{
    partial class frmRptSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptSale));
            this.VSale = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // VSale
            // 
            this.VSale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSale.LocalReport.ReportEmbeddedResource = "SaleInventory.rptSale.rdlc";
            this.VSale.Location = new System.Drawing.Point(0, 0);
            this.VSale.Name = "VSale";
            this.VSale.ServerReport.BearerToken = null;
            this.VSale.Size = new System.Drawing.Size(1035, 749);
            this.VSale.TabIndex = 0;
            // 
            // frmRptSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 749);
            this.Controls.Add(this.VSale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmRptSale_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer VSale;
    }
}