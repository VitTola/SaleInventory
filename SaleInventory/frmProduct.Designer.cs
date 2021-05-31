namespace SaleInventory
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboCatSup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImpPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstPro = new System.Windows.Forms.ListBox();
            this.panelControl1 = new SaleInventory.Components.PanelControl();
            this.panelBar1 = new SaleInventory.panelBar();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "លេខកូដទំនិញ";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtID.Location = new System.Drawing.Point(116, 38);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(160, 36);
            this.txtID.TabIndex = 1;
            this.txtID.Tag = "*";
            this.txtID.Text = "លេខអូតូ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "ឈ្មោះទំនិញ";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(282, 38);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 36);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Tag = "*";
            this.txtSearch.Text = "ស្វែងរកទំនិញ.....";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPro_KeyDown);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::SaleInventory.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(448, 38);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 37);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "កែប្រែ";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPro_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SaleInventory.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(448, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPro_KeyDown);
            // 
            // cboCatSup
            // 
            this.cboCatSup.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCatSup.FormattingEnabled = true;
            this.cboCatSup.Location = new System.Drawing.Point(116, 233);
            this.cboCatSup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCatSup.Name = "cboCatSup";
            this.cboCatSup.Size = new System.Drawing.Size(160, 35);
            this.cboCatSup.TabIndex = 4;
            this.cboCatSup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPro_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "បរិមាណទំនិញ";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(116, 116);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(160, 36);
            this.txtQty.TabIndex = 1;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPro_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "តម្លៃលក់ចេញ";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(116, 194);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(160, 36);
            this.txtSalePrice.TabIndex = 2;
            this.txtSalePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPro_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "តម្លៃនាំចូល";
            // 
            // txtImpPrice
            // 
            this.txtImpPrice.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpPrice.Location = new System.Drawing.Point(116, 155);
            this.txtImpPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImpPrice.Name = "txtImpPrice";
            this.txtImpPrice.Size = new System.Drawing.Size(160, 36);
            this.txtImpPrice.TabIndex = 3;
            this.txtImpPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPro_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "ប្រភេទទំនិញ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(116, 77);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 36);
            this.txtName.TabIndex = 0;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPro_KeyDown);
            // 
            // lstPro
            // 
            this.lstPro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lstPro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPro.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPro.FormattingEnabled = true;
            this.lstPro.ItemHeight = 27;
            this.lstPro.Location = new System.Drawing.Point(283, 80);
            this.lstPro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstPro.Name = "lstPro";
            this.lstPro.Size = new System.Drawing.Size(257, 189);
            this.lstPro.TabIndex = 9;
            this.lstPro.Tag = "*";
            this.lstPro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPro_KeyDown);
            // 
            // panelControl1
            // 
            this.panelControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 275);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(554, 49);
            this.panelControl1.TabIndex = 11;
            this.panelControl1.Tag = "*";
            // 
            // panelBar1
            // 
            this.panelBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar1.Location = new System.Drawing.Point(0, 0);
            this.panelBar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelBar1.Name = "panelBar1";
            this.panelBar1.Size = new System.Drawing.Size(554, 27);
            this.panelBar1.TabIndex = 13;
            this.panelBar1.Tag = "*";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(554, 324);
            this.Controls.Add(this.panelBar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.lstPro);
            this.Controls.Add(this.cboCatSup);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtImpPrice);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                ទ" +
    "ំនិញ";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPro_KeyDown);
            this.panelControl1.ResumeLayout(false);
            //this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cboCatSup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImpPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstPro;
        private Components.PanelControl panelControl1;
        private panelBar panelBar1;
    }
}