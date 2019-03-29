using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public class Gear : IComponent
    {
        public string CoName
        {
            get { return "Gear"; }
        }

        public decimal CoPrice
        {
            get { return 60.00m; }
        }
    }
}
