using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 
namespace FinalProject
{
    public partial class WagOrderForm : Form
    {
        ComboBoxItem boxItem = new ComboBoxItem();
        MyformAccess access = new MyformAccess();
        Customer myCustomer = new Customer( );
        CheckOutInformation CheckOut = new CheckOutInformation();
        public WagOrderForm()
        {
            InitializeComponent();
            grGadget.Visible = false;
            grWidget.Visible = false;

        }
        private void ButtonEnable()
        {
            buttonSubmit.Enabled = access.ActivateMyButton(this.Controls);
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckOut.Calculate();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        //Tis drop down control is used to recive data from the user on types of items to be ordered.
        private void comboItem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboItem.Text == "Gadgets and Widgets")
            {
                grWidget.Visible = true;
                grGadget.Visible = true;
            }
            else if (comboItem.Text == "Widget")
            {
                grWidget.Visible = true;
                grGadget.Visible = false;

            }
            else
            {
                grWidget.Visible = false;
                grGadget.Visible = true;
            }
        }

        private void chkWSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWSmall.Checked == true)
            {
                comboWSmall.Enabled = true;
                txtWSmallQ.Enabled = true;
                txtWSmallQ.Focus();
            }
        }

        private void txtWSmallQ_TextChanged(object sender, EventArgs e)
        {
            access.ActivateMyButton(this.Controls);
            CheckOut.GetUserInput(this.Controls);
        }
        private void txtWSmallQ_LostFocus(object sender, EventArgs e)
        {


        }
        /* private void txtWSmallQ_Leave(object sender, System.EventArgs e)
         {

            // ValidateText();
             txtWSmallQ.Text = "";

         }*/

        private void MyTextBox_Validating(TextBox currenttb)
        {


            //TextBox currenttb = new TextBox();
            //TextBox currenttb = (TextBox)sender;


            //currenttb.Name =name ;
            // MessageBox.Show(currenttb.Name);
            // currenttb.Text = obj.Text;
            if (currenttb.Text == "")
            {
                MessageBox.Show("Please enter number of items ordered.");
                currenttb.Focus();
            }
            else
            {
                try
                {
                    int val = int.Parse(currenttb.Text);
                    if (val < 10)
                    {
                        MessageBox.Show("Minimum order is 10");
                        currenttb.Clear();
                        currenttb.Focus();

                    }

                }
                catch
                {
                    MessageBox.Show("Please enter only numbers");
                    currenttb.Clear();
                    currenttb.Focus();
                }

            }

        }

        private void chkWMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWMedium.Checked == true)
            {
                comboWMedium.Enabled = true;
                textWMediumQ.Enabled = true;
                textWMediumQ.Focus();
            }
        }

        private void chkWLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (chkWLarge.Checked == true)
            {
                comboWLarge.Enabled = true;
                textWLargeQ.Enabled = true;
                textWLargeQ.Focus();
            }

        }


        private void txtWSmallQ_Leave(object sender, EventArgs e)
        {
            if (chkWSmall.Focused)
            {
                txtWSmallQ.Clear();
                txtWSmallQ.Enabled = false;
                comboWSmall.Enabled = false;
            }
            else
                FindControl(sender);


        }


        private void FindControl(object textBox)
        {

            TextBox obj = (TextBox)textBox;
            // string name = obj.Name;


            MyTextBox_Validating(obj);





        }

        private void textWMediumQ_Leave(object sender, EventArgs e)
        {

            if (chkWMedium.Focused)
            {
                textWMediumQ.Clear();
                textWMediumQ.Enabled = false;
                comboWMedium.Enabled = false;
            }
            else
                FindControl(sender);
        }

        private void textWLargeQ_Leave(object sender, EventArgs e)
        {
            if (chkWLarge.Focused)
            {
                textWLargeQ.Clear();
                textWLargeQ.Enabled = false;
                comboWLarge.Enabled = false;
            }
            else
                FindControl(sender);
        }

        private void textGSmall_Leave(object sender, EventArgs e)
        {
            if (checkGSmall.Focused)
            {
                textGSmall.Clear();
                textGSmall.Enabled = false;
                comboGSmall.Enabled = false;
            }
            else
            {
                FindControl(sender);
            }


        }

        private void textGMedium_TextChanged(object sender, EventArgs e)
        {    
            access.ActivateMyButton(this.Controls);
            CheckOut.GetUserInput(this.Controls);
        }

        private void textGlarge_Leave(object sender, EventArgs e)
        {
            if (checkGLarge.Focused)
            {
                textGLarge.Clear();
                textGLarge.Enabled = false;
                comboGlarge.Enabled = false;
            }
            else
                FindControl(sender);
        }

        private void checkGSmall_CheckedChanged(object sender, EventArgs e)
        { /*
              if (checkGSmall.Checked)
              {
                  comboGSmall.Enabled = true;
                  textGSmall.Enabled = true;
                  textGSmall.Focus();
              }
              else if (checkGSmall.Checked == false)
              {

                  textGSmall.Clear();
                  textGSmall.Enabled = false;
              }*/


        }

        private void textGMedium_Leave(object sender, EventArgs e)
        {
            if (checkGMedium.Focused)
            {
                textGMedium.Clear();
                textGMedium.Enabled = false;
                comboGMedium.Enabled = false;
            }
            else
            FindControl(sender);
        }

        private void checkGMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGMedium.Checked)
            {
                comboGMedium.Enabled = true;
                textGMedium.Enabled = true;
                textGMedium.Focus();
            }

        }

        private void checkGLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGLarge.Checked == true)
            {
                comboGlarge.Enabled = true;
                textGLarge.Enabled = true;
                textGLarge.Focus();
            }
        }

        private void radioGPlain_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioGPainted_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboGSmall_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxItem.ColorCoice(sender);
            CheckOut.GetUserInput(this.Controls);
        }

        private void comboGMedium_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxItem.ColorCoice(sender);
            CheckOut.GetUserInput(this.Controls);
        }

        private void comboGlarge_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxItem.ColorCoice(sender);
            CheckOut.GetUserInput(this.Controls);
        }

        private void comboWSmall_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxItem.ColorCoice(sender);
            CheckOut.GetUserInput(this.Controls);
        }

        private void comboWMedium_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxItem.ColorCoice(sender);
            CheckOut.GetUserInput(this.Controls);
        }

        private void comboWLarge_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxItem.ColorCoice(sender);
            CheckOut.GetUserInput(this.Controls);
        }

        private void textGSmall_TextChanged(object sender, EventArgs e)
        {
            access.ActivateMyButton(this.Controls);
            CheckOut.GetUserInput(this.Controls);
        }

        private void textGLarge_TextChanged(object sender, EventArgs e)
        {
            access.ActivateMyButton(this.Controls);
            CheckOut.GetUserInput(this.Controls);
        }

        private void textWMediumQ_TextChanged(object sender, EventArgs e)
        {
            access.ActivateMyButton(this.Controls);
            CheckOut.GetUserInput(this.Controls);
        }

        private void textWLargeQ_TextChanged(object sender, EventArgs e)
        {
            buttonSubmit.Enabled = access.ActivateMyButton(this.Controls);
            CheckOut.GetUserInput(this.Controls);
        }

        private void textCustomerName_TextChanged(object sender, EventArgs e)
        {
            access.ActivateMyButton(this.Controls);
            CheckOut.GetUserInput(this.Controls);
        }

        private void texAdress_TextChanged(object sender, EventArgs e)
        {
            access.ActivateMyButton(this.Controls);
            CheckOut.GetUserInput(this.Controls);
        }

        private void textBillingInfo_TextChanged(object sender, EventArgs e)
        {
            access.ActivateMyButton(this.Controls);
        }

        private void textGSmall_Click(object sender, EventArgs e)
        {


        }

        private void checkGSmall_Click(object sender, EventArgs e)
        {
            if (checkGSmall.Checked)
            {
                comboGSmall.Enabled = true;
                textGSmall.Enabled = true;
                textGSmall.Focus();
            }
            else if (checkGSmall.Checked == false)
            {

                textGSmall.Clear();
                textGSmall.Enabled = false;
            }
        }

        private void textCustomerName_Leave(object sender, EventArgs e)
        {
            myCustomer.Validate(sender);
            
        }

        private void texAdress_Leave(object sender, EventArgs e)
        {
            myCustomer.Validate(sender);
        }

        private void textBillingInfo_Leave(object sender, EventArgs e)
        {
            myCustomer.Validate(sender);
        }
    }
}

