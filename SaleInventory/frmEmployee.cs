using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace SaleInventory
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private SqlCommand com;
        private SqlDataAdapter sda;
        private DataTable dt;
        private string filePath = null;
        private byte[] photo;
        private bool isAddNew = false;
        private bool print = false;
        private bool isValidInput = true;
        private ErrorProvider error = new ErrorProvider();
        private List<byte[]> images = new List<byte[]>();

        private void loadData()
        {
            try
            {
                sda = new SqlDataAdapter("select ID as 'លេខកូដ', Name as 'ឈ្មោះ',Gender as 'ភេទ', DateOfBirth as 'កើត', Position as 'តួនាទី', Salary as 'ប្រាក់ខែ'," +
                    " Address as 'អស័យដ្ធាន', Contact as 'ទូរស័ព្ទ', " + "hiredDate as 'ចូលធ្វើការ', Photo as 'រូបថត' from dbo.GetEmployee()", Operation.con);
                dt = new DataTable();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    images.Add((byte[])dt.Rows[i]["រូបថត"]);
                }
                dt.Columns.Remove("រូបថត");
                dt.Columns.Add("រូបថត", typeof(string));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["រូបថត"] = "រូបថត";
                }

                dgvEmp.DataSource = dt;
                dgvEmp.Columns["ប្រាក់ខែ"].DefaultCellStyle.Format = "c";
                dgvEmp.Columns["កើត"].DefaultCellStyle.Format = "dd-MM-yyyy";
                dgvEmp.Columns["ចូលធ្វើការ"].DefaultCellStyle.Format = "dd-MM-yyyy";

                dgvEmp.ClearSelection();
                dgvEmp.DefaultGirdStyle();

                dt.Dispose();
                sda.Dispose();
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
                com.Parameters.AddWithValue("@empID", txtID.Text);
                com.Parameters.AddWithValue("@empName", txtName.Text);
                com.Parameters.AddWithValue("@empgen", rdoF.Checked ? "F" : "M");
                com.Parameters.AddWithValue("@dob", dtpDOB.Value);
                com.Parameters.AddWithValue("@pos", cboPos.Text);
                com.Parameters.AddWithValue("@salary", txtSal.Text);
                com.Parameters.AddWithValue("@address", txtAddress.Text);
                com.Parameters.AddWithValue("@empContact", txtPhone.Text);
                com.Parameters.AddWithValue("@hired", dtpHire.Value);

                com.Parameters.AddWithValue("@photo", filePath != null ? File.ReadAllBytes(filePath) : photo);
                com.ExecuteNonQuery();
                loadData();
                filePath = null;
                Operation.clearData(this);
                Operation.onOff(this, false);
                btnNew.Text = "បន្ថែម";
                btnNew.Image = SaleInventory.Properties.Resources._new;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void frmEmployee_Load(object sender, EventArgs ee)
        {
            try
            {
                panelBar1.Text = "បុគ្គលិក";
                dgvEmp.SelectionChanged += (o, e) => dgvEmp.DefaultCellStyle.SelectionBackColor = Color.Gray;
                lblEmpReport.MouseHover += (o, e) => { lblEmpReport.Font = new Font(lblEmpReport.Font, FontStyle.Underline); };
                lblEmpReport.MouseLeave += (o, e) => { lblEmpReport.Font = new Font(lblEmpReport.Font, FontStyle.Regular); };
                lblEmpReport.Click += ViewReport;
                txtSal.Enter += (o, e) => { if (!string.IsNullOrEmpty(txtSal.Text.Trim())) txtSal.Text = decimal.Parse(txtSal.Text, NumberStyles.Currency).ToString(); };
                txtSal.Leave += (o, e) => { if (!string.IsNullOrEmpty(txtSal.Text.Trim())) txtSal.Text = string.Format("{0:c}", decimal.Parse(txtSal.Text)); };
                txtSal.KeyPress += (o, e) => { Operation.validCurrency(txtSal, sender, e); };
                txtSearch.Leave += (o, e) => { txtSearch.Text = "ស្វែងរកបុក្គលិក......."; txtSearch.ForeColor = Color.Silver; };
                txtSearch.Enter += (o, e) => { txtSearch.Text = null; txtSearch.ForeColor = Color.Black; };
                btnNew.Click += NewEmployee;
                dgvEmp.CellClick += dgvEmpCellClick;
                btnSave.Click += SaveEmployee;
                btnDelete.Click += DeleteEmployee;
                txtSearch.KeyUp += SearchEmployee;
                dgvEmp.CellContentClick += openImageInPhotoViewer;
                dtpDOB.ValueChanged += (o, e) => { dtpDOB.CustomFormat = "dd/MM/yyyy"; dtpHire.CustomFormat = "dd/MM/yyyy"; };
                btnImage.Click += (o, e) =>
                {
                    OpenFileDialog fd = new OpenFileDialog();
                    fd.Filter = "JPEG FILE | *.jpg; *.jpeg; | PNG FILE | *.png"; //This line optional
                    fd.Title = "Open an image...";        //This line optional
                    pictureBoxEmp.Image = fd.ShowDialog() == DialogResult.OK ? Image.FromFile(filePath = fd.FileName) : null;
                };
                btnEdit.Click += (o, e) =>
                {
                    Operation.onOff(this, true);
                    txtID.Focus();
                    btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";
                    isAddNew = btnEdit.Enabled = btnDelete.Enabled = btnDelete.Enabled = false;
                };

                Operation.connection();
                loadData();
                Operation.onOff(this, false);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            dgvEmp.DefaultGirdStyle();
        }

        private void openImageInPhotoViewer(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == this.dgvEmp.Columns["រូបថត"].Index)
                {
                    string filePath = @"C:\Users\vitto\Desktop\SaleInventoryWtihMicro V4.0\imag.jpg";
                    File.Delete(filePath);

                    var ms = new MemoryStream((byte[])images[dgvEmp.SelectedRows[0].Index]);
                    Image image = Image.FromStream(ms);
                    image.Save(filePath);

                    Process photoViewer = new Process();
                    photoViewer.StartInfo.FileName = filePath;
                    photoViewer.StartInfo.Arguments = filePath;
                    photoViewer.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewReport(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("តើអ្នកចងមើលបុគ្គលិកទាំងអស់ដែរឬទេ?", "បុគ្គលិក", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    DataTable dtEmplist = new DataTable();
                    dtEmplist.Columns.Add("empID", typeof(string));
                    dtEmplist.Columns.Add("empName", typeof(string));
                    dtEmplist.Columns.Add("empGen", typeof(string));
                    dtEmplist.Columns.Add("empDob", typeof(DateTime));
                    dtEmplist.Columns.Add("empPos", typeof(string));
                    dtEmplist.Columns.Add("empSal", typeof(string));
                    dtEmplist.Columns.Add("empAdd", typeof(string));
                    dtEmplist.Columns.Add("empCon", typeof(string));
                    dtEmplist.Columns.Add("empHire", typeof(DateTime));
                    dtEmplist.Columns.Add("empPhoto", typeof(byte[]));

                    int imgIndex = 0;
                    foreach (DataGridViewRow r in dgvEmp.Rows)
                    {
                        string sal = string.Format("{0:c}",decimal.Parse( r.Cells[5].Value.ToString()));
                        dtEmplist.Rows.Add(r.Cells[0].Value, r.Cells[1].Value, r.Cells[2].Value, r.Cells[3].Value,
                            r.Cells[4].Value, sal, r.Cells[6].Value, r.Cells[7].Value, r.Cells[8].Value, images[imgIndex++]);
                    }

                    frmEmpList list = new frmEmpList();
                    list.VemList.ProcessingMode = ProcessingMode.Local;
                    LocalReport report = list.VemList.LocalReport;
                    report.DisplayName = "rptEmpList.rdlc";

                    ReportDataSource rds = new ReportDataSource("dsEmployee", dtEmplist);
                    report.DataSources.Clear();
                    report.DataSources.Add(rds);
                    list.Show();
                    list.VemList.Refresh();
                    return;
                }
                else
                {
                    if (print == true)
                    {
                        frmRptEmp rEmp = new frmRptEmp();
                        rEmp.Vemp.ProcessingMode = ProcessingMode.Local;
                        LocalReport lRpt = rEmp.Vemp.LocalReport;
                        lRpt.DisplayName = "rptEmps.rdlc";

                        ReportParameter p1 = new ReportParameter("eid", txtID.Text);
                        rEmp.Vemp.LocalReport.SetParameters(p1);
                        ReportParameter p2 = new ReportParameter("ename", txtName.Text);
                        rEmp.Vemp.LocalReport.SetParameters(p2);
                        ReportParameter p3 = new ReportParameter("egen", rdoF.Checked == true ? "F" : "M");
                        rEmp.Vemp.LocalReport.SetParameters(p3);
                        ReportParameter p4 = new ReportParameter("edob", dtpDOB.Value.ToString("dd/MM/yyyy"));
                        rEmp.Vemp.LocalReport.SetParameters(p4);
                        ReportParameter p5 = new ReportParameter("epos", cboPos.Text);
                        rEmp.Vemp.LocalReport.SetParameters(p5);
                        ReportParameter p6 = new ReportParameter("esal", string.Format("{0:c}", decimal.Parse(txtSal.Text)));
                        rEmp.Vemp.LocalReport.SetParameters(p6);
                        ReportParameter p7 = new ReportParameter("ehire", dtpHire.Value.ToString("dd/MM/yyyy"));
                        rEmp.Vemp.LocalReport.SetParameters(p7);
                        var byteFromStr = Convert.ToBase64String(images[dgvEmp.SelectedRows[0].Index]);
                        ReportParameter p8 = new ReportParameter("photo", byteFromStr);
                        rEmp.Vemp.LocalReport.SetParameters(p8);
                        rEmp.Show();
                        rEmp.Vemp.RefreshReport();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            MessageBox.Show("សូមជ្រើសរើសលើបុក្គលិកណាមួយសិនមុននឹងចុចមើលរបាយណ៏ការ!");
        }

        private void DeleteEmployee(object sender, EventArgs e)
        {
            if ((MessageBox.Show("តើអ្នកពិតជាចង់លុបអតិថិជននេះមែនឬទេ?", "លុប", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                com = new SqlCommand("DeleteEmployee", Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@id", txtID.Text);
                com.ExecuteNonQuery();
                loadData();
                Operation.onOff(this, false);
                Operation.clearData(this);
            }
        }

        private void SearchEmployee(object sender, KeyEventArgs e)
        {
            try
            {
                com = new SqlCommand("SearchEmployeeByName", Operation.con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@empName", txtSearch.Text);
                sda = new SqlDataAdapter(com);
                dt = new DataTable();
                sda.Fill(dt);
                dgvEmp.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    com = new SqlCommand("SearchEmployeeByID", Operation.con);
                    com.CommandType = CommandType.StoredProcedure;
                    com.Parameters.AddWithValue("@id", txtSearch.Text);
                    sda = new SqlDataAdapter(com);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dgvEmp.DataSource = dt;
                }
                string[] columnNames = { "លេខកូដ", "ឈ្មោះ", "ភេទ", "កើត", "តួនាទី", "ប្រាក់ខែ", "អស័យដ្ធាន", "អស័យដ្ធាន", "ទូរស័ព្ទ", "ចូលធ្វើការ", "រូបថត"};
                for (int i = 0; i < dgvEmp.ColumnCount; i++) dgvEmp.Columns[i].HeaderText = columnNames[i];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void SaveEmployee(object sender, EventArgs e)
        {
            isValidInput = true;
            error.Clear();
            error.BlinkRate = 1;
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                error.SetError(txtID, "សូមបញ្ជូលអត្តលេខអតិថិជន!");
                txtID.Focus();
                isValidInput = false;
            }

            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                error.SetError(txtName, "សូមបញ្ចូលឈ្មោះអតិថិជន!");
                txtName.Focus();
            }

            if (rdoF.Checked == false && rdoM.Checked == false)
            {
                error.SetError(rdoF, "សូមជ្រើសរើសភេទ!");
                isValidInput = false;
            }

            if (dtpDOB.Value.Year > 1995)
            {
                error.SetError(dtpDOB, "សូមពិនិត្រមើថ្ងៃខែឆ្នាកំណើតឡើងវិញ!");
                dtpDOB.Focus();
                SendKeys.Send("%{DOWN}");
                isValidInput = false;

            }

            if (string.IsNullOrEmpty(cboPos.Text.Trim()))
            {
                error.SetError(cboPos, "សូមជ្រើសរើសតួនាទីអតិថិជន!");
                cboPos.Focus();
                isValidInput = false;
            }

            if (string.IsNullOrEmpty(txtSal.Text.Trim()))
            {
                error.SetError(txtSal, "សូមបញ្ជូលប្រាក់ខែរបស់អតិថិជន!");
                txtSal.Focus();
                isValidInput = false;

            }

            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                error.SetError(txtAddress, "សូមបញ្ជូលអស័យដ្ធានអតិថិជន!");
                txtAddress.Focus();
                isValidInput = false;
            }


            if (dtpHire.Value.Date > DateTime.Now)
            {
                error.SetError(dtpHire, "សូមពិនិត្រមើលថ្ងៃចូលធ្វើការឡើងវិញ!");
                dtpHire.Focus();
                SendKeys.Send("%{DOWN}");
                isValidInput = false;

            }

            if (string.IsNullOrEmpty(txtPhone.Text.Trim()))
            {
                error.SetError(txtPhone, "សូមបញ្ជូលលេខទូរស័ព្ទរបស់អតិថិជន!");
                txtPhone.Focus();
                isValidInput = false;
            }

            if (pictureBoxEmp.Image == null)
            {
                error.SetError(btnImage, "សូមជ្រើសរើសរូបថតអតិថិជន!");
                isValidInput = false;

            }
            if (isValidInput)modify(isAddNew == true ? "InsertEmployee" : "UpdateEmployee");
        }

        private void dgvEmpCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i < 0 || btnNew.Text == "មោឃៈ" && btnSave.Enabled == true) return;

            if (dgvEmp.RowCount > 0)
            {
                print = true;
                DataGridViewRow r = dgvEmp.Rows[i];
                txtID.Text = r.Cells[0].Value.ToString();
                txtName.Text = r.Cells[1].Value.ToString();
                string trimGender = r.Cells[2].Value.ToString().Trim();
                if (trimGender == "F") rdoF.Checked = true; else rdoM.Checked = true;
                dtpDOB.Text = r.Cells[3].Value.ToString();
                cboPos.Text = r.Cells[4].Value.ToString();
                txtSal.Text = r.Cells[5].Value.ToString();
                txtAddress.Text = r.Cells[6].Value.ToString();
                txtPhone.Text = r.Cells[7].Value.ToString();
                dtpHire.Text = r.Cells[8].Value.ToString();

                photo = images[dgvEmp.SelectedRows[0].Index];
                MemoryStream ms = new MemoryStream(photo);
                pictureBoxEmp.Image = Image.FromStream(ms);
                btnEdit.Enabled = btnDelete.Enabled = true;
            }
        }

        private void NewEmployee(object sender, EventArgs e)
        {
            if (btnNew.Text == "បន្ថែម")
            {
                isAddNew = true;
                Operation.onOff(this, true);
                txtID.Focus();
                btnEdit.Enabled = btnDelete.Enabled = false;
                btnNew.Image = SaleInventory.Properties.Resources.cancel; btnNew.Text = "មោឃៈ";
                //Add data to 
                cboPos.Items.Add("seller");
                cboPos.Items.Add("stockman");
            }
            else
            {
                Operation.clearData(this);
                Operation.onOff(this, false);
                btnNew.Text = "បន្ថែម";
                btnNew.Image = SaleInventory.Properties.Resources._new;
            }
        }

        private void frmEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            Operation.nextControl(this, sender, e);
        }


    }
}
