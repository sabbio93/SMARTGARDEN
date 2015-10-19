using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden
{  
    class FactoryGestoreInformazioni //Pattern Singleton
    {
        //TODO forse è meglio che pianta passi da me?

        private Dictionary<GestoreInformazioni,int> _gestori;
        private static FactoryGestoreInformazioni instance = null;

        private FactoryGestoreInformazioni()
        {
            _gestori = new Dictionary<GestoreInformazioni,int>();
        }

        public static FactoryGestoreInformazioni GetFactory()
        {
            if (instance == null)
                instance = new FactoryGestoreInformazioni();
            return instance;
        }

        public GestoreInformazioni GetGestore(TypeProviders typeproviders)
        {
            Providers providers = typeproviders.GetProviders();
            
            foreach (GestoreInformazioni gest in _gestori.Keys)
            {
                if (gest.Providers.Equals(providers))
                {
                    _gestori[gest]++;
                    return gest;
                }
            }

            GestoreInformazioni gestore = new GestoreInformazioni();
            gestore.Providers = providers;
            _gestori.Add(gestore,1);
            return gestore;
        }

        public GestoreInformazioni Modifica(GestoreInformazioni OldGestore,TypeProviders typeproviders)
        {
            _gestori[OldGestore]--;
            if(_gestori[OldGestore]<1)
            {
                _gestori.Remove(OldGestore);
            }

            return GetGestore(typeproviders);
        }
           
    }
}
