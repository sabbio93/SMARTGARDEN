using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGarden
{
    public class Pianta
    {
        public string NomeComune { get; set; }
        public string NomeBotanico { get; set; }
        public double Area { get; set; }

        private List<FabbisognoGiornalieroPeriodo> _fabbisogni;

        public Pianta(string nomeComune, string nomeBotanico, double area = 0)
        {
            if (string.IsNullOrWhiteSpace(nomeBotanico) || string.IsNullOrWhiteSpace(nomeComune))
                throw new ArgumentNullException("Nome botanico o comune non accettabile");

            NomeBotanico = nomeBotanico;
            NomeComune = nomeComune;
            Area = area;
            _fabbisogni = new List<FabbisognoGiornalieroPeriodo>();
        }

        public double FabbisognoPiantaAttuale()
        {
            foreach(FabbisognoGiornalieroPeriodo fabbisogno in _fabbisogni){
                if (fabbisogno.InizioPeriodo <= DateTime.Now && fabbisogno.FinePeriodo >= DateTime.Now)
                {
                    return fabbisogno.FabbisognoAcquaGiornaliero;
                }
            }
            return 0;
        }

        public List<FabbisognoGiornalieroPeriodo> FabbisogniPianta
        {
            get { return _fabbisogni; }
        }
        

    }
}
