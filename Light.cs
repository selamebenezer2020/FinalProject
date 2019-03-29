using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public class Light:IComponent
    {

        public string CoName
        {
            get { return "Light"; }
        }

        public decimal CoPrice
        {
            get { return 100.00m; }
        }

    }
}
