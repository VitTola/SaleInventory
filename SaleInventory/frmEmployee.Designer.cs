namespace SaleInventory
{
    partial class frmEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdoF = new System.Windows.Forms.RadioButton();
            this.rdoM = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpHire = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblEmpReport = new System.Windows.Forms.Label();
            this.cboPos = new System.Windows.Forms.ComboBox();
            this.dgvEmp = new System.Windows.Forms.DataGridView();
            this.លេខកូដ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ឈ្មោះ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ភេទ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.កើត = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.តួនាទី = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ប្រាក់ខែ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.អស័យដ្ធាន = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ទូរស័ព្ទ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ចូលធ្វើការ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.រូបថត = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pictureBoxEmp = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panelBar1 = new SaleInventory.panelBar();
            this.panelControl1 = new SaleInventory.Components.PanelControl();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmp)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "អត្តលេខ\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "ឈ្មោះ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(98, 82);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 36);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(12, 288);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(478, 36);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.Tag = "*";
            this.txtSearch.Text = "ស្វែងរកបុក្គលិក.......";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "តួនាទី";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "ភេទ";
            // 
            // rdoF
            // 
            this.rdoF.AutoSize = true;
            this.rdoF.BackColor = System.Drawing.Color.Transparent;
            this.rdoF.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoF.Location = new System.Drawing.Point(98, 123);
            this.rdoF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoF.Name = "rdoF";
            this.rdoF.Size = new System.Drawing.Size(50, 31);
            this.rdoF.TabIndex = 2;
            this.rdoF.TabStop = true;
            this.rdoF.Text = "ស្រី";
            this.rdoF.UseVisualStyleBackColor = false;
            this.rdoF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // rdoM
            // 
            this.rdoM.AutoSize = true;
            this.rdoM.BackColor = System.Drawing.Color.Transparent;
            this.rdoM.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoM.Location = new System.Drawing.Point(198, 123);
            this.rdoM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoM.Name = "rdoM";
            this.rdoM.Size = new System.Drawing.Size(60, 31);
            this.rdoM.TabIndex = 3;
            this.rdoM.TabStop = true;
            this.rdoM.Text = "ប្រុស";
            this.rdoM.UseVisualStyleBackColor = false;
            this.rdoM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGray;
            this.label6.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(290, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "ប្រាក់ខែ";
            // 
            // txtSal
            // 
            this.txtSal.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSal.Location = new System.Drawing.Point(388, 41);
            this.txtSal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(160, 36);
            this.txtSal.TabIndex = 6;
            this.txtSal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkGray;
            this.label7.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(290, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "អាសយដ្ឋាន";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(388, 81);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(160, 75);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(290, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "លេខទូរស័ព្ទ";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(388, 200);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(160, 36);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // dtpDOB
            // 
            this.dtpDOB.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDOB.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtpDOB.Location = new System.Drawing.Point(98, 160);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(160, 36);
            this.dtpDOB.TabIndex = 4;
            this.dtpDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "ថ្ងៃកំណើត";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DarkGray;
            this.label10.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 27);
            this.label10.TabIndex = 0;
            this.label10.Text = "ថ្ងៃចូលធ្វើការ";
            // 
            // dtpHire
            // 
            this.dtpHire.CustomFormat = "dd/MM/yyyy";
            this.dtpHire.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHire.Location = new System.Drawing.Point(388, 160);
            this.dtpHire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpHire.Name = "dtpHire";
            this.dtpHire.Size = new System.Drawing.Size(160, 36);
            this.dtpHire.TabIndex = 8;
            this.dtpHire.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(98, 41);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(160, 36);
            this.txtID.TabIndex = 0;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // lblEmpReport
            // 
            this.lblEmpReport.AutoSize = true;
            this.lblEmpReport.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmpReport.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpReport.ForeColor = System.Drawing.Color.Blue;
            this.lblEmpReport.Location = new System.Drawing.Point(496, 297);
            this.lblEmpReport.Name = "lblEmpReport";
            this.lblEmpReport.Size = new System.Drawing.Size(162, 27);
            this.lblEmpReport.TabIndex = 19;
            this.lblEmpReport.Text = "មើលរបាយការណ៍បុគ្គលិក";
            // 
            // cboPos
            // 
            this.cboPos.FormattingEnabled = true;
            this.cboPos.Location = new System.Drawing.Point(98, 200);
            this.cboPos.Name = "cboPos";
            this.cboPos.Size = new System.Drawing.Size(160, 35);
            this.cboPos.TabIndex = 20;
            // 
            // dgvEmp
            // 
            this.dgvEmp.AllowUserToAddRows = false;
            this.dgvEmp.AllowUserToDeleteRows = false;
            this.dgvEmp.AllowUserToResizeRows = false;
            this.dgvEmp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.លេខកូដ,
            this.ឈ្មោះ,
            this.ភេទ,
            this.កើត,
            this.តួនាទី,
            this.ប្រាក់ខែ,
            this.អស័យដ្ធាន,
            this.ទូរស័ព្ទ,
            this.ចូលធ្វើការ,
            this.រូបថត});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmp.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmp.Location = new System.Drawing.Point(12, 334);
            this.dgvEmp.Name = "dgvEmp";
            this.dgvEmp.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmp.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmp.RowHeadersVisible = false;
            this.dgvEmp.RowTemplate.Height = 30;
            this.dgvEmp.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmp.Size = new System.Drawing.Size(660, 244);
            this.dgvEmp.TabIndex = 24;
            this.dgvEmp.Tag = "*";
            // 
            // លេខកូដ
            // 
            this.លេខកូដ.DataPropertyName = "លេខកូដ";
            this.លេខកូដ.HeaderText = "លេខកូដ";
            this.លេខកូដ.Name = "លេខកូដ";
            this.លេខកូដ.ReadOnly = true;
            // 
            // ឈ្មោះ
            // 
            this.ឈ្មោះ.DataPropertyName = "ឈ្មោះ";
            this.ឈ្មោះ.HeaderText = "ឈ្មោះ";
            this.ឈ្មោះ.Name = "ឈ្មោះ";
            this.ឈ្មោះ.ReadOnly = true;
            // 
            // ភេទ
            // 
            this.ភេទ.DataPropertyName = "ភេទ";
            this.ភេទ.HeaderText = "ភេទ";
            this.ភេទ.Name = "ភេទ";
            this.ភេទ.ReadOnly = true;
            this.ភេទ.Width = 50;
            // 
            // កើត
            // 
            this.កើត.DataPropertyName = "កើត";
            this.កើត.HeaderText = "កើត";
            this.កើត.Name = "កើត";
            this.កើត.ReadOnly = true;
            // 
            // តួនាទី
            // 
            this.តួនាទី.DataPropertyName = "តួនាទី";
            this.តួនាទី.HeaderText = "តួនាទី";
            this.តួនាទី.Name = "តួនាទី";
            this.តួនាទី.ReadOnly = true;
            // 
            // ប្រាក់ខែ
            // 
            this.ប្រាក់ខែ.DataPropertyName = "ប្រាក់ខែ";
            this.ប្រាក់ខែ.HeaderText = "ប្រាក់ខែ";
            this.ប្រាក់ខែ.Name = "ប្រាក់ខែ";
            this.ប្រាក់ខែ.ReadOnly = true;
            // 
            // អស័យដ្ធាន
            // 
            this.អស័យដ្ធាន.DataPropertyName = "អស័យដ្ធាន";
            this.អស័យដ្ធាន.HeaderText = "អស័ដ្ធាន";
            this.អស័យដ្ធាន.Name = "អស័យដ្ធាន";
            this.អស័យដ្ធាន.ReadOnly = true;
            // 
            // ទូរស័ព្ទ
            // 
            this.ទូរស័ព្ទ.DataPropertyName = "ទូរស័ព្ទ";
            this.ទូរស័ព្ទ.HeaderText = "ទូរស័ព្ទ";
            this.ទូរស័ព្ទ.Name = "ទូរស័ព្ទ";
            this.ទូរស័ព្ទ.ReadOnly = true;
            // 
            // ចូលធ្វើការ
            // 
            this.ចូលធ្វើការ.DataPropertyName = "ចូលធ្វើការ";
            this.ចូលធ្វើការ.HeaderText = "ចូលធ្វើការ";
            this.ចូលធ្វើការ.Name = "ចូលធ្វើការ";
            this.ចូលធ្វើការ.ReadOnly = true;
            // 
            // រូបថត
            // 
            this.រូបថត.DataPropertyName = "រូបថត";
            this.រូបថត.HeaderText = "រូបថត";
            this.រូបថត.Name = "រូបថត";
            this.រូបថត.ReadOnly = true;
            // 
            // pictureBoxEmp
            // 
            this.pictureBoxEmp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxEmp.Location = new System.Drawing.Point(554, 41);
            this.pictureBoxEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxEmp.Name = "pictureBoxEmp";
            this.pictureBoxEmp.Size = new System.Drawing.Size(118, 153);
            this.pictureBoxEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEmp.TabIndex = 13;
            this.pictureBoxEmp.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::SaleInventory.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(208, 243);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 37);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "លុប";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnImage.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnImage.FlatAppearance.BorderSize = 2;
            this.btnImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImage.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Image = global::SaleInventory.Properties.Resources.search;
            this.btnImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImage.Location = new System.Drawing.Point(566, 198);
            this.btnImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(92, 37);
            this.btnImage.TabIndex = 10;
            this.btnImage.Text = "ស្វែងរក";
            this.btnImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
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
            this.btnEdit.Location = new System.Drawing.Point(110, 243);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 37);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "កែប្រែ";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
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
            this.btnNew.Location = new System.Drawing.Point(12, 243);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(92, 37);
            this.btnNew.TabIndex = 12;
            this.btnNew.Tag = "*";
            this.btnNew.Text = "បន្ថែម";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // panelBar1
            // 
            this.panelBar1.BackColor = System.Drawing.Color.Gray;
            this.panelBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar1.Location = new System.Drawing.Point(0, 0);
            this.panelBar1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panelBar1.Name = "panelBar1";
            this.panelBar1.Size = new System.Drawing.Size(686, 27);
            this.panelBar1.TabIndex = 32;
            this.panelBar1.Tag = "*";
            // 
            // panelControl1
            // 
            this.panelControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 588);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(686, 49);
            this.panelControl1.TabIndex = 22;
            this.panelControl1.Tag = "*";
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
            this.btnSave.Location = new System.Drawing.Point(580, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 37);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "រក្សារទុក";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            // 
            // frmEmployee
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(686, 637);
            this.Controls.Add(this.panelBar1);
            this.Controls.Add(this.dgvEmp);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.cboPos);
            this.Controls.Add(this.lblEmpReport);
            this.Controls.Add(this.pictureBoxEmp);
            this.Controls.Add(this.dtpHire);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rdoM);
            this.Controls.Add(this.rdoF);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Kh Siemreap", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "​                                                                                " +
    "                    បុក្គលិក";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEmployee_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmp)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdoF;
        private System.Windows.Forms.RadioButton rdoM;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpHire;
        private System.Windows.Forms.PictureBox pictureBoxEmp;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblEmpReport;
        private System.Windows.Forms.ComboBox cboPos;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private Components.PanelControl panelControl1;
        private System.Windows.Forms.DataGridView dgvEmp;
        private System.Windows.Forms.DataGridViewTextBoxColumn លេខកូដ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ឈ្មោះ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ភេទ;
        private System.Windows.Forms.DataGridViewTextBoxColumn កើត;
        private System.Windows.Forms.DataGridViewTextBoxColumn តួនាទី;
        private System.Windows.Forms.DataGridViewTextBoxColumn ប្រាក់ខែ;
        private System.Windows.Forms.DataGridViewTextBoxColumn អស័យដ្ធាន;
        private System.Windows.Forms.DataGridViewTextBoxColumn ទូរស័ព្ទ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ចូលធ្វើការ;
        private System.Windows.Forms.DataGridViewLinkColumn រូបថត;
        private panelBar panelBar1;
    }
}