using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerPassivo
{
    class Settore
    {
        MyValvola valvola;
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
                valvola = new MyValvola();
                valvola.Name = "valvola" + name;
            }
        }

        internal void setTimer(IObservable<long> timer)
        {
            timer.Subscribe(valvola);
        }
    }
}
