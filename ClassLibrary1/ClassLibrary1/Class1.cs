using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1 : Interfaccia.InformationSupplier
    {
        public string saluta()
        {
            return "sono bello";
        }

        public override string ToString()
        {
            return "ciao bello";
        }
    }
}
