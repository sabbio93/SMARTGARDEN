using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden2._0
{
    class FornitorePrecipitazioni : FornitoreDatiMeteo
    {
        public FornitorePrecipitazioni(string città) : base(città)
        {
            Città = città;
        }

        public override double GetInformazione()
        {
            return GetDato("precipitation");
        }
    }
}
