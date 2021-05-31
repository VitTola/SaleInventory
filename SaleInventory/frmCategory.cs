using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SaleInventory
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        private SqlCommand com;
        private SqlDataAdapter da;
        private DataTable dt;
        private bool addNew = false;
        private string catID = "0";
        private ErrorProvider error = new ErrorProvider();

        private void LoadListview(DataTable dt)
        {
            lswCat.Clear();
            lswCat.View = View.Details;
            lswCat.Columns.Add("លេខកូដ", 80);
            lswCat.Columns.Add("ប្រភេទទំនិញ", 275);
            

            string[] arr = new string[2];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                arr[0] = dr[0].ToString();
                arr[1] = dr[1].ToString();
                lswCat.Items.Add(new ListViewItem(arr));
            }
            lswCat.DefaultListViewStyle();
        }

        private void loadData()
        {
            try
            {
                da = new SqlDataAdapter("Select * from dbo.GetCategory()", Operation.con);
                dt = new DataTable();
                da.Fill(dt);
                LoadListview(dt);
                this.ActiveControl = btnNew;
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void modify(string procedure)
        {
            try
            {
                com = new SqlCommand(procedure, Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", int.Parse(catID.ToString()));
                com.Parameters.AddWithValue("@cat", txtCatName.Text);
                com.ExecuteNonQuery();

                Operation.clearData(this);
                Operation.onOff(this, false);

                com.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            panelBar.Text = "ប្រភេទទំនិញ";
            btnSave.Click += SaveData;
            btnNew.Click += NewCategory;
            txtCatSearch.KeyUp += SearchCategory;
            txtCatSearch.Enter += (o, ce) => { txtCatSearch.Text = ""; txtCatSearch.ForeColor = Color.Black; };
            txtCatSearch.Leave += (o, ce) => { txtCatSearch.Text = "ស្វែងរកប្រភេទទំនិញ........"; txtCatSearch.ForeColor = Color.Silver; };

            btnEdit.Click += (o, ee) => {txtCatName.Enabled = btnSave.Enabled = true; addNew = false;
                btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";
            };
            lswCat.SelectedIndexChanged += (o, ce) => {
                if (lswCat.SelectedItems.Count > 0) {
                    catID = lswCat.SelectedItems[0].SubItems[0].Text;
                    txtCatName.Text = lswCat.SelectedItems[0].SubItems[1].Text;
                    btnEdit.Enabled = true;
                }
            };

            Operation.connection();
            Operation.onOff(this, false);
            loadData();
        }


        private void SearchCategory(object sender, KeyEventArgs e)
        {
            try
            {
                com = new SqlCommand("SearchCategory", Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@cat", txtCatSearch.Text);
                da = new SqlDataAdapter(com);
                dt = new DataTable();
                da.Fill(dt);
                LoadListview(dt);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void NewCategory(object sender, EventArgs e)
        {
            if (btnNew.Text == "បន្ថែម")
            {
                addNew = txtCatName.Enabled = true;
                Operation.onOff(this, true);
                txtCatName.Focus();
                btnNew.Text = "មោឃៈ";
                btnNew.Image = SaleInventory.Properties.Resources.cancel;
            }
            else
            {
                Operation.clearData(this);
                Operation.onOff(this, false);
                btnNew.Text = "បន្ថែម";
                btnNew.Image = SaleInventory.Properties.Resources._new;
            }
        }

        private void SaveData(object sender, EventArgs e)
        {
            try
            {
                error.Clear();
                error.BlinkRate = 1;
                if (string.IsNullOrEmpty(txtCatName.Text.Trim()))
                {
                    error.SetError(txtCatName, "សូមបញ្ចូលឈ្មោះអតិថិជន!");
                    txtCatName.Focus();
                    return;
                }
                modify(addNew == true ? "InsertCategory" : "UpdateCategory");
                loadData();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmCategory_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }

        
    }
}
