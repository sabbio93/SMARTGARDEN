﻿using System;
using System.Collections.Generic;
using System.Timers;

namespace TimerAttivo
{
    public class MyTimer
    {
        private Dictionary<string, Timer[]> _timers = new Dictionary<string, Timer[]>();

        public void SetTimer(int momentoApertura, int durataApertura, string name,
            ElapsedEventHandler Apri, ElapsedEventHandler Chiudi)
        {
            Timer timerApertura = new Timer(momentoApertura);
            Timer timerChiusura = new Timer(momentoApertura + durataApertura);

            timerApertura.Elapsed += Apri;
            timerChiusura.Elapsed += Chiudi;

            timerApertura.Start();
            timerChiusura.Start();
            timerApertura.AutoReset = false;
            timerChiusura.AutoReset = false;

            Timer[] timerPerValvola = new Timer[2];
            timerPerValvola[0] = timerApertura;
            timerPerValvola[1] = timerChiusura;

            _timers.Add(name, timerPerValvola);
        }

        public Dictionary<string, Timer[]> Timers
        {
            get { return _timers; }
        }

        public Timer[] GetTimerForElement(string element)
        {
            Timer[] timersForElement = new Timer[2];
            _timers.TryGetValue(element, out timersForElement);

            return timersForElement;
        }
        
        
    }
}