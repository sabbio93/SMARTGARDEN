using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //TODO potrei metterlo insieme con TypeInspector
    class FactoryGestoreInformazioni
    {
        private List<GestoreInformazioni> _gestori;
        private static FactoryGestoreInformazioni instance = null;

        private FactoryGestoreInformazioni()
        {
            _gestori = new List<GestoreInformazioni>();
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
            
            foreach (GestoreInformazioni gest in _gestori)
            {
                //if (gest.Providers.Equals(providers))
                    return gest;
            }

            GestoreInformazioni gestore = new GestoreInformazioni();
           // gestore.Providers = providers;
            _gestori.Add(gestore);
            return gestore;
        }

    }
}
