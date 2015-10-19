using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartGarden;

namespace SmartGarden
{
    class Piante
    {
        private Dictionary<Guid,IPianta> _piante;

        public double GetFabbisognoTotale()
        {
            double fabbisognoTotale = 0;

            foreach(Pianta pianta in _piante.Values)
            {
                fabbisognoTotale += pianta.FabbisognoPiantaAttuale();
            }

            return fabbisognoTotale;
        }

        public IPianta GetPianta(Guid guid)
        {
            return _piante[guid];
        }

        public void AddPianta(IPianta pianta)
        {
            _piante.Add(pianta.Guid, pianta);
        }

        public Piante()
        {
            _piante = new Dictionary<Guid, IPianta>();
        }

        public List<IPianta> ListaPiante
        {
            get { return _piante.Values.ToList(); }
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
