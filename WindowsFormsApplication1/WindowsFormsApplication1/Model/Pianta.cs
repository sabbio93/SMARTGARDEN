using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    class Pianta :IPianta,IDataPianta
    {
        private Guid Guid;
        Guid IDataPianta.Guid
        {
            get
            {
                return Guid;
            }
        }
        Guid IPianta.Guid
        {
            get
            {
                return Guid;
            }
        }
        private IDataFlyweight _data;
        public double Area { get; set; }
        public GestoreInformazioni GestoreInformazioni{ get; set; }
        
        public string NomeComune { get { return _data.NomeComune; } }

        public List<FabbisognoGiornalieroPeriodo> FabbisogniPianta
        {
            get { return _data.Fabisogni; }
        }

        public string NomeBotanico { get { return _data.NomeBotanico; } }

        public Pianta( string nomeBotanico, string nomeComune=null, double area = 0)
        {
            if (string.IsNullOrWhiteSpace(nomeBotanico) || string.IsNullOrWhiteSpace(nomeComune))
                throw new ArgumentNullException("Nome botanico o comune non accettabile");

            Guid = Guid.NewGuid();
            _data = PiantaFactory.GetDatiPianta(nomeBotanico, nomeComune);
        }

        public void AddFabisogno(FabbisognoGiornalieroPeriodo fab)
        {
            _data.addFabisognoRelativoPeriodo(fab);
        }
        
        //TODO completare il metodo
        public double FabbisognoPiantaAttuale()
        {
            return 0;
        }
    }
}
