using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleInventory.Helpers
{
    public static class ControlExt
    {
        public static IEnumerable<Control> GetAllControls(this Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                yield return control;
                foreach (Control descendant in control.GetAllControls())
                {
                    yield return descendant;
                }
            }
        }
        public static void SetEnabled(this Control panel, bool enabled)
        {
            foreach (Control c in panel.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.ReadOnly = !enabled;
                }
                else if (c is DataGridView dgv)
                {
                    dgv.ReadOnly = !enabled;
                }
                else if (c is ComboBox ||
                   c is DateTimePicker ||
                   c is CheckBox ||
                   c is LinkLabel)
                {
                    c.Enabled = enabled;
                }
                else
                {
                    if (c.Controls.Count > 0)
                    {
                        SetEnabled(c, enabled);
                    }
                }
            }
        }
        public static void DefaultEnglishInputControls(this Control panel)
        {
            var allControls = panel.GetAllControls();
            foreach (var ctrl in allControls)
            {
                if (ctrl is DateTimePicker)
                {
                    ctrl.RegisterEnglishInput();
                }
            }
        }
        public static void RegisterPrimaryInput(this Control control)
        {
            control.Enter += (object send, EventArgs e) =>
            {
                InputLanguage.CurrentInputLanguage = UI.Primary;
                if (control is TextBox txt)
                {
                    if (!txt.Multiline)
                    {
                        txt.SelectAll();
                    }
                }
            };
        }
        public static void RegisterPrimaryInputWith(this Control control, params Control[] controls)
        {
            control.RegisterPrimaryInput();
            foreach (var ctl in controls)
            {
                ctl.RegisterPrimaryInput();
            }
        }
        public static void RegisterEnglishInput(this Control control)
        {
            control.Enter += (object send, EventArgs e) =>
            {
                InputLanguage.CurrentInputLanguage = UI.English;
                if (control is TextBox txt)
                {
                    txt.SelectAll();
                }
            };
        }
        public static void RegisterEnglishInputWith(this Control control, params Control[] controls)
        {
            control.RegisterEnglishInput();
            foreach (var ctl in controls)
            {
                ctl.RegisterEnglishInput();
            }
        }
        public static void RegisterEnglishInputColumns(this DataGridView dgv, params DataGridViewColumn[] columns)
        {
            var index = dgv.Columns.OfType<DataGridViewColumn>()
                .Where(x => columns.Any(c => c.Name == x.Name))
                .Select(x => x.Index);
            dgv.CellBeginEdit += (s, e) =>
            {
                if (index.Contains(e.ColumnIndex))
                {
                    InputLanguage.CurrentInputLanguage = UI.English;
                }
            };
        }
        public static void RegisterPrimaryInputColumns(this DataGridView dgv, params DataGridViewColumn[] columns)
        {
            var index = dgv.Columns.OfType<DataGridViewColumn>()
                .Where(x => columns.Any(c => c.Name == x.Name))
                .Select(x => x.Index);
            dgv.CellBeginEdit += (s, e) =>
            {
                if (index.Contains(e.ColumnIndex))
                {
                    InputLanguage.CurrentInputLanguage = UI.Primary;
                }
            };
        }
        public static void RegisterKeyEnterNextControl(this Control control)
        {
            control.KeyDown += (object sender, KeyEventArgs e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (e.Modifiers == Keys.Control)
                    {
                        return;
                    }

                    if (control is TextBox txt)
                    {
                        if (txt.Multiline)
                        {
                            e.SuppressKeyPress = true;
                        }
                    }
                    control.Parent.SelectNextControl(control, true, true, true, true);
                }
            };
        }
        public static void RegisterKeyEnterNextControlWith(this Control control, params Control[] controls)
        {
            control.RegisterKeyEnterNextControl();
            foreach (var ctl in controls)
            {
                ctl.RegisterKeyEnterNextControl();
            }
        }

        public static void RegisterKeyArrowDown(this Control control, Control nextControl)
        {
            control.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Down)
                {
                    nextControl.Focus();
                }
            };
            nextControl.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (sender is DataGridView dgv)
                    {
                        if (dgv.SelectedRows.Count == 0)
                        {
                            return;
                        }

                        if (dgv.SelectedRows[0].Index == 0)
                        {
                            control.Focus();
                        }
                    }
                }
            };
        }
      
        public static void RegisterInputPhone(this Control control)
        {
            control.KeyPress += (sender, e) =>
            {
                if (Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
                {
                    e.Handled = true;
                }
                else if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar.ToString() != "/"
                    && e.KeyChar.ToString() != "+"
                    && e.KeyChar.ToString() != "-"
                    && e.KeyChar.ToString() != " ")
                {
                    e.Handled = true;
                }
            };
        }

        public static void RegisterInputNumberOnly(this Control control)
        {
            control.KeyPress += (s, e) =>
            {
                if (Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
                {
                    e.Handled = true;
                }
                else if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar.ToString().ToUpper() != "K"
                    && e.KeyChar.ToString().ToUpper() != "M")
                {
                    e.Handled = true;
                }
            };
            control.TextChanged += (s, e) => control.Text = control.Text.ToUpper().Replace("K", "000").Replace("M", "000000");
        }

        public static void RegisterInputNumberOnlyWith(this Control control, params Control[] controls)
        {
            control.RegisterInputNumberOnly();
            foreach (Control ctl in controls)
            {
                ctl.RegisterInputNumberOnly();
            }
        }

        public static void InputDecimalOnly(this Control control)
        {
            control.KeyPress += (s, e) =>
            {
                if (Encoding.UTF8.GetByteCount(new char[] { e.KeyChar }) > 1)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == '.' && control.Text.Contains("."))
                {
                    // Stop more than one dot Char
                    e.Handled = true;
                }
                else if (e.KeyChar == '.' && control.Text.Length == 0)
                {
                    // Stop first char as a dot input
                    e.Handled = true;
                }
                else if (e.KeyChar == '-' && control.Text.Contains("-"))
                {
                    // Stop first char as negative
                    e.Handled = true;
                }
                else if (!char.IsControl(e.KeyChar) &&
                        !char.IsDigit(e.KeyChar) &&
                        e.KeyChar != '.' &&
                        e.KeyChar != '-')
                {
                    // Stop allow other than digit and control
                    e.Handled = true;
                }
              
            };
        }

        //public static void RegisterDecimalSeparater(this TextBox control)
        //{
        //    control.MaxLength = 30;
        //    control.InputDecimalOnly();
        //    var byUser = false;
        //    var seletionStart = 0;
        //    control.KeyDown += (s, e) =>
        //    {
        //        seletionStart = control.TextLength - control.SelectionStart;
        //        if (e.KeyCode == Keys.Delete)
        //        {
        //            seletionStart--;
        //        }
        //        if (control.SelectionLength > 0)
        //        {
        //            seletionStart -= control.SelectionLength;
        //            //seletionStart -= control.Text.Count(x => x == ',');
        //        }
        //        var dotIndex = control.Text.IndexOf(".");
        //        try
        //        {
        //            if (e.KeyCode == Keys.Back && control.SelectionStart < control.TextLength - 1
        //                && control.Text[control.SelectionStart - 1] == ',')
        //            {
        //                seletionStart++;
        //            }
        //        }
        //        catch (Exception) { }
        //        byUser = !(e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal || dotIndex > seletionStart);
        //    };
        //    control.TextChanged += (s, e) =>
        //    {
        //        if (control.Text.StartsWith(","))
        //        {
        //            control.Text = control.Text.Replace(",", "");
        //        }
        //        if (control.Text.ToUpper().Contains("M") || control.Text.ToUpper().Contains("K"))
        //        {
        //            control.Text = control.Text.ToUpper().Replace("K", "000").Replace("M", "000000");
        //        }
        //        if (byUser)
        //        {
        //            byUser = false;
        //            if (control.Text == "-0" || control.Text == "0-")
        //            {
        //                control.Text = "-";
        //            }

        //            if (control.Text != "-")
        //            {
        //                var value = Parse.ToDecimal(control.Text);
        //                control.Text = value.ToString(FormatHelper.Decimal[FormatHelper.DecimalType.N7]);
        //            }
        //        }
        //        try
        //        {
        //            control.SelectionStart = control.TextLength - seletionStart;
        //        }
        //        catch (Exception) { }
        //    };
        //}

    }

}
