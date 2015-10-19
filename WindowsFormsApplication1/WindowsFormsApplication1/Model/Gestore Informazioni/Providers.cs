using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartGarden.Fornitori;

namespace SmartGarden
{
    class Providers
    {
        Dictionary<IinformationProvider, IinformationProviderVisitor> _providerList;
        List<IinformationProviderVisitor> _visitorList; // visitor list would be obtainable from _providerList with iteration and comparison
                                                        // is but it comes a gratis form factory and is much more efficient
        public Providers()
        {
            _providerList= new Dictionary<IinformationProvider, IinformationProviderVisitor>();
        }

        //TODO se metto il metodo della somma acqua qui elimino questo metodo e lavoro sulla lista e non passo a un esterno lista provider
        public List<IinformationProviderVisitor> Visitors
        {
            get
            {
                return _visitorList;
            }
            set
            {
                _visitorList = value;
            }
        }

        private bool HasInformationProvider(IinformationProvider inf)
        {
            return _providerList.ContainsKey(inf);
        }

        internal double GetModifierRequirement(IDataPianta pianta)
        {
            double requiredWater=0;
            //TODO devo stare attento alla gestione dei visitor xkè li riscrcivo
            //2 casi 2 hanno stesso visitor ma != gestore
            // 2 hanno stesso visitor e gestore
            foreach(IinformationProvider prov in _providerList.Keys)
            {
                prov.Accept(_providerList[prov]);
            }

            foreach(IinformationProviderVisitor visitor in _visitorList)
            {
                requiredWater += visitor.GetRequiredWater(pianta);
            }
              

            return requiredWater;
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
