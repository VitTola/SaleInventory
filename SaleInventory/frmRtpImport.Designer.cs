namespace SaleInventory
{
    partial class frmRtpImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRtpImport));
            this.VImp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // VImp
            // 
            this.VImp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VImp.LocalReport.ReportEmbeddedResource = "SaleInventory.rptImport.rdlc";
            this.VImp.Location = new System.Drawing.Point(0, 0);
            this.VImp.Name = "VImp";
            this.VImp.ServerReport.BearerToken = null;
            this.VImp.Size = new System.Drawing.Size(1091, 749);
            this.VImp.TabIndex = 0;
            // 
            // frmRtpImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 749);
            this.Controls.Add(this.VImp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRtpImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmRtpImport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer VImp;
    }
}