using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace SaleInventory
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private SqlCommand com;
        private SqlDataAdapter da;
        private DataTable dt;

        private void fillListBox()
        {
            da = new SqlDataAdapter("Select proID, proName from tbProduct", Operation.con);
            dt = new DataTable();
            da.Fill(dt);

            lstPro.DataSource = null;
            lstPro.Items.Clear();
            lstPro.DataSource = dt;
            lstPro.DisplayMember = "proName";
            lstPro.ValueMember = "proID";
            this.ActiveControl = lstPro;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            panelBar1.Text = "ទំនិញ";
            lstPro.Click += lstProClick;
            btnEdit.Click += EditProduct;
            btnSave.Click += SaveProduct;
            txtSearch.KeyUp += SearchProduct;
            txtSearch.Leave += (o, se) => { txtSearch.Text = "ស្វែងរកទំនិញ....."; txtSearch.ForeColor = Color.Silver; };
            txtSearch.Enter += (o, se) => { txtSearch.Text = ""; txtSearch.ForeColor = Color.Black; };

            Operation.connection();
            Operation.onOff(this, false);
            Operation.fillCbo(cboCatSup, "cat", "id", "tbCategory");
            cboCatSup.Text = null;
            cboCatSup.Enabled = false;
            fillListBox();
            cboCatSup.Enabled = true;
        }

        private void SearchProduct(object sender, KeyEventArgs e)
        {
            try
            {
                com = new SqlCommand("SearchProduct", Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", txtSearch.Text);
                dt = new DataTable();
                da = new SqlDataAdapter(com);
                da.Fill(dt);

                lstPro.DataSource = null;
                lstPro.Items.Clear();
                lstPro.DataSource = dt;
                lstPro.DisplayMember = "proName";
                lstPro.ValueMember = "proID";
            }
            catch (Exception ex){ MessageBox.Show(ex.Message);}
        }

        private void SaveProduct(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommand("UpdateProduct", Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@proID", int.Parse(txtID.Text));
                com.Parameters.AddWithValue("@proName", txtName.Text);
                com.Parameters.AddWithValue("@sPrice", txtSalePrice.Text);
                com.ExecuteNonQuery();

                com.Dispose();
                Operation.onOff(this, false);
                Operation.clearData(this);
                fillListBox();
                txtID.Text = null;
                btnEdit.Text = "កែប្រែ";
                btnEdit.Image = SaleInventory.Properties.Resources.edit;
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void EditProduct(object sender, EventArgs e)
        {
            if (btnEdit.Text == "កែប្រែ")
            {
                Operation.onOff(this, true);
                txtImpPrice.Enabled = txtQty.Enabled = false;
                btnEdit.Text = "មោឃៈ";
                btnEdit.Image = SaleInventory.Properties.Resources.cancel;
            }
            else
            {
                Operation.onOff(this, false);
                btnSave.Enabled = false;
                Operation.clearData(this);
                btnEdit.Text = "កែប្រែ";
                btnEdit.Image = SaleInventory.Properties.Resources.edit;
                txtID.Text = "";
            }
        }

        private void lstProClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = lstPro.SelectedValue.ToString();
                txtName.Text = lstPro.Text;
                com = new SqlCommand("Select * from tbProduct where proID='" + txtID.Text + "'", Operation.con);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtQty.Text = dr[2].ToString();
                    txtSalePrice.Text = dr[4].ToString();
                    txtImpPrice.Text = dr[3].ToString();
                    cboCatSup.SelectedValue = int.Parse(dr[5].ToString());
                }
                com.Dispose();
                dr.Dispose();
                btnEdit.Enabled = true;
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
        }

        private void lstPro_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }
    }
}
