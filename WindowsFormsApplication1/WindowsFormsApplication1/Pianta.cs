using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Pianta : IPianta
    {
        GestoreInformazioni gest;
       public Pianta()
        {
            gest = new GestoreInformazioni();
        }
    }

    internal interface IPianta
    {
    }
}
