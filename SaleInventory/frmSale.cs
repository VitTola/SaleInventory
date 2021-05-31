using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SaleInventory
{
    [System.Runtime.InteropServices.Guid("A84FD39F-2134-40E1-BA65-01DB74424556")]
    public partial class frmSale : Form
    {
        private SqlCommand com;
        private int cusID​ =0;
        private frmInvoice finv = new frmInvoice();
        private decimal Total = 0;
        private ErrorProvider error = new ErrorProvider();
        private bool isValidInput = true;

        public frmSale()
        {
            InitializeComponent();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            panelBar1.Text = "លក់ទំនិញ";
            Operation.connection();
            Operation.onOff(this, false);
            Operation.fillCbo(cboProName, "proName", "proID", "tbProduct");
            Operation.fillCbo(cboCatPro, "cat", "id", "tbCategory");
            Operation.fillCbo(cboCus, "cusName", "cusID", "tbCustomer");

            btnAddItem.Click += AddItmeClick;
            btnDelete.Click += DeleteSale;
            btnNew.Click += NewSale;
            btnNewCus.Click += NewCustomer;
            btnSave.Click += SaveSale;
            cboProName.SelectionChangeCommitted += cboProNameSelect;
            cboCus.SelectionChangeCommitted += cboCusSelect;
            txtTotal.BringToFront();
            lblTotal.BringToFront();
        }

        private void cboCusSelect(object sender, EventArgs e)
        {
            try
            {
                cusID = int.Parse(cboCus.SelectedValue.ToString());
                com = new SqlCommand("select contact from tbCustomer where cusID = " + cusID, Operation.con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    txtCusID.Text = cusID.ToString();
                    txtContact.Text = dr[0].ToString();
                }
                dr.Dispose();
                com.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void cboProNameSelect(object sender, EventArgs e)
        {
            try
            {
                txtProID.Text = cboProName.SelectedValue.ToString(); //Product ID already selected from db and store in cbo
                com = new SqlCommand("SELECT category,salePrice FROM tbProduct WHERE proID = " + txtProID.Text, Operation.con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cboCatPro.SelectedValue = int.Parse(dr[0].ToString());
                    txtPrice.Text = string.Format("{0:c}", dr[1].ToString());
                    txtQty.Text = "1";
                }
                com.Dispose();
                dr.Dispose();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SaveSale(object sender, EventArgs e)
        {
            try
            {
                if (lswSale.Items.Count < 1)
                {
                    MessageBox.Show("សូមបញ្ចូលទំនិញក្នុងតារាងលក់ជាមុន!", "បញ្ចូលទំនិញ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAddItem.Focus(); return;
                }

                //To send values to sql type we must use datable
                DataTable dtMaster = new DataTable();
                dtMaster.Columns.Add("saleDate", typeof(DateTime));
                dtMaster.Columns.Add("empID", typeof(string));
                dtMaster.Columns.Add("empName", typeof(string));
                dtMaster.Columns.Add("cusID", typeof(int));
                dtMaster.Columns.Add("cusName", typeof(string));
                dtMaster.Columns.Add("cusCon", typeof(string));
                dtMaster.Columns.Add("sTotal", typeof(float));

                if (string.IsNullOrEmpty(txtTotal.Text.Trim()))
                {
                    var Total = decimal.Parse(txtTotal.Text, NumberStyles.Currency);
                }
                dtMaster.Rows.Add(dtpSale.Value, Operation.EmpID, Operation.EmpName, cusID, cboCus.Text, txtContact.Text, Total);

                DataTable dtDetail = new DataTable();
                dtDetail.Columns.Add("proID", typeof(string));
                dtDetail.Columns.Add("proName", typeof(string));
                dtDetail.Columns.Add("qty", typeof(int));
                dtDetail.Columns.Add("up", typeof(float));

                DataTable dtInvoice = new DataTable();
                dtInvoice.Columns.Add("proID", typeof(string));
                dtInvoice.Columns.Add("proName", typeof(string));
                dtInvoice.Columns.Add("qty", typeof(int));
                dtInvoice.Columns.Add("price", typeof(float));
                dtInvoice.Columns.Add("amount", typeof(float));

                foreach (ListViewItem item in lswSale.Items)
                {
                    int q = int.Parse(item.SubItems[2].Text);
                    var up = decimal.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                    dtDetail.Rows.Add(item.Text, item.SubItems[1].Text, q, up);
                    dtInvoice.Rows.Add(item.Text, item.SubItems[1].Text, q, up, q * up);
                }

                com = new SqlCommand("InsertSale", Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter par1 = new SqlParameter();
                par1.ParameterName = "@SM";
                par1.SqlDbType = SqlDbType.Structured; //Tell that par1 is structure or type
                par1.Value = dtMaster;
                com.Parameters.Add(par1);

                SqlParameter par2 = new SqlParameter();
                par2.ParameterName = "@SD";
                par2.SqlDbType = SqlDbType.Structured;
                par2.Value = dtDetail;
                com.Parameters.Add(par2);

                //Get @sid back from sql server
                com.Parameters.Add("@sid", SqlDbType.Int).Direction = ParameterDirection.Output;
                com.Parameters.Add("@cid", SqlDbType.Int).Direction = ParameterDirection.Output;
                com.ExecuteNonQuery();
                var saleID = int.Parse(com.Parameters["@sid"].Value.ToString());
                cusID = int.Parse(com.Parameters["@cid"].Value.ToString());
                this.PrintInvoice(dtInvoice, saleID);

                Operation.clearData(this);
                txtTotal.Text = txtPrice.Text = cboCatPro.Text = null;
                lswSale.Items.Clear();
                Operation.onOff(this, false);
                btnNew.Text = "បន្ថែម";
                btnNew.Image = SaleInventory.Properties.Resources._new;
                btnNewCus.Text = "អតិថិជនថ្មី";
                btnNewCus.Image = SaleInventory.Properties.Resources.newperson;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void NewCustomer(object sender, EventArgs e)
        {
            if (btnNewCus.Text == "អតិថិជនថ្មី")
            {
                cboCus.DataSource = txtCusID.Text = null;
                cboCus.Items.Clear();
                cboCus.Focus();
                Operation.clearData(this);
                cusID = 0;
                btnNewCus.Text = "អតិថិជនចាស់";
            }
            else
            {
                btnNewCus.Text = "អតិថិជនថ្មី";
                Operation.fillCbo(cboCus, "cusName", "cusID", "tbCustomer");
            }
        }

        private void NewSale(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(Operation.EmpID) ==0) { MessageBox.Show("សូមអភ័យទោសសូមអ្នកចូលអ្នកប្រើប្រាស់ដែលមានទួនាទីលក់ដើម្បីធ្វើការលក់!");return; };
                if (btnNew.Text == "បន្ថែម")
                {
                    //Allowed to fill cbocus if the not click newcustomer button
                    Operation.fillCbo(cboCus, "cusName", "cusID", "tbCustomer");

                    Operation.onOff(this, true);
                    btnNewCus.Enabled = true;
                    Operation.clearData(this);
                    txtCusID.Text = "លេខអូតូ";
                    dtpSale.CustomFormat = "dd/MM/yyyy"; //Don't need to clear date time because selling is current time
                    btnNew.Text = "មោឃៈ";
                    btnNew.Image = SaleInventory.Properties.Resources.cancel;

                    lswSale.Clear();
                    lswSale.View = View.Details;
                    lswSale.Columns.Add("លេខកូដ", 150);
                    lswSale.Columns.Add("ឈ្មោះទំនិញ", 220);
                    lswSale.Columns.Add("បរិមាណ", 100);
                    lswSale.Columns.Add("តម្លៃរាយ", 150);
                    lswSale.Columns.Add("សរុប", 150);
                    Total = 0;

                }
                else
                {
                    if (MessageBox.Show("តើអ្នកពិតជាចង់ទុកជាមោឃ:មែនឬទេ?", "មោឃ:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        btnNew.Text = "បន្ថែម";
                        btnNew.Image = SaleInventory.Properties.Resources._new;
                        btnNewCus.Text = "អតិថិជនថ្មី";
                        Operation.clearData(this);
                        Operation.onOff(this, false);
                        txtPrice.Text = txtCusID.Text = null;
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DeleteSale(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("តើអ្នកពិតជាចង់លុបមែនឬទេ?", "លុប", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    foreach (ListViewItem item in lswSale.Items)
                    {
                        if (item.Selected == true)
                        {
                            var a = decimal.Parse(lswSale.SelectedItems[0].SubItems[4].Text, NumberStyles.Currency);
                            Total = Total - a;
                            txtTotal.Text = string.Format("{0:c}", Total);
                            lswSale.Items.Remove(item);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void AddItmeClick(object sender, EventArgs e)
        {
            try
            {
                isValidInput = true;
                error.Clear();
                error.BlinkRate = 1;

                if (string.IsNullOrEmpty(dtpSale.Text.Trim()))
                {
                    error.SetError(dtpSale, "សូមពិនិត្រមើលថ្ងៃលក់ម្ដងទៀត!");
                    isValidInput = false;
                    dtpSale.Focus();
                    SendKeys.Send("%{DOWN}"); 
                }


                if (string.IsNullOrEmpty(cboProName.Text.Trim()))
                {
                    error.SetError(cboProName, "សូមពិនិត្រមើលថ្ងៃលក់ម្ដងទៀត!");
                    isValidInput = false;
                   // cboProName.DroppedDown = true; 
                }

                if (isValidInput)
                {
                    ListViewItem item;
                    string[] arr = new string[7];
                    decimal amount;

                    arr[0] = txtProID.Text;
                    arr[1] = cboProName.Text;
                    arr[2] = txtQty.Text;
                    arr[3] = string.Format("{0:c}", decimal.Parse(txtPrice.Text));
                    amount = decimal.Parse(txtQty.Text) * decimal.Parse(txtPrice.Text);
                    arr[4] = string.Format("{0:c}", amount);
                    //arr[5] = cboCatPro.Text;
                    //arr[6] = cboCatPro.SelectedValue.ToString();
                    item = new ListViewItem(arr);
                    lswSale.Items.Add(item);

                    Total = amount + Total;
                    txtTotal.Text = string.Format("{0:c}", Total);
                    txtProID.Text = cboProName.Text = txtQty.Text = txtPrice.Text = cboCatPro.Text = "";
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void PrintInvoice(DataTable dtInvoice, int saleID)
        {
            frmInvoice finv = new frmInvoice();
            finv.Vinv.ProcessingMode = ProcessingMode.Local;
            LocalReport lReport = finv.Vinv.LocalReport;
            lReport.DisplayName = "rptInvoice.rdlc";
            lReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("dsInvoice", dtInvoice);
            lReport.DataSources.Add(rds);

            ReportParameter p1 = new ReportParameter("InvNo", string.Format("{0:00000}", saleID));
            lReport.SetParameters(p1);
            ReportParameter p2 = new ReportParameter("InvDate", dtpSale.Value.ToString("dd-MM-yyyy"));
            lReport.SetParameters(p2);
            ReportParameter p3 = new ReportParameter("EmpID", Operation.EmpID.ToString());
            lReport.SetParameters(p3);
            ReportParameter p4 = new ReportParameter("CusID", txtCusID.Text == "Auto number" && string.IsNullOrEmpty(cboCus.Text.Trim()) ? "NA" : cusID.ToString());
            lReport.SetParameters(p4);
            ReportParameter p5 = new ReportParameter("CusName", string.IsNullOrEmpty(cboCus.Text.Trim()) ? "NA" : cboCus.Text);
            lReport.SetParameters(p5);
            ReportParameter p6 = new ReportParameter("total", txtTotal.Text);
            lReport.SetParameters(p6);
            finv.Show();
            finv.Vinv.RefreshReport();
        }

        private void frmSale_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }

    }
}
