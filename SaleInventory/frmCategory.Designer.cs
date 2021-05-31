namespace SaleInventory
{
    partial class frmCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategory));
            this.txtCatSearch = new System.Windows.Forms.TextBox();
            this.lswCat = new System.Windows.Forms.ListView();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panelBar = new SaleInventory.panelBar();
            this.panelControl1 = new SaleInventory.Components.PanelControl();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCatSearch
            // 
            resources.ApplyResources(this.txtCatSearch, "txtCatSearch");
            this.txtCatSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtCatSearch.Name = "txtCatSearch";
            this.txtCatSearch.Tag = "*";
            this.txtCatSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCategory_KeyDown);
            // 
            // lswCat
            // 
            resources.ApplyResources(this.lswCat, "lswCat");
            this.lswCat.FullRowSelect = true;
            this.lswCat.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lswCat.HideSelection = false;
            this.lswCat.Name = "lswCat";
            this.lswCat.Tag = "*";
            this.lswCat.UseCompatibleStateImageBehavior = false;
            this.lswCat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCategory_KeyDown);
            // 
            // txtCatID
            // 
            resources.ApplyResources(this.txtCatID, "txtCatID");
            this.txtCatID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Tag = "*";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // txtCatName
            // 
            resources.ApplyResources(this.txtCatName, "txtCatName");
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCategory_KeyDown);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Image = global::SaleInventory.Properties.Resources.edit;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCategory_KeyDown);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNew.FlatAppearance.BorderSize = 2;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.Image = global::SaleInventory.Properties.Resources._new;
            this.btnNew.Name = "btnNew";
            this.btnNew.Tag = "*";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCategory_KeyDown);
            // 
            // panelBar
            // 
            resources.ApplyResources(this.panelBar, "panelBar");
            this.panelBar.Name = "panelBar";
            this.panelBar.Tag = "*";
            // 
            // panelControl1
            // 
            this.panelControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelControl1.Controls.Add(this.btnSave);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Tag = "*";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.FlatAppearance.BorderSize = 2;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Image = global::SaleInventory.Properties.Resources.save;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCategory_KeyDown);
            // 
            // frmCategory
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CausesValidation = false;
            this.Controls.Add(this.panelBar);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lswCat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.txtCatSearch);
            this.Controls.Add(this.btnNew);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmCategory";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmCategory_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCategory_KeyDown);
            this.panelControl1.ResumeLayout(false);
            //this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCatSearch;
        private System.Windows.Forms.ListView lswCat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCatName;
        private Components.PanelControl panelControl1;
        private panelBar panelBar;
    }
}