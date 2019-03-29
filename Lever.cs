using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public class Lever : IComponent
    {
        public string CoName
        {
            get { return "Lever"; }
        }

        public decimal CoPrice
        {
            get { return 90.00m; }
        }
    }
}
