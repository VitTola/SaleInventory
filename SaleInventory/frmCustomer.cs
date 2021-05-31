using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SaleInventory
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private SqlCommand com;
        private SqlDataAdapter da;
        private DataTable dt;
        private bool addNew = false;
        private string cusID = "0";
        private ErrorProvider error = new ErrorProvider();

        private void loadData()
        {
            try
            {
                da = new SqlDataAdapter("Select * from dbo.GetCustomer()", Operation.con);
                dt = new DataTable();
                da.Fill(dt);

                lswCus.Clear();
                lswCus.View = View.Details;
                lswCus.Columns.Add("លេខកូដ", 80);
                lswCus.Columns.Add("ឈ្មោះ", 100);
                lswCus.Columns.Add("លេខទូរស័ព្ទ", 173);

                string[] arr = new string[3];
                ListViewItem item;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    arr[0] = dr[0].ToString();
                    arr[1] = dr[1].ToString();
                    arr[2] = dr[2].ToString();
                    item = new ListViewItem(arr);
                    lswCus.Items.Add(item);
                }
                lswCus.DefaultListViewStyle();

                this.ActiveControl = btnNew;
                da.Dispose();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void modify(string procedure)
        {
            try
            {
                com = new SqlCommand(procedure, Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", int.Parse(cusID.ToString()));
                com.Parameters.AddWithValue("@name", txtName.Text);
                com.Parameters.AddWithValue("@con", txtContact.Text);
                com.ExecuteNonQuery();
                Operation.onOff(this, false);
                Operation.clearData(this);
                btnNew.Text = "បន្ថែម";
                btnNew.Image = SaleInventory.Properties.Resources._new;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            panelBar1.Text = "អតិថិជន";
            txtSearch.Enter += (o, ce) => { txtSearch.Text = ""; txtSearch.ForeColor = Color.Black; };
            txtSearch.Leave += (o, ce) => { txtSearch.Text = "ស្វែងរកតាមឈ្មោះអតិថិជន........"; txtSearch.ForeColor = Color.Silver; };
            btnNew.Click += NewCustomer;
            btnSave.Click += SaveCustomer;
            txtSearch.KeyUp += SearchCustomer;
            btnEdit.Click += (o, ee) => {
                txtContact.Enabled = txtName.Enabled = btnSave.Enabled = true;
                txtName.Focus();
                addNew = false;
                btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";

            };
            lswCus.SelectedIndexChanged += (o, se) => {
                if (lswCus.SelectedItems.Count > 0)
                {
                    ListViewItem item = lswCus.SelectedItems[0];
                    cusID = item.SubItems[0].Text;
                    txtName.Text = item.SubItems[1].Text;
                    txtContact.Text = item.SubItems[2].Text;

                    btnEdit.Enabled = true;
                    btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";

                }
            };
            Operation.connection();
            txtName.Enabled = txtContact.Enabled = btnSave.Enabled = false;
            loadData();
            btnSave.Enabled = true;

        }

        private void SearchCustomer(object sender, KeyEventArgs e)
        {
            try
            {
                com = new SqlCommand("SearchCustomer", Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", txtSearch.Text);
                da = new SqlDataAdapter(com);
                dt = new DataTable();
                da.Fill(dt);

                lswCus.Clear();
                lswCus.View = View.Details;
                lswCus.Columns.Add("លេខកូដ", 80);
                lswCus.Columns.Add("ឈ្មោះ", 100);
                lswCus.Columns.Add("លេខទូរស័ព្ទ", 173);

                string[] arr = new string[3];
                ListViewItem item;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    arr[0] = dr[0].ToString();
                    arr[1] = dr[1].ToString();
                    arr[2] = dr[2].ToString();
                    item = new ListViewItem(arr);
                    lswCus.Items.Add(item);
                }
                lswCus.DefaultListViewStyle();
                da.Dispose();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveCustomer(object sender, EventArgs e)
        {
            try
            {
                error.Clear();
                error.BlinkRate = 1;
                if (string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    error.SetError(txtName, "សូមបញ្ជូលឈ្មោះអតិថិជន!");
                    txtName.Focus();
                    return;
                }
                else if (string.IsNullOrEmpty(txtContact.Text.Trim()))
                {
                    error.SetError(txtContact, "សូមបញ្ជូលមធ្យោបាយទំនាក់ទំនងអតិថិជន!");
                    txtContact.Focus();
                    return;
                }
                modify(addNew == true ? "InsertCustomer" : "UpdateCustomer");
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewCustomer(object sender, EventArgs e)
        {
            if (btnNew.Text == "បន្ថែម")
            {
                addNew = true;
                Operation.onOff(this, true);
                txtName.Enabled = true;
                txtName.Focus();
                btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";
            }
            else
            {
                Operation.clearData(this);
                Operation.onOff(this, false);
                btnNew.Text = "បន្ថែម";
                btnNew.Image = SaleInventory.Properties.Resources._new;
            }
        }

        private void frmCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }
    }
}
