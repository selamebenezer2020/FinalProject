using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Widget : Product , IComponent
    {
        

        public List<IComponent> Components { get; set; }

        public string CoName => throw new NotImplementedException();

        public decimal CoPrice => throw new NotImplementedException();

        public Widget(string color, string size, int serialNumber)
        {
            pSearialNo = serialNumber;
            productName = "Widget";
            pPrice = 0.00m;
            pColor = color;
            pSize = size;
            MakeWidget();
        }



    
        public virtual void AddComponents(int noOfGears, int noOfSprings, int noOfLevers)
        {

            AddGears(noOfGears);
            AddLevers(noOfLevers);
            AddSprings(noOfSprings);
        }
        private void AddComponent(IComponent component)
        {
            Components.Add(component);
            pPrice += component.CoPrice;
        }


        private void AddLevers(int noOfLevers)
        {
            for (int i = 0; i < noOfLevers; i++)
            {
                AddComponent(new Lever());
            }
        }


        private void AddSprings(int noOfSprings)
        {
            for (int i = 0; i < noOfSprings; i++)
            {
                AddComponent(new Spring());
            }

        }
        private void AddGears(int noOfGears)
        {
            for (int i = 0; i < noOfGears; i++)
            {
                AddComponent(new Gear());
            }
        }

        public void MakeWidget()
        {
            Components = new List<IComponent>();
            switch (pSize)
            {
                case "Small":

                    AddComponents(2, 3, 1);
                    break;
                case "Medium":
                    AddComponents(4, 5, 3);
                    break;
                case "Large":
                    AddComponents(9, 4, 2);
                    break;
            }

        }
    }
}
        

