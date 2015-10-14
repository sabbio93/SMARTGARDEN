using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Fornitori;

namespace WindowsFormsApplication1
{
    class TypeProviders
    {
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

    }
}
