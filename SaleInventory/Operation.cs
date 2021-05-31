using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SaleInventory
{
    class Operation
    {
        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static DataTable dt;

        public static string EmpID;
        public static string EmpName;
        public static string EmpPos;

        //Connection to database
        public static void connection()
        {
            string connection = ConfigurationManager.
            ConnectionStrings["SaleInventory.Properties.Settings.TestProjectConnectionString"].ConnectionString;
            con = new SqlConnection(connection);
            con.Open();
        }

        //Turn controls on or off
        public static void onOff(Form f, bool state)
        {
            foreach (Control c in f.Controls)
            {
                if (!(c is Label))
                    if (c.Tag == null)
                    {
                        c.Enabled = state;
                    }
            }
        }


        //Clear control's text
        public static void clearData(Form f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is TextBox || c is ComboBox || c is MaskedTextBox)
                {
                    if (c.Tag == null)
                        c.Text = null;
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).CustomFormat = DateTime.Now.ToString("dd/MM/yyyy");
                }
                if (c is PictureBox && c.Tag == null)
                {
                    ((PictureBox)c).Image = null;
                }
            }
        }

        //Select next control
        public static void nextControl(Form f, object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                f.SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                f.SelectNextControl((Control)sender, false, true, true, true);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //CONVERT STRING TO CURRENCY
        public static void conStrToCur(TextBox txt, object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text) || !string.IsNullOrWhiteSpace(txt.Text))
                txt.Text = string.Format("{0:C}", decimal.Parse(txt.Text));
        }


        //INPUT CURRENCY IN TEXTBOX(This func execute simultaneously the key is pressing)
        public static void validCurrency(TextBox txt, object sender, KeyPressEventArgs e)
        {
            decimal x;
            char ch = e.KeyChar;
            if (ch == (char)8)    //Backspace
                e.Handled = false;//Remember think "Handled" like barrier to stop any unexpected charactor
            else if (!char.IsDigit(ch) && ch != '.' || !decimal.TryParse(txt.Text + ch, out x))
                e.Handled = true;
        }



        //CONVERT CURRENCY TO NUMBER
        public static void conCurToNumber(TextBox txt, object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt.Text) || !string.IsNullOrWhiteSpace(txt.Text))
            {
                var s = decimal.Parse(txt.Text, NumberStyles.Currency);
                txt.Text = s.ToString();
            }
        }


        //FILL DATA INTO COMBOBOX
        public static void fillCbo(ComboBox cbo, string fd1, string fd2, string tb)
        {
            da = new SqlDataAdapter("SELECT " + fd1 + "," + fd2 + " FROM " + tb + "", con);
            dt = new DataTable();
            da.Fill(dt);

            cbo.DataSource = null;
            cbo.Items.Clear();

            cbo.DataSource = dt;
            cbo.DisplayMember = fd1;
            cbo.ValueMember = fd2;
            cbo.Text = null;

        }
    }


    public static class Extension
    {
        public static void DefaultGirdStyle(this DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.WhiteSmoke };
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(173, 205, 239);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Kh Siemreap", 11, FontStyle.Regular);
        }

        public static void DefaultListViewStyle(this ListView listview)
        {
            foreach (ListViewItem list in listview.Items) list.BackColor = list.Index % 2 == 0 ? Color.WhiteSmoke : Color.White;
            listview.ItemCheck += (o, e) =>
            {
                listview.FullRowSelect = true;
                if (listview.Items[e.Index].Checked == false)
                {
                    listview.Items[e.Index].BackColor = Color.Gray;
                }
                else
                {
                    listview.Items[e.Index].BackColor = Color.White;
                }
            };
        }

    }
}
