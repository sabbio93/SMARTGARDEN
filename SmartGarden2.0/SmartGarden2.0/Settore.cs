﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerPassivo
{
    class Settore
    {
        private Valvola _valvola;
        private String _nome;
        private double _portataImpianto;

        public Settore(string nome)
        {
            _valvola = new Valvola();
            _nome = nome;
            _portataImpianto = 0;
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

        internal void setTimer(IObservable<long> timer)
        {
            timer.Subscribe(_valvola);
        }
    }
}
