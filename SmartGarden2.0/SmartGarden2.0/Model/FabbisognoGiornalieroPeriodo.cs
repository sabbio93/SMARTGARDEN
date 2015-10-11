using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGarden2._0
{
    class FabbisognoGiornalieroPeriodo
    {
        public DateTime InizioPeriodo { get; set; }
        public DateTime FinePeriodo { get; set; }
        public double FabbisognoAcquaGiornaliero { get; set; }

        public FabbisognoGiornalieroPeriodo(DateTime inizio, DateTime fine, double fabbisognoGiornaliero)
        {
            if (fine.CompareTo(inizio) <= 0)
                throw new ArgumentException("Date non compatibili tra loro");
            if (fabbisognoGiornaliero <= 0)
                throw new ArgumentException("Fabbisogno inferiore o uguale a zero non consentito");

            InizioPeriodo = inizio;
            FinePeriodo = fine;
            FabbisognoAcquaGiornaliero = fabbisognoGiornaliero;
        }
    }
}
