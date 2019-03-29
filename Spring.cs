using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public class Spring :IComponent
    {
        public string CoName
        {
            get { return "Spring"; }
        }

        public decimal CoPrice
        {
            get { return 50.00m; }
        }
    }
}
