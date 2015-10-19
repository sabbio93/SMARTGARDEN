using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    class Giardino
    {
        private Cisterna _cisterna;
        private Dictionary<string,Settore> _settori;

        public Giardino()
        {
            _cisterna = new Cisterna();
            _settori = new Dictionary<string, Settore>();
        }

        public Cisterna Cisterna
        {
            get { return _cisterna; }
        }

        //TODO knapsack algorithm
        public IEnumerable<TurnoItem> GetTurni()
        {
            List<TurnoItem> turni = new List<TurnoItem>();

            DateTime turno = new DateTime(0);
            foreach(Settore settore in _settori.Values)
            {
                TurnoItem turnoItem = new TurnoItem();
                turnoItem.Attesa = turno;
                double portata = settore.GetPortataVolumetricaSecondo(Cisterna.Portata);
                long durata = (long)(settore.GetFabisogno() / portata);
               TimeSpan dur = new TimeSpan(durata);
                turnoItem.Durata = dur;
                turno = turno.AddSeconds(durata);
            }


            return turni;
        }
    }

    class TurnoItem
    {
        public DateTime Attesa { get; set; }
        public TimeSpan Durata { get; set; }
        private List<IOpenClose> _methods;
        
        public void AddOpenClose(IOpenClose method)
        {
            _methods.Add(method);
        }

        public IEnumerable<IOpenClose> Mehtods
        {
            get
            {
                return _methods;
            }
        }
    }


    
}
