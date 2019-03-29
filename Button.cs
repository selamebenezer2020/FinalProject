using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Button :IComponent
    {

        public string CoName
        {
            get { return "Button"; }
        }

        public decimal CoPrice
        {
            get { return 110.00m; }
        }

    }
}
