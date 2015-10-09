using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden2._0
{
    class FornitoreTemperatura : FornitoreDatiMeteo
    {
        public FornitoreTemperatura(string città) : base(città)
        {
            Città = città;
        }

        public override double GetInformazione()
        {
            return GetDato("temperature");
        }
    }
}
