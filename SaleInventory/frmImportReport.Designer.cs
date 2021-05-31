namespace SaleInventory
{
    partial class frmImportReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportReport));
            this.label3 = new System.Windows.Forms.Label();
            this.lswImpReport = new System.Windows.Forms.ListView();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStop = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSup = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panelBar1 = new SaleInventory.panelBar();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "ឈ្មោះបុក្គលិក";
            // 
            // lswImpReport
            // 
            this.lswImpReport.FullRowSelect = true;
            this.lswImpReport.HideSelection = false;
            this.lswImpReport.Location = new System.Drawing.Point(12, 161);
            this.lswImpReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lswImpReport.Name = "lswImpReport";
            this.lswImpReport.Size = new System.Drawing.Size(602, 393);
            this.lswImpReport.TabIndex = 3;
            this.lswImpReport.Tag = "*";
            this.lswImpReport.UseCompatibleStateImageBehavior = false;
            this.lswImpReport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImportReport_KeyDown);
            // 
            // cboEmp
            // 
            this.cboEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmp.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Location = new System.Drawing.Point(115, 36);
            this.cboEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(160, 35);
            this.cboEmp.TabIndex = 1;
            this.cboEmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImportReport_KeyDown);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(115, 75);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(160, 36);
            this.dtpStart.TabIndex = 3;
            this.dtpStart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImportReport_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ចាប់ពីថ្ងៃទី";
            // 
            // dtpStop
            // 
            this.dtpStop.CustomFormat = "dd/MM/yyyy";
            this.dtpStop.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStop.Location = new System.Drawing.Point(454, 75);
            this.dtpStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(160, 36);
            this.dtpStop.TabIndex = 4;
            this.dtpStop.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImportReport_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "ដល់ថ្ងៃទី";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "ប្រភពផ្គត់ផ្គង់";
            // 
            // cboSup
            // 
            this.cboSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSup.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSup.FormattingEnabled = true;
            this.cboSup.Location = new System.Drawing.Point(454, 36);
            this.cboSup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSup.Name = "cboSup";
            this.cboSup.Size = new System.Drawing.Size(160, 35);
            this.cboSup.TabIndex = 2;
            this.cboSup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImportReport_KeyDown);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPreview.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnPreview.FlatAppearance.BorderSize = 2;
            this.btnPreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPreview.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Image = global::SaleInventory.Properties.Resources.report;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(454, 116);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(160, 37);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "របាយការណ៍";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImportReport_KeyDown);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnShow.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnShow.FlatAppearance.BorderSize = 2;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Image = global::SaleInventory.Properties.Resources.search;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(110, 116);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(92, 37);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "មើល";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImportReport_KeyDown);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::SaleInventory.Properties.Resources._new;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(12, 116);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 37);
            this.btnNew.TabIndex = 0;
            this.btnNew.Tag = "*";
            this.btnNew.Text = "បន្ថែម";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImportReport_KeyDown);
            // 
            // panelBar1
            // 
            this.panelBar1.BackColor = System.Drawing.Color.Gray;
            this.panelBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar1.Location = new System.Drawing.Point(0, 0);
            this.panelBar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelBar1.Name = "panelBar1";
            this.panelBar1.Size = new System.Drawing.Size(625, 27);
            this.panelBar1.TabIndex = 9;
            this.panelBar1.Tag = "*";
            // 
            // frmImportReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(625, 566);
            this.Controls.Add(this.panelBar1);
            this.Controls.Add(this.cboSup);
            this.Controls.Add(this.cboEmp);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lswImpReport);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmImportReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                               រប" +
    "ាយការណ៍ការនាំចូល";
            this.Load += new System.EventHandler(this.frmImportReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImportReport_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lswImpReport;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSup;
        private panelBar panelBar1;
    }
}