using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace SaleInventory
{
    public partial class frmImport : Form
    {
        public frmImport()
        {
            InitializeComponent();
        }

        private decimal Total = 0;
        private bool newSup = false;
        private SqlCommand com;
        private int supID;
        private bool isValidInput = true;
        private ErrorProvider error = new ErrorProvider();

        private int GetCategoryId(string cat)
        {
            Operation.connection();
            SqlCommand sqlCommand = new SqlCommand("select dbo.GetCategoryId('"+cat+"')", Operation.con);
            return (int)sqlCommand.ExecuteScalar();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            panelBar1.Text = "ការនាំចូល";
            lblTotal.BringToFront();
            txtTotal.BringToFront();
            cboCatPro.KeyPress += (o, ce) => { ce.Handled = true; };
            btnNew.Click += NewImport;
            btnSave.Click += SaveImport;
            cboSup.SelectionChangeCommitted += SelectComboxSup;
            cboProName.SelectionChangeCommitted += SelectCboProName;
            txtProID.TextChanged += ProductIDChanged;
            btnNewSup.Click += NewSupplier;
            btnDelete.Click += DeleteImport;
            btnAddItem.Click += AddItems;

            Operation.connection();
            Operation.onOff(this, false);
            Operation.fillCbo(cboSup, "supName", "supID", "tbSupplier");
            Operation.fillCbo(cboCatPro, "cat", "id", "tbCategory");
            Operation.fillCbo(cboProName, "proName", "proID", "tbProduct");
            txtSupID.Text = txtImpID.Text = "Auto number";

        }

        private void AddItems(object sender, EventArgs e)
        {
            try
            {
                decimal amount;
                error.Clear();
                error.BlinkRate = 1;
                isValidInput = true;

                if (dtpImp.Value.Date>DateTime.Now)
                {
                    error.SetError(dtpImp, "សូមពិនិត្រមើថ្ងៃនាំចូលម្តងទៀត!");
                    dtpImp.Focus();
                    SendKeys.Send("%{DOWN}");
                    isValidInput = false;
                }

                if (string.IsNullOrEmpty(cboSup.Text.Trim()))
                {
                    error.SetError(cboSup, "សូមជ្រើសរើសអតិថិជន!");
                    isValidInput = false;
                    cboSup.DroppedDown = true;
                }
                if (string.IsNullOrEmpty(cboProName.Text.Trim()))
                {
                    error.SetError(cboProName, "សូមជ្រើសរើសឈ្មោះទំនិញ!");
                    isValidInput = false;
                }
                if (string.IsNullOrEmpty(txtProID.Text.Trim()))
                {
                    error.SetError(txtProID, "សូមមើលលេខកូដទំនិញឡើងវិញ!");
                    isValidInput = false;
                }

                if (string.IsNullOrEmpty(cboCatPro.Text.Trim()))
                {
                    error.SetError(cboCatPro, "សូមជ្រើសរើសប្រភេទទំនិញ!");
                    isValidInput = false;
                   // cboCatPro.DroppedDown = true;
                }

                if (string.IsNullOrEmpty(txtQty.Text.Trim()))
                {
                    error.SetError(txtQty, "សូមបញ្ចូលបរិមាណទំនិញ!");
                    isValidInput = false;
                    txtQty.Focus();
                }

                if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
                {
                    error.SetError(txtPrice, "សូមបញ្ចូលតម្លៃលក់!");
                    isValidInput = false;
                    txtPrice.Focus();
                }
                if (isValidInput)
                {
                    string[] arr = new string[7];
                    arr[0] = txtProID.Text;
                    arr[1] = cboProName.Text;
                    arr[2] = cboCatPro.Text;
                    arr[3] = txtQty.Text;
                    arr[4] = string.Format("{0:c}", decimal.Parse(txtPrice.Text));
                    amount = (decimal.Parse(txtPrice.Text) * decimal.Parse(txtQty.Text));
                    arr[5] = string.Format("{0:c}", amount);
                    arr[6] = cboCatPro.SelectedValue.ToString();

                    ListViewItem item = new ListViewItem(arr);
                    lswImp.Items.Add(item);
                    Total = amount + Total;
                    txtTotal.Text = string.Format("{0:c}", Total);
                    txtTotal.Tag = '*'; //To Prevent total textbox from clear
                    txtPrice.Text = txtSupID.Text = cboCatPro.Text = cboProName.Text = txtQty.Text = txtProID.Text = "";
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DeleteImport(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("តើអ្នកពិតជាចង់លុបមែនឬទេ?", "លុប", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lswImp.Items)
                    {
                        if (item.Selected == true)
                        {
                            var a = decimal.Parse(lswImp.SelectedItems[0].SubItems[4].Text, System.Globalization.NumberStyles.Currency);
                            Total = Total - a;
                            txtTotal.Text = Total.ToString();
                            lswImp.Items.Remove(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewSupplier(object sender, EventArgs e)
        {
            newSup = true;
            this.Close();
            frmSupplier sup = new frmSupplier();
            sup.ShowDialog();
        }

        private void ProductIDChanged(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommand("Select category from tbProduct where proID='" + txtProID.Text + "'", Operation.con);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        cboCatPro.SelectedValue = dr[0].ToString();
                        cboProName.SelectedValue = txtProID.Text;
                    }
                }
                else
                {
                    cboProName.Text = null;
                    cboCatPro.Text = null;
                }
                com.Dispose();
                dr.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SelectCboProName(object sender, EventArgs e)
        {
            try
            {
                txtProID.Text = cboProName.SelectedValue.ToString();
                com = new SqlCommand("Select category from tbProduct where proID = '" + txtProID.Text + "'", Operation.con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read()) { cboCatPro.SelectedValue = dr[0].ToString(); }
                com.Dispose();
                dr.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SelectComboxSup(object sender, EventArgs e)
        {
            try
            {
                supID = int.Parse(cboSup.SelectedValue.ToString());
                com = new SqlCommand("Select supID, contact from tbSupplier where supID =" + supID, Operation.con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    txtSupID.Text = dr[0].ToString();
                    txtContact.Text = dr[1].ToString();
                }
                com.Dispose();
                dr.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SaveImport(object sender, EventArgs e)
        {
            try
            {
                //Prevent saving if there is no data in list
                if (lswImp.Items.Count < 1)
                {
                    MessageBox.Show("សូមបញ្ចូលទំនិញជាមុនសិន", "អត់ទំនិញ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAddItem.Focus(); return;
                }

                //To send values to sql type we must use datable
                DataTable dtMaster = new DataTable();
                dtMaster.Columns.Add("impDate", typeof(DateTime));
                dtMaster.Columns.Add("supID", typeof(int));
                dtMaster.Columns.Add("supName", typeof(string));
                dtMaster.Columns.Add("supCon", typeof(string));
                dtMaster.Columns.Add("empID", typeof(string));
                dtMaster.Columns.Add("empName", typeof(string));
                dtMaster.Columns.Add("impTotal", typeof(float));

                DateTime impDate = dtpImp.Value;
                if (newSup == true) supID = 0;
                dtMaster.Rows.Add(impDate, supID, cboSup.Text, txtContact.Text, Operation.EmpID, Operation.EmpName, Total);

                DataTable dtDetail = new DataTable();
                dtDetail.Columns.Add("proID", typeof(string));
                dtDetail.Columns.Add("proName", typeof(string));
                dtDetail.Columns.Add("impqty", typeof(int));
                dtDetail.Columns.Add("impPrice", typeof(float));
                dtDetail.Columns.Add("catID", typeof(int));
                string category;

                foreach (ListViewItem item in lswImp.Items)
                {
                    int pid;
                    if (!int.TryParse(item.SubItems[0].Text, out pid))
                        pid = 0;

                    string pn = item.SubItems[1].Text;
                    string q = item.SubItems[3].Text;
                    category = item.SubItems[2].Text;
                    int ci = this.GetCategoryId(category);
                    var up = decimal.Parse(item.SubItems[4].Text, NumberStyles.Currency);
                   
                    dtDetail.Rows.Add(pid, pn, ci, q, up);

                }

                com = new SqlCommand("InsertImport", Operation.con);
                com.CommandType = CommandType.StoredProcedure;

                SqlParameter par1 = new SqlParameter();
                par1.ParameterName = "@IM";
                par1.SqlDbType = SqlDbType.Structured; //Tell that par1 is structure or type
                par1.Value = dtMaster;
                com.Parameters.Add(par1);

                SqlParameter par2 = new SqlParameter();
                par2.ParameterName = "@ID";
                par2.SqlDbType = SqlDbType.Structured;
                par2.Value = dtDetail;
                com.Parameters.Add(par2);

                com.ExecuteNonQuery();
                lswImp.Items.Clear();
                btnNew.Text = "បន្ថែម";
                btnNew.Image = SaleInventory.Properties.Resources._new;
                Operation.clearData(this);
                Operation.onOff(this, false);
                txtTotal.Text = null;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void NewImport(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(Operation.EmpID) == 0) { MessageBox.Show("សូមអភ័យទោសសូមអ្នកចូលអ្នកប្រើប្រាស់ដែលមានទួនាទីស្តុកដើម្បីធ្វើការទទួលទំនិញ!"); return; };
                Operation.onOff(this, true);
                if (btnNew.Text == "បន្ថែម")
                {
                    Operation.onOff(this, true);
                    txtPrice.Enabled = true;
                    Operation.clearData(this);
                    btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";

                    lswImp.Clear();
                    lswImp.View = View.Details;
                    lswImp.Columns.Add("លេខកូដ", 80);
                    lswImp.Columns.Add("ឈ្មោះទំនិញ", 150);
                    lswImp.Columns.Add("ប្រភេទ", 100);
                    lswImp.Columns.Add("បរិមាណ", 80);
                    lswImp.Columns.Add("ចំនួន", 80);
                    lswImp.Columns.Add("តំលៃរាយ", 180);
                    Total = 0;
                }
                else
                {
                    if (MessageBox.Show("តើអ្នកពិតជាចង់ទុកជាមោឃ:មែនឬទេ?", "មោឃ:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        error.Clear();
                        btnNew.Text = "បន្ថែម";
                        btnNew.Image = SaleInventory.Properties.Resources._new;
                        Operation.clearData(this);
                        Operation.onOff(this, false);
                        txtPrice.Text = txtSupID.Text = txtTotal.Text = "";
                        lswImp.Items.Clear();
                    }

                    //In case btnNewSup is in Old sup
                    if (btnNewSup.Text == "អ្នកផ្គត់ផ្គង់ចាស់")
                    {
                        btnNewSup.Text = "បន្ថែមប្រភពផ្គត់ផ្គង់";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmImport_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }
    }
}
