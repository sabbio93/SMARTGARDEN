using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden2._0
{
    class Settori
    {
        private List<Settore> _listaSettori;

        public Settori()
        {
            _listaSettori = new List<Settore>();
        }

        public List<Settore> ListaSettori
        {
            get { return _listaSettori; }
        }

    }
}
