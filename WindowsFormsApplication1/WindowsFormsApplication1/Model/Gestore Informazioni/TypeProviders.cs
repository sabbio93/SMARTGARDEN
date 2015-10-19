using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartGarden.Fornitori;

namespace SmartGarden
{
    class TypeProviders
    {
        Converter<TypeProviders, Providers> conv;
        Dictionary<Type, Type> _providerList;
        FactoryVisitor _factoryVisitor;
        public TypeProviders()
        {
            _providerList = new Dictionary<Type, Type>();
            _factoryVisitor = new FactoryVisitor();
        }

        public Providers GetProviders()
        {
            Providers prov = new Providers();
            foreach(Type type in _providerList.Keys)
            {
                prov.add((IinformationProvider)Activator.CreateInstance(type), _factoryVisitor.GetVisitor(_providerList[type]));
            }

            prov.Visitors = _factoryVisitor.GetVisitorsList();
            return prov;
        }

        public void AddTypeProvider(Type provider,Type handler)
        {
            _providerList.Add(provider, handler);
        }

        internal static TypeProviders GetTypeProvidersFromProviders(Providers _providers)
        {
            TypeProviders typepro = new TypeProviders();
            return typepro;
            //TODO da completare
        }

        public string GetCoppiaToString(Type selectedItem)
        {
            return selectedItem.Name + _providerList[selectedItem].Name;
        }

        public Type GetHandler(Type provider)
        {
            return _providerList[provider];
        }

        public Boolean Remove(Type provider)
        {
            if(_providerList.ContainsKey(provider))
            {
                _providerList.Remove(provider);
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
