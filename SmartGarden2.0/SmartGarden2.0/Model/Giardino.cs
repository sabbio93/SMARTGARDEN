using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden2._0
{
    public class Giardino
    {
        public string Luogo { get; set; }

        private Cisterna _cisterna;
        private Settori _settori;

        public Giardino()
        {
            _cisterna = new Cisterna(10.5, 20);
            _settori = new Settori();
        }

        public Settori Settori
        {
            get { return _settori; }
            set { _settori = value; }
        }
    }
}
