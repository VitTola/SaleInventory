namespace SaleInventory
{
    partial class frmImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImport));
            this.label1 = new System.Windows.Forms.Label();
            this.txtImpID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupID = new System.Windows.Forms.TextBox();
            this.lswImp = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpImp = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.cboSup = new System.Windows.Forms.ComboBox();
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
            this.btnNewSup = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "លេខសំគាល់ការនាំចូល";
            // 
            // txtImpID
            // 
            this.txtImpID.Enabled = false;
            this.txtImpID.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtImpID.Location = new System.Drawing.Point(173, 39);
            this.txtImpID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImpID.Name = "txtImpID";
            this.txtImpID.Size = new System.Drawing.Size(160, 36);
            this.txtImpID.TabIndex = 1;
            this.txtImpID.Tag = "*";
            this.txtImpID.Text = "លេខអូតូ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "លេខសំគាល់ប្រភពផ្គត់់ផ្គង់";
            // 
            // txtSupID
            // 
            this.txtSupID.Enabled = false;
            this.txtSupID.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupID.ForeColor = System.Drawing.Color.Silver;
            this.txtSupID.Location = new System.Drawing.Point(173, 117);
            this.txtSupID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.Size = new System.Drawing.Size(160, 36);
            this.txtSupID.TabIndex = 0;
            this.txtSupID.Tag = "*";
            this.txtSupID.Text = "លេខអូតូ";
            // 
            // lswImp
            // 
            this.lswImp.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lswImp.FullRowSelect = true;
            this.lswImp.HideSelection = false;
            this.lswImp.Location = new System.Drawing.Point(12, 324);
            this.lswImp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lswImp.Name = "lswImp";
            this.lswImp.Size = new System.Drawing.Size(671, 208);
            this.lswImp.TabIndex = 9;
            this.lswImp.Tag = "*";
            this.lswImp.UseCompatibleStateImageBehavior = false;
            this.lswImp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "ឈ្មោះប្រភពផ្គត់ផ្គង់";
            // 
            // dtpImp
            // 
            this.dtpImp.CustomFormat = "dd/MM/yyyy";
            this.dtpImp.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpImp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpImp.Location = new System.Drawing.Point(173, 78);
            this.dtpImp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpImp.Name = "dtpImp";
            this.dtpImp.Size = new System.Drawing.Size(160, 36);
            this.dtpImp.TabIndex = 0;
            this.dtpImp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 27);
            this.label10.TabIndex = 11;
            this.label10.Text = "កាលបរិច្ឆេទនាំចូល";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "ទំនាក់ទំនង";
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(424, 39);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(157, 110);
            this.txtContact.TabIndex = 2;
            this.txtContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // cboSup
            // 
            this.cboSup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSup.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSup.FormattingEnabled = true;
            this.cboSup.Location = new System.Drawing.Point(173, 156);
            this.cboSup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboSup.Name = "cboSup";
            this.cboSup.Size = new System.Drawing.Size(160, 35);
            this.cboSup.TabIndex = 1;
            this.cboSup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(666, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "ព័ត៏មានលំអិត";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProID
            // 
            this.txtProID.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProID.Location = new System.Drawing.Point(129, 281);
            this.txtProID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProID.Multiline = true;
            this.txtProID.Name = "txtProID";
            this.txtProID.ReadOnly = true;
            this.txtProID.Size = new System.Drawing.Size(110, 36);
            this.txtProID.TabIndex = 0;
            this.txtProID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // cboCatPro
            // 
            this.cboCatPro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatPro.Enabled = false;
            this.cboCatPro.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCatPro.FormattingEnabled = true;
            this.cboCatPro.Location = new System.Drawing.Point(244, 281);
            this.cboCatPro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboCatPro.Name = "cboCatPro";
            this.cboCatPro.Size = new System.Drawing.Size(106, 35);
            this.cboCatPro.TabIndex = 13;
            this.cboCatPro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // cboProName
            // 
            this.cboProName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProName.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProName.FormattingEnabled = true;
            this.cboProName.Location = new System.Drawing.Point(13, 281);
            this.cboProName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboProName.Name = "cboProName";
            this.cboProName.Size = new System.Drawing.Size(110, 35);
            this.cboProName.TabIndex = 3;
            this.cboProName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(356, 281);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(110, 36);
            this.txtQty.TabIndex = 4;
            this.txtQty.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(471, 281);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(110, 36);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.Tag = "";
            this.txtPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotal.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(531, 499);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 27);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "សរុប";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotal.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(579, 496);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(104, 36);
            this.txtTotal.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "ប្រភេទទំនិញ";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(133, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "លេខកូដទំនិញ";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 27);
            this.label11.TabIndex = 0;
            this.label11.Text = "ឈ្មោះទំនិញ";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(361, 239);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "បរិមាណ";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(472, 239);
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
            this.btnDelete.Location = new System.Drawing.Point(586, 239);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 37);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "លុប";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
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
            this.btnAddItem.Location = new System.Drawing.Point(587, 279);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(92, 37);
            this.btnAddItem.TabIndex = 15;
            this.btnAddItem.Text = "បញ្ចូល";
            this.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // btnNewSup
            // 
            this.btnNewSup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewSup.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnNewSup.FlatAppearance.BorderSize = 2;
            this.btnNewSup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNewSup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewSup.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSup.Image = global::SaleInventory.Properties.Resources.newperson;
            this.btnNewSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewSup.Location = new System.Drawing.Point(424, 156);
            this.btnNewSup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewSup.Name = "btnNewSup";
            this.btnNewSup.Size = new System.Drawing.Size(156, 37);
            this.btnNewSup.TabIndex = 7;
            this.btnNewSup.Tag = "*";
            this.btnNewSup.Text = "បន្ថែមប្រភពផ្គត់ផ្គង់";
            this.btnNewSup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewSup.UseVisualStyleBackColor = false;
            this.btnNewSup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
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
            this.btnSave.Location = new System.Drawing.Point(591, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "រក្សារទុក";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
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
            this.btnNew.Location = new System.Drawing.Point(586, 39);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 37);
            this.btnNew.TabIndex = 6;
            this.btnNew.Tag = "*";
            this.btnNew.Text = "បន្ថែម";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            // 
            // panelControl1
            // 
            this.panelControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 539);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(697, 49);
            this.panelControl1.TabIndex = 17;
            this.panelControl1.Tag = "*";
            // 
            // panelBar1
            // 
            this.panelBar1.BackColor = System.Drawing.Color.Gray;
            this.panelBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar1.Location = new System.Drawing.Point(0, 0);
            this.panelBar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelBar1.Name = "panelBar1";
            this.panelBar1.Size = new System.Drawing.Size(697, 27);
            this.panelBar1.TabIndex = 19;
            this.panelBar1.Tag = "*";
            // 
            // frmImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(697, 588);
            this.Controls.Add(this.panelBar1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.cboProName);
            this.Controls.Add(this.cboCatPro);
            this.Controls.Add(this.cboSup);
            this.Controls.Add(this.dtpImp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lswImp);
            this.Controls.Add(this.btnNewSup);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtImpID);
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
            this.Name = "frmImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "​​​​​​​​​​​​                                                                     " +
    "                               នាំទំនិញចូល";
            this.Load += new System.EventHandler(this.frmImport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmImport_KeyDown);
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImpID;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupID;
        private System.Windows.Forms.ListView lswImp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewSup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpImp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.ComboBox cboSup;
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
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDelete;
        private Components.PanelControl panelControl1;
        private panelBar panelBar1;
    }
}