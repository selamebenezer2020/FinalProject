using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class CheckOutInformation
    {
        
       static SerialNoGenerator SerialNo =SerialNoGenerator.Instance;
        string customerName;
        String Address;
        String billingInformation;
        string Color;
        string itemOrdered;
        int quantity;
        int SwQuantity;
        int MwQuantity;
        int LwQuantity;
        int SGQuantity;
        int MGQuantity;
        int LGQuantity;
        string swColor;
        string mwColor;
        string lwColor;
        string sGColor;
        string mGColor;
        string lGColor;
        decimal price;
        decimal totalPrice;


        
        public void GetUserInput(Control.ControlCollection collection)
        {
            foreach (Control control in collection)

            {


                if (control is TextBox && control.Enabled)
                { 
                    switch(control.Name)
                    {
                        case "textCustomerName":
                            customerName = control.Text;
                            break;
                        case "texAdress":
                            Address = control.Text;
                            break;
                        case "textBillingInfo":
                            billingInformation = control.Text;
                            break;
                        case "textGSmall":
                            SGQuantity = int.Parse(control.Text);
                            break;
                        case "textGMedium":
                            MGQuantity = int.Parse(control.Text);
                            break;
                        case "textGLarge":
                            LGQuantity = int.Parse(control.Text);
                            break;
                        case "txtWSmallQ":
                            SwQuantity = int.Parse(control.Text);
                            break;
                        case "textWMediumQ":
                            MwQuantity = int.Parse(control.Text);
                            break;
                        case "textWLargeQ":
                            LwQuantity = int.Parse(control.Text);
                            break;



                    }

                }
                else if(control is ComboBox && control.Enabled)
                {
                    switch (control.Name)
                    {
                        case "comboGSmall":
                            sGColor = control.Text;
                            break;
                        case "comboGMedium":
                            mGColor = control.Text;
                            break;
                        case "comboGlarge":
                            lGColor = control.Text;
                            break;
                        case "comboWSmall":
                            swColor = control.Text;
                            break;
                        case "comboWMedium":
                            mwColor = control.Text;
                            break;
                        case "comboWLarge":
                            lwColor = control.Text;
                            break;
                    }
                }
                if (control.HasChildren)
                {
                    GetUserInput(control.Controls);
                }

            }
        }

        public void Data()
        {
            int[] sWSArry = new int[SwQuantity];
            int[] mWSArry = new int[MwQuantity]; 
            int[] lWSArry = new int[LwQuantity]; 
            int[] sGSArry = new int[SGQuantity]; 
            int[] mGSArry = new int[MGQuantity]; 
            int[] lGSArry = new int[LGQuantity]; 

            for(int i=0;i< SwQuantity;i++)
            {
                sWSArry[i] = SerialNo.SmallWidgetSerial;
            }
            for (int i = 0; i < MwQuantity; i++)
            {
                mWSArry[i] = SerialNo.MediumWidgetSerial;
            }
            for (int i = 0; i < LwQuantity; i++)
            {
                lWSArry[i] = SerialNo.LargeWidgetSerial;
            }
            for (int i = 0; i < SGQuantity; i++)
            {
                sGSArry[i] = SerialNo.SmallGadgetSerial;
            }
            for (int i = 0; i < MGQuantity; i++)
            {
                mGSArry[i] = SerialNo.MediumGadgetSerial;
            }
            for (int i = 0; i < LGQuantity; i++)
            {
                lGSArry[i] = SerialNo.LargeGadgetSerial;
            }

            MessageBox.Show("Divice Serial Number\n\t\t22SML"+sWSArry[0] + "\n" + "\t\t22SML" + sWSArry[1] + "\n" + "\t\t22SML" + sWSArry[2]+"\n" + "\t\t06LRG" + lGSArry[0].ToString()+"\n" + "\t\t06LRG" + lGSArry[1].ToString() + "\n" + "\t\t06LRG" + lGSArry[2].ToString());
        }
        public void Calculate()
        {
            totalPrice =( (50.00m * SwQuantity) + (65.00m * MwQuantity) + (80.00m * LwQuantity) + (150.00m * SGQuantity) + (180.00m * MGQuantity) + (230.00m * LGQuantity));
             string message = "Customer Name "+ customerName+"\n" +"Adress "+ Address +
                "\nWidget orderd\n\n\t\tSmall Widgets "+ SwQuantity+"\n\n\t\tMedium Widgets"+ MwQuantity+"\n\n\t\tLarge Widgets "+ LwQuantity+
                "\n\nGaget Ordered\n\n\t\tSmall Gadgets "+ SGQuantity + "\n\n\t\tMedium Gadgets" + MGQuantity + "\n\n\t\tLarge Gadgets " + LGQuantity +"\n\n\n\tTotal Price "+ totalPrice + "\n\n Do you want to continue your order?\n";
            string title = "Wag Order Summury";
            MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if ( result== DialogResult.No)
            {
              
                
               
                    
            }
            else if(result == DialogResult.Cancel)
            {
                WagOrderForm.ActiveForm.Close();
            }
            else
            {
                Data();
            }
            
            
           
            
        }
    }
}