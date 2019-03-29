using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string BillingInfo { get; set; }
        public string BillingAddress { get; set; }

        public void Validate(object sender)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.Name == "textCustomerName")
            {
                CustomerName = textBox.Text;

                if (CustomerName.Length == 0)
                {
                    MessageBox.Show("Customer Name is required");
                    textBox.Focus();
                }


            }


            if (textBox.Name == "texAdress")

            {
                Address = textBox.Text;
                if (Address.Length == 0)
                {
                    MessageBox.Show("Address is required");
                    textBox.Focus();

                }

            }
            if (textBox.Name == "textBillingInfo")

            {
                BillingInfo = textBox.Text;
                if (BillingInfo.Length == 0)
                {
                    MessageBox.Show("Billing info is required");
                    textBox.Focus();
                }

            }
            /* if ()
             {
                 
             }*/
        }

        public void MyCustomer()
        {

        }

        // public void MyCustomer1()
        // {

        // }


    }


}

