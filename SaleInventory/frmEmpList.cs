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
    public partial class frmEmpList : Form
    {
        public frmEmpList()
        {
            InitializeComponent();
        }

        private void frmEmpList_Load(object sender, EventArgs e)
        {
            VemList.SetDisplayMode (DisplayMode.PrintLayout);
            VemList.ZoomMode = ZoomMode.Percent;
            VemList.ZoomPercent = 100;
        }
    }
}
