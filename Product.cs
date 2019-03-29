using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public abstract class Product
    {
 public       string productName { get; set; }
 public       string pSize { get; set; }
 public       int pSearialNo { get; set; }
 public       string pColor { get; set; }
        public decimal pPrice { get; set; }



        public  void  CreateAbstractProduct(string color,string size,int serialNo)
        {
            pColor = color;
            pSize = size;
            pSearialNo = serialNo;
        }
    }
}
