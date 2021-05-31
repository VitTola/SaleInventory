using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleInventory
{
    public partial class frmRptEmp : Form
    {
        public frmRptEmp()
        {
            InitializeComponent();
        }

        private void frmRptEmp_Load(object sender, EventArgs e)
        {
            Vemp.SetDisplayMode(DisplayMode.PrintLayout);
            Vemp.ZoomMode = ZoomMode.Percent;
            Vemp.ZoomPercent = 100;
        }
    }
}
