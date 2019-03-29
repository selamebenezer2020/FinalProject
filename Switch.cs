using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
  public  class Switch:IComponent
    {

        public string CoName
        {
            get { return "Switch"; }
        }

        public decimal CoPrice
        {
            get { return 50.00m; }
        }

    }
}
