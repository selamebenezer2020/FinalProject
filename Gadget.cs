using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  public  class Gadget:Product

    {
      
       public string powerSource { get; set; }
      public  List<Widget> widgets { get; set; }
      public List<IComponent> components { get; set; }
        public decimal totalPrice { get; set; }

        public Gadget(string color, string size, int serialNumber)
        {
            pSearialNo = serialNumber;
            productName = "Gadget";
            pPrice = 0.00m;
            totalPrice = 0.00m;
            pColor = color;
            pSize = size;
            widgets = new List<Widget>();
            AddMyComponents();
        }
        private void AddComponent(Widget component)
        {
            widgets.Add(component);
            pPrice += component.pPrice;
        }

        public void AddComponents(Widget component, int count)
        {
            for (int i = 0; i < count; i++)
            {
                AddComponent(component);
            }
        }

        public void AddComponents(Widget component, int count, ArrayList serial)
        {
            for (int i = 0; i < count; i++)
            {
                component.pSearialNo = int.Parse(serial[i].ToString());
                AddComponent(component);
            }
        }

        private void AddComponents(IComponent component, int count)
        {
            for (int i = 0; i < count; i++)
            {
                components.Add(component);
                totalPrice += component.CoPrice;
                pPrice += component.CoPrice;
            }
        }

        private void AddMyComponents()
        {
            components = new List<IComponent>();

            switch (pSize)
            {
                case "Small":
                    AddComponents(new Button(), 2);
                    AddComponents(new Switch(), 1);
                    break;
                case "Medium":
                    AddComponents(new Button(), 5);
                    AddComponents(new Light(), 3);
                    AddComponents(new Switch(), 1);
                    break;
                case "Large":
                    AddComponents(new Button(), 7);
                    AddComponents(new Light(), 6);
                    AddComponents(new Switch(), 5);
                    break;
            }
        }
    }
}

        
    
      

    

