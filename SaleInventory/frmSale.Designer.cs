namespace SaleInventory
{
    partial class frmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCusID = new System.Windows.Forms.TextBox();
            this.lswSale = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSale = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cboCus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.cboCatPro = new System.Windows.Forms.ComboBox();
            this.cboProName = new System.Windows.Forms.ComboBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnNewCus = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "លេខវិកាយប័ត្រ";
            // 
            // txtSaleID
            // 
            this.txtSaleID.Enabled = false;
            this.txtSaleID.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtSaleID.Location = new System.Drawing.Point(175, 36);
            this.txtSaleID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(160, 36);
            this.txtSaleID.TabIndex = 1;
            this.txtSaleID.Tag = "*";
            this.txtSaleID.Text = "លេខអូតូ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "លេខសំគាល់អតិថិជន";
            // 
            // txtCusID
            // 
            this.txtCusID.Enabled = false;
            this.txtCusID.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusID.ForeColor = System.Drawing.Color.Silver;
            this.txtCusID.Location = new System.Drawing.Point(175, 116);
            this.txtCusID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.Size = new System.Drawing.Size(160, 36);
            this.txtCusID.TabIndex = 0;
            this.txtCusID.Tag = "*";
            this.txtCusID.Text = "លេខអូតូ";
            // 
            // lswSale
            // 
            this.lswSale.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lswSale.FullRowSelect = true;
            this.lswSale.HideSelection = false;
            this.lswSale.Location = new System.Drawing.Point(16, 309);
            this.lswSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lswSale.Name = "lswSale";
            this.lswSale.Size = new System.Drawing.Size(687, 232);
            this.lswSale.TabIndex = 9;
            this.lswSale.Tag = "*";
            this.lswSale.UseCompatibleStateImageBehavior = false;
            this.lswSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "ឈ្មោអតិថិជន";
            // 
            // dtpSale
            // 
            this.dtpSale.CustomFormat = "dd/MM/yyyy";
            this.dtpSale.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSale.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSale.Location = new System.Drawing.Point(175, 76);
            this.dtpSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpSale.Name = "dtpSale";
            this.dtpSale.Size = new System.Drawing.Size(160, 36);
            this.dtpSale.TabIndex = 0;
            this.dtpSale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 27);
            this.label10.TabIndex = 11;
            this.label10.Text = "កាលបរិច្ឆេលក់";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "ទំនាក់ទំនង";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(436, 37);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(160, 113);
            this.txtContact.TabIndex = 2;
            this.txtContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // cboCus
            // 
            this.cboCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCus.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCus.FormattingEnabled = true;
            this.cboCus.Location = new System.Drawing.Point(175, 156);
            this.cboCus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCus.Name = "cboCus";
            this.cboCus.Size = new System.Drawing.Size(160, 35);
            this.cboCus.TabIndex = 1;
            this.cboCus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(685, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "ព័ត៏មានលំអិត";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProID
            // 
            this.txtProID.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProID.Location = new System.Drawing.Point(133, 267);
            this.txtProID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProID.Multiline = true;
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(110, 36);
            this.txtProID.TabIndex = 0;
            this.txtProID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // cboCatPro
            // 
            this.cboCatPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatPro.Enabled = false;
            this.cboCatPro.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCatPro.FormattingEnabled = true;
            this.cboCatPro.Location = new System.Drawing.Point(250, 267);
            this.cboCatPro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCatPro.Name = "cboCatPro";
            this.cboCatPro.Size = new System.Drawing.Size(106, 35);
            this.cboCatPro.TabIndex = 13;
            this.cboCatPro.Tag = "*";
            this.cboCatPro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // cboProName
            // 
            this.cboProName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProName.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProName.FormattingEnabled = true;
            this.cboProName.Location = new System.Drawing.Point(16, 267);
            this.cboProName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboProName.Name = "cboProName";
            this.cboProName.Size = new System.Drawing.Size(110, 35);
            this.cboProName.TabIndex = 3;
            this.cboProName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(480, 267);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(110, 36);
            this.txtQty.TabIndex = 4;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(363, 267);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(110, 36);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.DarkGray;
            this.lblTotal.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(544, 507);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 27);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "សរុប";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotal.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(599, 505);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(104, 36);
            this.txtTotal.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "ប្រភេទទំនិញ";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(127, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "លេខកូដទំនិញ";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "ឈ្មោះទំនិញ";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(487, 226);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "បរិមាណ";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(366, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 27);
            this.label13.TabIndex = 0;
            this.label13.Text = "តំលៃរាយ";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::SaleInventory.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(607, 224);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 37);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "លុប";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAddItem.FlatAppearance.BorderSize = 2;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddItem.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Image = global::SaleInventory.Properties.Resources.add;
            this.btnAddItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItem.Location = new System.Drawing.Point(607, 264);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(92, 37);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // btnNewCus
            // 
            this.btnNewCus.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnNewCus.FlatAppearance.BorderSize = 2;
            this.btnNewCus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewCus.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCus.Image = global::SaleInventory.Properties.Resources.newperson;
            this.btnNewCus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewCus.Location = new System.Drawing.Point(437, 156);
            this.btnNewCus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewCus.Name = "btnNewCus";
            this.btnNewCus.Size = new System.Drawing.Size(159, 35);
            this.btnNewCus.TabIndex = 7;
            this.btnNewCus.Text = "អតិថិជនថ្មី";
            this.btnNewCus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewCus.UseVisualStyleBackColor = true;
            this.btnNewCus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SaleInventory.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(611, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Image = global::SaleInventory.Properties.Resources._new;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(602, 37);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 37);
            this.btnNew.TabIndex = 6;
            this.btnNew.Tag = "*";
            this.btnNew.Text = "បន្ថែម";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            // 
            // panelControl1
            // 
            this.panelControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 547);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(718, 49);
            this.panelControl1.TabIndex = 19;
            this.panelControl1.Tag = "*";
            // 
            // panelBar1
            // 
            this.panelBar1.BackColor = System.Drawing.Color.Gray;
            this.panelBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar1.Location = new System.Drawing.Point(0, 0);
            this.panelBar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelBar1.Name = "panelBar1";
            this.panelBar1.Size = new System.Drawing.Size(718, 27);
            this.panelBar1.TabIndex = 21;
            this.panelBar1.Tag = "*";
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(718, 596);
            this.Controls.Add(this.panelBar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cboProName);
            this.Controls.Add(this.cboCatPro);
            this.Controls.Add(this.cboCus);
            this.Controls.Add(this.dtpSale);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lswSale);
            this.Controls.Add(this.btnNewCus);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCusID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtSaleID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                                 " +
    "                       លក់ទំនិញ";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSale_KeyDown);
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCusID;
        private System.Windows.Forms.ListView lswSale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewCus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSale;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.ComboBox cboCus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.ComboBox cboCatPro;
        private System.Windows.Forms.ComboBox cboProName;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddItem;
        private Components.PanelControl panelControl1;
        private panelBar panelBar1;
    }
}