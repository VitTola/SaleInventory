using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaleInventory
{
    public partial class frmCreateAccount : Form
    {
        public frmCreateAccount()
        {
            InitializeComponent();
        }

        private SqlCommand com;
        private SqlDataAdapter da;
        private DataTable dt;
        private bool isNewEmployee = false;
        private string eid;
        private string pos = "";
        private string enableNew = null;
        private bool isValidInput = true;
        ErrorProvider error = new ErrorProvider();

        void fillList()
        {
            try
            {
                string sql = "select * from tbUser";
                string sql1 = "select * from tbUser where Id = '" + Operation.EmpID + "'";
                da = new SqlDataAdapter(Operation.EmpID == "0" || Operation.EmpPos == "admin" ? enableNew = sql : sql1, Operation.con);
                btnNew.Enabled = enableNew != null ? true : false;
                dt = new DataTable();
                da.Fill(dt);

                lstUser.DataSource = null;
                lstUser.Items.Clear();
                lstUser.DataSource = dt;

                lstUser.DisplayMember = "userName";
                lstUser.ValueMember = "Id";
                da.Dispose();
            }
            catch (Exception ex) {  MessageBox.Show(ex.Message); }
        }

        private void frmCreateAccount_Load(object sender, EventArgs ex)
        {
            panelBar1.Text = "ការកំណត់អ្នកប្រើប្រាស់";
            btnNew.Click += NewUser;
            lstUser.Click += ListViewCellClick;
            btnDelete.Click += DeleteUser;
            btnSave.Click += SaveUser;
            cboEmp.SelectionChangeCommitted += SelectComboxEmp;

            Operation.connection();
            Operation.onOff(this, false);
            fillList();
        }

        private void SaveUser(object sender, EventArgs e)
        {
            try
            {
                isValidInput = true;
                error.Clear();
                error.BlinkRate = 1;
                if (string.IsNullOrEmpty(cboEmp.Text.Trim()))
                {
                    error.SetError(cboEmp, "សូបជ្រើសរើសឈ្មោះបុក្គលិក!");
                    cboEmp.Focus();
                    isValidInput = false;
                }
               if (string.IsNullOrEmpty(txtUser.Text.Trim()))
                {
                    error.SetError(txtUser, "សូមបញ្ចូលឈ្មោះអ្នកប្រើប្រាស់!");
                    isValidInput = false;
                    txtUser.Focus();
                }
                 if (string.IsNullOrEmpty(txtPwd.Text.Trim()))
                {
                    error.SetError(txtPwd, "សូមបញ្ជុលលេខសំងាត់!");
                    isValidInput = false;
                    txtPwd.Focus();
                }
                if (string.IsNullOrEmpty(txtRePwd.Text.Trim()))
                {
                    error.SetError(txtRePwd, "សូមបញ្ចូលលេខសំងាត់ម្ដងទៀត!");
                    isValidInput = false;
                    txtRePwd.Focus();
                }
                if (txtPwd.Text != txtRePwd.Text)
                {
                    error.SetError(txtRePwd, "បញ្ជាក់លេខសំងាត់មិនត្រឹមត្រូវ!");
                    txtRePwd.Text = "";
                    isValidInput = false;
                    txtRePwd.Focus();
                }

                if (isValidInput)
                {
                    Modify(isNewEmployee == true ? "CreateAcc" : "UpdateAcc");

                    Operation.clearData(this);
                    Operation.onOff(this, false);
                    btnNew.Text = "បន្ថែម";
                    btnNew.Image = SaleInventory.Properties.Resources._new;
                    fillList();
                    isNewEmployee = false;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SelectComboxEmp(object sender, EventArgs e)
        {
            try
            {
                eid = cboEmp.SelectedValue.ToString();
                da = new SqlDataAdapter("SELECT pos FROM tbEmployee WHERE empID = " + eid, Operation.con);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0) pos = dt.Rows[0][0].ToString();
                txtUser.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DeleteUser(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    com = new SqlCommand("delete from tbUser where empID = '" + eid + "'", Operation.con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Your account was deleted...", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillList();
                    btnNew.Text = "បន្ថែម";
                    btnNew.Image = SaleInventory.Properties.Resources._new;
                    Operation.clearData(this);
                    Operation.onOff(this, false);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void ListViewCellClick(object sender, EventArgs e)
        {
            try
            {
                if (isNewEmployee == true) return; //In case b =true or create new user disable listbox click 
                if (lstUser.Items.Count > 0)
                {
                    isNewEmployee = false;
                    eid = lstUser.SelectedValue.ToString();
                    txtUser.Text = lstUser.Text;
                    btnNew.Enabled = true;
                    btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";

                    Operation.fillCbo(cboEmp, "accName", "Id", "tbUser where Id = " + eid.ToString());
                    Operation.onOff(this, true);

                    ///
                    ///SET CONDITION TO CONTROLS FOR VARIOUS USERS
                    ///
                    if (Operation.EmpID != eid) //This condition for default and second admin click on anothers not themselves
                    {
                        int empid = int.Parse(eid.ToString());
                        if (empid == 0) //if second admin select on default admin
                        {
                            Operation.onOff(this, false);
                            btnNew.Enabled = false;
                            btnNew.Text = "បន្ថែម";
                            btnNew.Image = SaleInventory.Properties.Resources._new;
                            return;
                        }
                        else       //default admin click on all another and second admin click on all beside 1admin
                        {
                            Operation.onOff(this, true);
                            return;
                        }
                    }
                    else              //This condition for all type of users select on themselves
                    {
                        if (eid == "0") //if default and himselt not allowed to do anything
                        {
                            Operation.onOff(this, false);
                            return;
                        }
                        else          //if beside default-admin click on themselves 
                        {
                            Operation.onOff(this, true);
                            btnDelete.Enabled = false;
                            btnNew.Enabled = true;
                            btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";
                            return;
                        }

                    }

                }
            }
            catch (Exception ex) {  MessageBox.Show(ex.Message);}
        }

        private void NewUser(object sender, EventArgs e)
        {
            try
            {
                if (btnNew.Text == "បន្ថែម")
                {
                    Operation.onOff(this, true);
                    isNewEmployee = cboEmp.DroppedDown = true; //Drop combobox down
                    btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";
                    Operation.fillCbo(cboEmp, "empName", "empID", "dbo.GetNonUser()");
                }
                else
                {
                    if (MessageBox.Show("តើអ្នកពិតជាចង់ទុកជាមោឃ:មែនដែរឬទេ?", "មោឃ:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        isNewEmployee = false;
                        Operation.clearData(this);
                        btnNew.Text = "បន្ថែម";
                        btnNew.Image = SaleInventory.Properties.Resources._new;
                        Operation.onOff(this, false);
                        btnNew.Enabled = Operation.EmpID == "0" || Operation.EmpPos == "admin" ? true : false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Modify(string procedure)
        {
            try
            {
                com = new SqlCommand(procedure, Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@empID", eid);
                com.Parameters.AddWithValue("@userName", txtUser.Text);
                com.Parameters.AddWithValue("@accName", cboEmp.Text);
                com.Parameters.AddWithValue("@password", txtPwd.Text);
                com.Parameters.AddWithValue("@pos", pos);  //pos got from cboEmp_SelectionChangeCommitted() func
                com.ExecuteNonQuery();
                com.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmCreateAccount_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }

       
    }
}
