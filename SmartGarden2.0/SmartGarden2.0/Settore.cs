using System;
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

        public Settore(string nome)
        {
            _valvola = new Valvola();
            _nome = nome;
        }

        public String Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        internal void setTimer(IObservable<long> timer)
        {
            timer.Subscribe(_valvola);
        }
    }
}
