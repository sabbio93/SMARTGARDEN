using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerAttivo
{
    class Settore
    {
        Valvola _valvola;
        String _nome;
        public Settore (String name)
        {
            _nome = name;
            _valvola = new Valvola("valvola"+name);
        }

        public System.Timers.ElapsedEventHandler getOpenMethodSettore()
        {
            return _valvola.apro;
        }

        public System.Timers.ElapsedEventHandler getCloseMethodSettore()
        {
            return _valvola.chiudo;
        }
    }
}
