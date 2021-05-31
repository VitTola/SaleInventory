using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SaleInventory
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        private SqlCommand com;
        private SqlDataAdapter da;
        private DataTable dt;
        private bool addNew = false;
        private string supID = "0";
        private bool isValidInput = true;
        private ErrorProvider error = new ErrorProvider();

        private void loadData()
        {
            try
            {
                da = new SqlDataAdapter("Select * from dbo.GetSupplier()", Operation.con);
                dt = new DataTable();
                da.Fill(dt);

                lswSup.Clear();
                lswSup.View = View.Details;
                lswSup.Columns.Add("លេខកូដ", 70);
                lswSup.Columns.Add("ឈ្មោះ", 120);
                lswSup.Columns.Add("ទំនាក់ទំនង", 153);

                string[] arr = new string[3];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    arr[0] = dr[0].ToString();
                    arr[1] = dr[1].ToString();
                    arr[2] = dr[2].ToString();
                    lswSup.Items.Add(new ListViewItem(arr));
                }
                lswSup.DefaultListViewStyle();

                this.ActiveControl = btnNew;
                da.Dispose();
                dt.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void modify(string str)
        {
            try
            {
                com = new SqlCommand(str, Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@supID", int.Parse(supID.ToString()));
                com.Parameters.AddWithValue("@sup", txtName.Text);
                com.Parameters.AddWithValue("@supCon", txtContact.Text);
                com.ExecuteNonQuery();

                Operation.onOff(this, false);
                Operation.clearData(this);
                com.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            panelBar1.Text = "ប្រភពផ្គត់ផ្គង់";
            Operation.connection();
            txtName.Enabled = txtContact.Enabled = btnSave.Enabled = false;
            loadData();

            txtSearch.Leave += (o, se) => { txtSearch.Text = "ស្វែងរកប្រភពផ្គត់ផ្គង់......."; txtSearch.ForeColor = Color.Silver; };
            txtSearch.Enter += (o, se) => { txtSearch.Text = ""; txtSearch.ForeColor = Color.Black; };
            btnNew.Click += NewSupplier;
            btnSave.Click += SaveSupplier;
            lswSup.SelectedIndexChanged += listViewSupSelect;
            txtSearch.KeyUp += SearchSupplier;
            btnEdit.Click += (o, ee) => {
                txtName.Enabled = txtContact.Enabled = btnSave.Enabled = true;
                txtName.Focus();
                addNew = false;
                btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";
            };

            btnSave.Enabled = true;
        }

        private void SearchSupplier(object sender, KeyEventArgs e)
        {
            try
            {
                com = new SqlCommand("SearchSupplier", Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@sup", txtSearch.Text);
                da = new SqlDataAdapter(com);
                dt = new DataTable();
                da.Fill(dt);

                lswSup.Clear();
                lswSup.View = View.Details;
                lswSup.Columns.Add("លេខកូដ", 70);
                lswSup.Columns.Add("ឈ្មោះ", 120);
                lswSup.Columns.Add("ទំនាក់ទំនង", 153);

                string[] arr = new string[3];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    arr[0] = dr[0].ToString();
                    arr[1] = dr[1].ToString();
                    arr[2] = dr[2].ToString();
                    lswSup.Items.Add(new ListViewItem(arr));
                }
                lswSup.DefaultListViewStyle();

                da.Dispose();
                dt.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void listViewSupSelect(object sender, EventArgs e)
        {
            try
            {
                if (lswSup.SelectedItems.Count > 0)
                {
                    ListViewItem item = lswSup.SelectedItems[0];
                    supID = item.SubItems[0].Text;
                    txtName.Text = item.SubItems[1].Text;
                    txtContact.Text = item.SubItems[2].Text;
                    btnEdit.Enabled = true;
                    btnNew.Text = "មោឃៈ";
                    btnNew.Image = SaleInventory.Properties.Resources.cancel;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SaveSupplier(object sender, EventArgs e)
        {
            try
            {
                isValidInput = true;
                error.Clear();
                error.BlinkRate = 1;
                if (string.IsNullOrEmpty(txtName.Text.Trim()))
                {
                    error.SetError(txtName, "សូមបញ្ចូលឈ្មោះ!");
                    isValidInput = false;
                }
                if (string.IsNullOrEmpty(txtContact.Text.Trim()))
                {
                    error.SetError(txtContact, "សូមបញ្ចូលលេខទំនាក់ទំនងអ្នកផ្គត់ផ្គង់!");
                    isValidInput = false;
                }
                if (isValidInput)
                {
                    this.modify(addNew == true ? "InsertSupplier" : "UpdateSupplier");
                    loadData();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void NewSupplier(object sender, EventArgs e)
        {
            if (btnNew.Text == "បន្ថែម")
            {
                addNew = txtName.Enabled = true;
                Operation.onOff(this, true);
                txtName.Focus();
                btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";
            }
            else
            {
                error.Clear();
                Operation.clearData(this);
                Operation.onOff(this, false);
                btnNew.Text = "បន្ថែម";
                btnNew.Image = SaleInventory.Properties.Resources.edit;
            }
        }

        private void frmSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }
    }
}

