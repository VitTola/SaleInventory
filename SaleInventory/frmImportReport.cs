using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
namespace SaleInventory
{
    public partial class frmImportReport : Form
    {
        public frmImportReport()
        {
            InitializeComponent();
        }

        private SqlDataAdapter da;
        private SqlCommand com;
        private DataTable dt;
        private string employeeID = null;
        private string customerID = "0";
        private int supplierID = 0 ;
        private string supplierName= "អ្នកផ្គត់ផ្គង់ទាំងអស់";
        private bool selectCboSup = false;
        private ErrorProvider error = new ErrorProvider();

        private void frmImportReport_Load(object sender, System.EventArgs e)
        {
            panelBar1.Text = "របាយការណ៍នាំចូល";
            Operation.connection();
            Operation.onOff(this, false);
            Operation.fillCbo(cboEmp, "empName", "empID", "tbEmployee");

            cboSup.SelectionChangeCommitted += (o, se) =>
            {
                selectCboSup = true;
                supplierID = int.Parse(cboSup.SelectedValue.ToString());
            };
            btnNew.Click += NewReport;
            cboEmp.SelectionChangeCommitted += comboEmpSelect;
            btnShow.Click += ShowInListView;
            btnPreview.Click += PreviewReport;
        }

        private void PreviewReport(object sender, EventArgs e)
        {
            try
            {
                if (selectCboSup == true) supplierName = cboSup.Text;

                frmRtpImport rptImp = new frmRtpImport();
                //rptImp.VImp.ProcessingMode = ProcessingMode.Local;
                LocalReport lRpt = rptImp.VImp.LocalReport;
                //lRpt.DisplayName = "rptImport.rdlc";
                lRpt.DataSources.Clear();

                DataTable dtImp = new DataTable();
                dtImp.Columns.Add("impID", typeof(string));
                dtImp.Columns.Add("impDate", typeof(string));
                dtImp.Columns.Add("supID", typeof(string));
                dtImp.Columns.Add("proID", typeof(string));
                dtImp.Columns.Add("proName", typeof(string));
                dtImp.Columns.Add("qty", typeof(string));
                dtImp.Columns.Add("price", typeof(string));
                dtImp.Columns.Add("amount", typeof(string));

                decimal t = 0;
                foreach (ListViewItem item in lswImpReport.Items)
                {
                    string impid = item.Text;
                    string sdate = string.Format("{0:dd-MM-yyyy}", item.SubItems[1].Text);
                    string sup = item.SubItems[2].Text;
                    string pid = item.SubItems[3].Text;
                    string pn = item.SubItems[4].Text;
                    string q = item.SubItems[5].Text;
                    string pr = item.SubItems[6].Text;
                    string am = item.SubItems[7].Text;
                    t = t + decimal.Parse(item.SubItems[7].Text, NumberStyles.Currency);
                    dtImp.Rows.Add(impid, sdate, sup, pid, pn, q, pr, am);
                }

                ReportDataSource ds = new ReportDataSource("dsRptImport", dtImp);
                lRpt.DataSources.Add(ds);
                ReportParameter p1 = new ReportParameter("empID", employeeID);
                lRpt.SetParameters(p1);
                ReportParameter p2 = new ReportParameter("empName", cboEmp.Text);
                lRpt.SetParameters(p2);
                ReportParameter p3 = new ReportParameter("supName", supplierName);
                lRpt.SetParameters(p3);
                ReportParameter p4 = new ReportParameter("begin", dtpStart.Value.ToString("dd/MM/yyyy"));
                lRpt.SetParameters(p4);
                ReportParameter p5 = new ReportParameter("end", dtpStop.Value.ToString("dd/MM/yyyy"));
                lRpt.SetParameters(p5);
                ReportParameter p6 = new ReportParameter("total", string.Format("{0:c}", t, ToString()));
                lRpt.SetParameters(p6);

                rptImp.Show();
                rptImp.VImp.RefreshReport();
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
                if (!string.IsNullOrEmpty(cboSup.Text.Trim())) supplierID = int.Parse(cboSup.SelectedValue.ToString());

                lswImpReport.Clear();
                lswImpReport.View = View.Details;

                lswImpReport.Columns.Add("លេខ.ចូល", 80);
                lswImpReport.Columns.Add("ថ្ងៃនាំចូល", 170);
                lswImpReport.Columns.Add("ប្រភពផ្គត់ផ្គង់", 140);
                lswImpReport.Columns.Add("លេខ.ទំនិញ", 100);
                lswImpReport.Columns.Add("ឈ្មោះទំនិញ", 150);
                lswImpReport.Columns.Add("បរិមាណ", 70);
                lswImpReport.Columns.Add("តម្លៃ", 100);
                lswImpReport.Columns.Add("តម្លៃសរុប", 100);

                if (dtpStart.Value > dtpStop.Value)
                {
                    error.Clear();
                    error.BlinkRate = 1;
                    error.SetError(dtpStart, "ថ្ងៃចាប់ផ្ដើមមិនអាតូចជាងថ្ងៃដល់!");
                    return;
                }
                else
                {
                    com = new SqlCommand("ImportReport", Operation.con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@EI", employeeID);
                    com.Parameters.AddWithValue("@SI", int.Parse(supplierID.ToString()));
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
                        lswImpReport.Items.Add(item);
                    }
                    lswImpReport.DefaultListViewStyle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboEmpSelect(object sender, EventArgs e)
        {
            try
            {
                cboSup.Enabled = btnShow.Enabled = true;
                employeeID = cboEmp.SelectedValue.ToString();
                da = new SqlDataAdapter("SELECT DISTINCT supID, supName FROM tbImport WHERE empID='" + employeeID + "'", Operation.con);
                dt = new DataTable();
                da.Fill(dt);
                dt.Rows.Add(000, "អ្នកផ្គត់ផ្គង់ទាំងអស់");
                cboSup.DataSource = cboSup.Text = null;
                cboSup.Items.Clear();
                cboSup.DataSource = dt;
                cboSup.DisplayMember = "supName";
                cboSup.ValueMember = "supID";
                customerID = "0";
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
                    da = new SqlDataAdapter("SELECT empID, empName FROM tbEmployee WHERE pos = 'stockman'", Operation.con);
                    dt = new DataTable();
                    da.Fill(dt);
                    cboEmp.DataSource = cboEmp.Text = null;
                    cboEmp.Items.Clear();
                    cboEmp.DataSource = dt;
                    cboEmp.DisplayMember = "empName";
                    cboEmp.ValueMember = "empID";
                    Operation.onOff(this, true);
                    cboSup.Enabled = false;
                    btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";
                    Operation.fillCbo(cboSup, "supName", "supID", "tbSupplier");
                    cboEmp.Text = "";
                }
                else
                {

                    lswImpReport.Clear();
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

        private void frmImportReport_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }
    }
}
