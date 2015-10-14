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
            Providers _prov = new Providers();
            foreach(Type type in _providerList.Keys)
            {
                _prov.add((IinformationProvider)Activator.CreateInstance(type), _factoryVisitor.GetVisitor(_providerList[type]));
            }

            return _prov;
        }
    }
}
