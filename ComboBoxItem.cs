using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject
{
    public class ComboBoxItem
    {
       
        public void ColorCoice(object combo)
        {
            List<string> Painted = new List<string>() { "Green", "Yelow", "Blue", "Red", "Purple" };
            List<string> Plated = new List<string>() { "Gold", "Silver", "Bronz" };

            ComboBox comboBox = (ComboBox)combo;

            if (comboBox.SelectedItem.ToString() == "Painted")
            {
                comboBox.DataSource = null;
                comboBox.DataSource = Painted;
            }

            else if (comboBox.SelectedItem.ToString() == "Plated")
            {
                comboBox.DataSource = null;
                comboBox.DataSource = Plated;
            }





        }
    }
}
