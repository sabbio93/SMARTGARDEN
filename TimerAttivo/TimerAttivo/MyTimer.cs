using System;
using System.Collections.Generic;

namespace TimerAttivo
{
    internal class MyTimer
    {
        Dictionary<String, System.Timers.Timer[]> timers = new Dictionary<string, System.Timers.Timer[]>();

        internal void SetTimerPerSettore(int timeapertura, int timedopochiusura, String name,
            System.Timers.ElapsedEventHandler apro, System.Timers.ElapsedEventHandler chiudo)
        {
            System.Timers.Timer timerapertura = new System.Timers.Timer(timeapertura);
            System.Timers.Timer timerchiusura = new System.Timers.Timer(timeapertura + timedopochiusura);
        //    Delegate azione ;
            timerapertura.Elapsed += apro;
          //  timerapertura.Elapsed += (System.Timers.ElapsedEventHandler) azione;
            timerchiusura.Elapsed += chiudo;
            timerapertura.Start();
            timerchiusura.Start();
            timerapertura.AutoReset = false;
            timerchiusura.AutoReset = false;
            System.Timers.Timer[] timerpervalvola = new System.Timers.Timer[2];
            timerpervalvola[0] = timerapertura;
            timerpervalvola[1] = timerchiusura;
            timers.Add(name, timerpervalvola);
        }
    }
}