namespace SaleInventory
{
    partial class frmEmpList
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpList));
            this.dtEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsEmployee = new SaleInventory.dsEmployee();
            this.VemList = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dtEmployeeBindingSource
            // 
            this.dtEmployeeBindingSource.DataMember = "dtEmployee";
            this.dtEmployeeBindingSource.DataSource = this.dsEmployee;
            // 
            // dsEmployee
            // 
            this.dsEmployee.DataSetName = "dsEmployee";
            this.dsEmployee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VemList
            // 
            this.VemList.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsEmployee";
            reportDataSource1.Value = this.dtEmployeeBindingSource;
            this.VemList.LocalReport.DataSources.Add(reportDataSource1);
            this.VemList.LocalReport.ReportEmbeddedResource = "SaleInventory.rptEmpList.rdlc";
            this.VemList.Location = new System.Drawing.Point(0, 0);
            this.VemList.Name = "VemList";
            this.VemList.ServerReport.BearerToken = null;
            this.VemList.Size = new System.Drawing.Size(1181, 749);
            this.VemList.TabIndex = 0;
            // 
            // frmEmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 749);
            this.Controls.Add(this.VemList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEmpList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEmpList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dtEmployeeBindingSource;
        private dsEmployee dsEmployee;
        public Microsoft.Reporting.WinForms.ReportViewer VemList;
    }
}