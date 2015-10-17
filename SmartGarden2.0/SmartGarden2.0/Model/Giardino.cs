using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    public class Giardino
    {
        public string Luogo { get; set; }

        private Cisterna _cisterna;
        private Settori _settori;

        public Giardino(string luogo = null)
        {
            Luogo = luogo;
            _cisterna = new Cisterna();
            _settori = new Settori();
        }

        public Settori Settori
        {
            get { return _settori; }
            set { _settori = value; }
        }

        public Cisterna Cisterna
        {
            get { return _cisterna; }
        }
    }
}
