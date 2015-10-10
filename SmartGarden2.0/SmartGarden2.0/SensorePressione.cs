using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGarden2._0
{
    class SensorePressione
    {
        public string Descrizione { get; set; }
        public Valvola ValvolaCentrale { get; set; }

        public SensorePressione(string descrizione)
        {
            if (string.IsNullOrWhiteSpace(descrizione))
                throw new ArgumentNullException("Descrizione sensore non valida");

            Descrizione = descrizione;
        }
    }
}
