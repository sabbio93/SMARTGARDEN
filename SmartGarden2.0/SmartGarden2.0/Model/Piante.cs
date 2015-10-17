using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    public class Piante
    {
        private List<Pianta> _piante;

        public double GetFabbisognoTotale()
        {
            double fabbisognoTotale = 0;

            foreach(Pianta pianta in _piante){
                fabbisognoTotale += pianta.FabbisognoPiantaAttuale();
            }

            return fabbisognoTotale;
        }

        public Piante()
        {
            _piante = new List<Pianta>();
        }

        public List<Pianta> ListaPiante
        {
            get { return _piante; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Pianta pianta in ListaPiante)
            {
                sb.AppendLine("Nome Comune: " + pianta.NomeComune);
                sb.AppendLine("Nome Botanico: " + pianta.NomeBotanico);
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
