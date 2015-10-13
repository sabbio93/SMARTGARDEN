using System;
using System.Collections.Generic;
using System.Timers;

namespace TimerAttivo
{
    public class MyTimer
    {
        private Dictionary<String, Timer[]> _timers = new Dictionary<string, Timer[]>();

        internal void SetTimerPerSettore(int momentoApertura, int durataApertura, String name,
            ElapsedEventHandler Apri, ElapsedEventHandler Chiudi)
        {
            Timer timerApertura = new System.Timers.Timer(momentoApertura);
            Timer timerChiusura = new System.Timers.Timer(momentoApertura + durataApertura);

            timerApertura.Elapsed += Apri;
            timerChiusura.Elapsed += Chiudi;

            timerApertura.Start();
            timerChiusura.Start();
            timerApertura.AutoReset = false;
            timerChiusura.AutoReset = false;
            Timer[] timerpervalvola = new Timer[2];
            timerpervalvola[0] = timerApertura;
            timerpervalvola[1] = timerChiusura;

            _timers.Add(name, timerpervalvola);
        }
    }
}