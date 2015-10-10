using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerPassivo
{
    class Settore
    {
        Valvola valvola;
        String name;

        public String Nome
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                valvola = new Valvola();
                valvola.Name = "valvola" + name;
            }
        }

        internal void setTimer(IObservable<long> timer)
        {
            timer.Subscribe(valvola);
        }
    }
}
