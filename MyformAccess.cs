using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class MyformAccess
    {

        public bool ActivateMyButton(Control.ControlCollection collection)
        {
            foreach (Control control in collection)

            {
                

                if (control is TextBox && control.Enabled)
                {
                    if (string.IsNullOrEmpty(((TextBox)control).Text))
                        return false;
                }

                if (control.HasChildren)
                {
                    ActivateMyButton(control.Controls);
                }

            }
            return true;// this activates the button
        }
    }
}
