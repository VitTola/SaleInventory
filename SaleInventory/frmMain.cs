
//           +********************+
//           *  DISIGN BY MR TOLA *
//           **********************
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SaleInventory
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
            this.MinimizeBox = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FormClosed += (o, fe) => Application.Exit();
            this.WindowState = FormWindowState.Maximized;
            this.Athorization();
            timer1.Tick += (o, te) => { lblTime.Text = DateTime.Now.ToLongTimeString(); };
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblUser.Text = Operation.EmpName;
            btnEmployee.Click += (o, ee) => { new frmEmployee().ShowDialog(); };
            btnSup.Click += (o, se) => { new frmSupplier().ShowDialog(); };
            btnPro.Click += (o, pe) => { new frmProduct().ShowDialog(); };
            btnSale.Click += (o, se) => { new frmSale().ShowDialog(); };
            btnSaleRe.Click += (o, se) => { new frmSaleReport().ShowDialog(); };
            btnImp.Click += (o, se) => { new frmImport().ShowDialog(); };
            btnImpRe.Click += (o, ie) => { new frmImportReport().ShowDialog(); };
            btnAccSetting.Click += (o, se) => { new frmCreateAccount().ShowDialog(); };
            btnCus.Click += (o, ce) => { new frmCustomer().ShowDialog(); };
            btnLogOut.Click += (o, le) => { this.Hide(); new frmLogin().Show(); };
            btnCate.Click += (o, ce) => { new frmCategory().ShowDialog(); };
        }

        private void Athorization()
        {
            if (Operation.EmpPos == "admin" && Operation.EmpID != "0")
            {
                return;
            }
            else if (Operation.EmpPos == "seller")
            {
                btnImp.Enabled = btnImpRe.Enabled = btnEmployee.Enabled = btnSup.Enabled = btnPro.Enabled =
                    btnCate.Enabled = false;
            }
            else if (Operation.EmpPos == "stockman")
            {
                btnEmployee.Enabled = btnCus.Enabled = btnSale.Enabled = btnSaleRe.Enabled = false;
            }
            else
            {
                btnImp.Enabled = btnImpRe.Enabled = btnSup.Enabled = btnPro.Enabled = btnCate.Enabled =
                    btnCus.Enabled = btnSale.Enabled = btnSaleRe.Enabled = false;
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
