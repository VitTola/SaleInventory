using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SaleInventory
{
    public partial class frmSaleReport : Form
    {
        public frmSaleReport()
        {
            InitializeComponent();
        }
        private SqlDataAdapter da;
        private SqlCommand com;
        private DataTable dt;
        private string employeeId = null;
        private int customerId = 0;
        private string customerName = "អតិថិជនទាំងអស់";
        private bool isSelectedCus = false;
        private ErrorProvider error = new ErrorProvider();

        private void frmSaleReport_Load(object sender, System.EventArgs e)
        {
            panelBar1.Text = "របាយការណ៍ការលក់ទំនិញ";
            Operation.connection();
            Operation.onOff(this, false);
            Operation.fillCbo(cboEmp, "empName", "empID", "tbEmployee");
            cboCus.SelectionChangeCommitted += (o, ce) => {
                customerId = int.Parse(cboCus.SelectedValue.ToString());
                isSelectedCus = true;
            };
            btnNew.Click += NewReport;
            btnShow.Click += ShowInListView;
            cboEmp.SelectionChangeCommitted += comboxEmpSelect;
            btnPreview.Click += PreviewReport;
        }

        private void PreviewReport(object sender, EventArgs e)
        {
            try
            {
                frmRptSale rss = new frmRptSale();
                rss.VSale.ProcessingMode = ProcessingMode.Local;
                LocalReport lRtp = rss.VSale.LocalReport;
                lRtp.DisplayName = "rptSale.rdlc";
                lRtp.DataSources.Clear();

                DataTable dtss = new DataTable();
                dtss.Columns.Add("saleID", typeof(string));
                dtss.Columns.Add("saleDate", typeof(string));
                dtss.Columns.Add("cusName", typeof(string));
                dtss.Columns.Add("proID", typeof(string));
                dtss.Columns.Add("proName", typeof(string));
                dtss.Columns.Add("qty", typeof(string));
                dtss.Columns.Add("price", typeof(string));
                dtss.Columns.Add("amount", typeof(string));

                decimal t = 0;
                foreach (ListViewItem item in lswSaleReport.Items)
                {
                    string sid = item.Text;
                    string sdate = string.Format("{0:dd-MM-yyyy}", item.SubItems[1].Text);
                    string cus = item.SubItems[2].Text;
                    string pid = item.SubItems[3].Text;
                    string pn = item.SubItems[4].Text;
                    string q = item.SubItems[5].Text;
                    string pr = item.SubItems[6].Text;
                    string am = item.SubItems[7].Text;
                    t = t + decimal.Parse(item.SubItems[7].Text, NumberStyles.Currency);
                    dtss.Rows.Add(sid, sdate, cus, pid, pn, q, pr, am);
                }
                ReportDataSource rds = new ReportDataSource("dsRptSale", dtss);
                lRtp.DataSources.Add(rds);
                ReportParameter p1 = new ReportParameter("empID", employeeId);
                lRtp.SetParameters(p1);
                ReportParameter p2 = new ReportParameter("empName", cboEmp.Text);
                lRtp.SetParameters(p2);
                ReportParameter p3 = new ReportParameter("cusName", customerName);
                lRtp.SetParameters(p3);
                ReportParameter p4 = new ReportParameter("begin", dtpStart.Value.ToString("dd/MM/yyyy"));
                lRtp.SetParameters(p4);
                ReportParameter p5 = new ReportParameter("end", dtpStop.Value.ToString("dd/MM/yyyy"));
                lRtp.SetParameters(p5);
                ReportParameter p6 = new ReportParameter("total", string.Format("{0:c}", t, ToString()));
                lRtp.SetParameters(p6);

                rss.Show();
                rss.VSale.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboxEmpSelect(object sender, EventArgs e)
        {
            try
            {
                cboCus.Enabled = btnShow.Enabled = true;
                employeeId = cboEmp.SelectedValue.ToString();
                da = new SqlDataAdapter("SELECT DISTINCT cusID, cusName FROM tbSale WHERE empID='" + employeeId + "'", Operation.con);
                dt = new DataTable();
                da.Fill(dt);
                dt.Rows.Add(000, "អតិថិជនទាំងអស់");

                cboCus.DataSource = cboCus.Text = null;
                cboCus.Items.Clear();
                cboCus.DataSource = dt;
                cboCus.DisplayMember = "cusName";
                cboCus.ValueMember = "cusID";
                customerId = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowInListView(object sender, EventArgs e)
        {
            try
            {

                if (isSelectedCus) customerName = cboCus.Text;

                if (string.IsNullOrEmpty(cboEmp.Text.Trim()))
                {
                    MessageBox.Show("Please choose employee name"); return;
                }
                lswSaleReport.Clear();
                lswSaleReport.View = View.Details;
                
                lswSaleReport.Columns.Add("លេខកូដ", 50);
                lswSaleReport.Columns.Add("ថ្ងៃលក់", 150);
                lswSaleReport.Columns.Add("ឈ្មោះអតិថិជន", 100);
                lswSaleReport.Columns.Add("លេខកូដទំនិញ", 50);
                lswSaleReport.Columns.Add("ឈ្មោះទំនិញ", 150);
                lswSaleReport.Columns.Add("បរិមាណ", 70);
                lswSaleReport.Columns.Add("តម្លៃ", 100);
                lswSaleReport.Columns.Add("តម្លៃសរុប", 100);

                if (dtpStart.Value > dtpStop.Value)
                {
                    error.Clear();
                    error.BlinkRate = 1;
                    error.SetError(dtpStart, "ការបញ្ចូលថ្ងៃចាប់ផ្ដើមមិនត្រឹមត្រូវ!");
                    return;
                }
                else
                {
                    com = new SqlCommand("SaleReport", Operation.con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@EI", employeeId);
                    com.Parameters.AddWithValue("@CI", customerId);
                    com.Parameters.AddWithValue("@SA", dtpStart.Value);
                    com.Parameters.AddWithValue("@SO", dtpStop.Value);
                    com.ExecuteNonQuery();
                    da = new SqlDataAdapter(com);
                    dt = new DataTable();
                    da.Fill(dt);

                    string[] arr = new string[8];
                    ListViewItem item;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow row = dt.Rows[i];
                        arr[0] = string.Format("{0:00000}", row[0].ToString()); //imp id
                        arr[1] = row[1].ToString();//import date
                        arr[2] = row[2].ToString();//supplier name
                        arr[3] = row[3].ToString();//product id
                        arr[4] = row[4].ToString();//product name   
                        arr[5] = row[5].ToString();//qauntity
                        arr[6] = string.Format("{0:c}", decimal.Parse(row[6].ToString()));
                        arr[7] = string.Format("{0:c}", decimal.Parse(row[7].ToString()));

                        item = new ListViewItem(arr);
                        lswSaleReport.Items.Add(item);
                    }
                    lswSaleReport.DefaultListViewStyle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewReport(object sender, EventArgs e)
        {
            try
            {
                if (btnNew.Text == "បន្ថែម")
                {
                    da = new SqlDataAdapter("SELECT empID, empName FROM tbEmployee WHERE pos = 'seller'", Operation.con);
                    dt = new DataTable();
                    da.Fill(dt);
                    cboEmp.DataSource = null;
                    cboEmp.Items.Clear();
                    cboEmp.DataSource = dt;
                    cboEmp.DisplayMember = "empName";
                    cboEmp.ValueMember = "empID";
                    Operation.onOff(this, true);
                    cboCus.Enabled = false;
                    btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";
                    cboEmp.Text = null;
                    Operation.fillCbo(cboCus, "cusName", "cusID", "tbCustomer");
                }
                else
                {
                    lswSaleReport.Clear();
                    Operation.clearData(this);
                    Operation.onOff(this, false);
                    btnNew.Text = "បន្ថែម";
                    btnNew.Image = SaleInventory.Properties.Resources._new;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmSaleReport_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }
    }
}
