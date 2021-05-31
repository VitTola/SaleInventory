using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace SaleInventory
{
    public partial class frmRptSale : Form
    {
        public frmRptSale()
        {
            InitializeComponent();
        }

        private void frmRptSale_Load(object sender, EventArgs e)
        {
            VSale.SetDisplayMode(DisplayMode.PrintLayout);
            VSale.ZoomMode = ZoomMode.Percent;
            VSale.ZoomPercent = 100;
        }
    }
}
