﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace SmartGarden2._0
{
    public class SensorePressione
    {
        private Valvola _valvolaCentrale;

        public string Descrizione { get; set; }

        public SensorePressione(string descrizione = null)
        {
            Descrizione = descrizione;
            _valvolaCentrale = new Valvola();
        }

        public Valvola ValvolaCentrale
        {
            get { return _valvolaCentrale; }
            set { _valvolaCentrale = value; }
        }

        #region EventiTimer
        public ElapsedEventHandler OpenMethodSensorePressione
        {
            get { return ValvolaCentrale.Apri; }
        }

        public ElapsedEventHandler CloseMethodSensorePressione
        {
            get { return ValvolaCentrale.Chiudi; }
        }
        #endregion
    }
}
