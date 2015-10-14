using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Fornitori;

namespace WindowsFormsApplication1
{
    class Providers
    {
        Dictionary<IinformationProvider, IinformationProviderVisitor> _providerList;
        public Providers()
        {
            _providerList= new Dictionary<IinformationProvider, IinformationProviderVisitor>();
        }

        private object GetVisByInformationProvider(IinformationProvider inf)
        {
            return _providerList[inf];
        }

        private bool HasInformationProvider(IinformationProvider inf)
        {
            return _providerList.ContainsKey(inf);
        }

        internal double GetModifierRequirement(Pianta pianta)
        {
            //TODO finish this method
            foreach(IinformationProvider prov in _providerList.Keys)
            {
                prov.Accept(_providerList[prov]);
            }
            //per ogni visitor prendo le informazioni 
            //non devo prendere + volte le info dallo stesso visitor
            //cambio struttura contenimento?

            return 0;
        }

        internal void add(IinformationProvider v1, IinformationProviderVisitor v2)
        {
            _providerList.Add(v1, v2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Providers p = (Providers)obj;
            foreach (IinformationProvider inf in _providerList.Keys)
            {
                if (!p.HasInformationProvider(inf))
                    return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
