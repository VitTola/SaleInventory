using SaleInventory.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SaleInventory
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            txtPwd.RegisterEnglishInputWith(txtUser);

        }
        private int count = 0;
        private ErrorProvider error = new ErrorProvider();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panelBar1.Text = "ចូលប្រើប្រាស់";
            btnLogin.Click += Login;
            Operation.connection();
            txtUser.Focus();
        }

        private void Login(object sender, EventArgs e)
        {
            try
            {
                error.Clear();
                error.BlinkRate = 1;
                if (string.IsNullOrEmpty(txtUser.Text.Trim()))
                {
                    error.SetError(txtUser, "សូមបញ្ចូលឈ្មោះអ្នកប្រើប្រាស់!");
                }
                if (string.IsNullOrEmpty(txtPwd.Text.Trim()))
                {
                    error.SetError(txtPwd, "សូមបញ្ចូលលេខកូដអ្នកប្រើប្រាស់!");
                    return;
                }
                SqlCommand com = new SqlCommand("UserLogin", Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@u", txtUser.Text.Trim());
                com.Parameters.AddWithValue("@p", txtPwd.Text.Trim());

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    Operation.EmpID = row[0].ToString();
                    Operation.EmpName = row[1].ToString();
                    Operation.EmpPos = row[4].ToString();

                    frmMain main = new frmMain();
                    main.Show();
                    this.Visible = false;
                }
                else
                {
                    error.SetError(txtPwd, "សូមបញ្ចូលលេខកូដអ្នកប្រើប្រាស់!");
                    error.SetError(txtUser, "សូមបញ្ចូលឈ្មោះអ្នកប្រើប្រាស់!");
                    count++;
                }

                if (count == 3)
                {
                    MessageBox.Show("លោកអ្នកបានបញ្ចូលខុស៣លើក!", "ចាកចេញ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }

    }
}
