using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class FactoryGetstoreInformazioni
    {
        private List<GestoreInformazioni> _gestori;

        public FactoryGetstoreInformazioni()
        {
            _gestori = new List<GestoreInformazioni>();
        }
        public GestoreInformazioni getGestore(Providers _providers)
        {


            foreach (GestoreInformazioni gest in _gestori)
            {
                if (gest.Providers.Equals(_providers))
                    return gest;
            }

            GestoreInformazioni gestore = new GestoreInformazioni();
            gestore.Providers = _providers;
            _gestori.Add(gestore);
            return gestore;
        }
    }
}
