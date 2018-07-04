using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegApplication
{
    class Helper
    {
        public static void clearTextBoxes(Control.ControlCollection form)
        {
            foreach (Control item in form)
            {
                if (item is TextBox || item is ComboBox)
                    item.ResetText();
                if (item is GroupBox)
                    clearTextBoxes(item.Controls);
            }

        }
    }
}
