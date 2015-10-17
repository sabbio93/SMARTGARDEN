using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    class FornitoreTemperatura : FornitoreInformazioniMeteo
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
