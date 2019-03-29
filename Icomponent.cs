using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
   public interface IComponent
    {
        string CoName { get;  }
        decimal CoPrice { get; }

        // void AddComponent();
    }
}
