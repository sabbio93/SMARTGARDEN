using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SmartGarden2._0
{
    public class Settore
    {
        private Valvola _valvolaSettore;
        private String _nome;
        private double _portataImpianto;
        private Piante _piante;

        public Settore(string nome)
        {
            _valvolaSettore = new Valvola();
            _nome = nome;
            _portataImpianto = 0;
            _piante = new Piante();
        }

        public String Nome
        {
            get { return _nome; }
            set
            {
                if(string.IsNullOrEmpty(value))
                    _nome = value;
            }
        }

        public double PortataImpianto
        {
            get { return _portataImpianto; }
            set
            {
                if (value >= 0)
                    _portataImpianto = value;
            }
        }

        public Piante Piante
        {
            get { return _piante; }
            set { _piante = value; }
        }

        #region EventiTimer
        public ElapsedEventHandler OpenMethodSettore
        {
            get { return _valvolaSettore.Apri; }
        }

        public ElapsedEventHandler CloseMethodSettore
        {
            get { return _valvolaSettore.Chiudi; }
        }
        #endregion

    }
}
