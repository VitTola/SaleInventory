using System;
using System.Windows.Forms;

namespace SaleInventory
{
    public partial class frmRtpImport : Form
    {
        public frmRtpImport()
        {
            InitializeComponent();
        }

        private void frmRtpImport_Load(object sender, EventArgs e)
        {
            VImp.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            VImp.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            VImp.ZoomPercent = 100;
        }
    }
}
