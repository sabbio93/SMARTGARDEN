using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden2._0
{
    class Cisterna
    {
        public double Portata { get; set; }
        public double Capienza { get; set; }
        public SensorePressione SensorePressione{ get; set; }

        public Cisterna(double portata, double capienza)
        {
            if (portata <= 0 || capienza <= 0)
                throw new ArgumentException("Valore di portata o capienza non accettabile");

            Portata = portata;
            Capienza = capienza;
        }
    }
}
