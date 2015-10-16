using InterfacciaGestoreInformazioni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Fornitori;

namespace WindowsFormsApplication1
{
    class ProviderVisitorInspector
    {
        //sarebbe meglio farlo diventare un flywight o un singleton
        private readonly string @namespaceVisitor = "WindowsFormsApplication1.Fornitori";
        private readonly string @namespaceProvider = "WindowsFormsApplication1.Fornitori";
        private readonly Type interfaceVisitor = typeof(IinformationProviderVisitor);
        private readonly Type interfaceProvider = typeof(IinformationProvider);

        public List<Type> GetListProvider()
        {
            return GetListTypeAssociatedInterface(namespaceProvider, interfaceProvider);
        }

        public List<Type> GetListVisitor()
        {
            return GetListTypeAssociatedInterface(namespaceVisitor,interfaceVisitor);
        }

        public List<Type> GetListTypeAssociatedInterface(string name,Type interf)
        {
            var q = from type in Assembly.GetExecutingAssembly().GetTypes()
                    where type.IsClass && type.Namespace == @name
                    && type.GetInterface(interf.Name) != null
                    select type;
            return q.ToList<Type>();
        }

        public bool IsGoodFile()
        {
            //TODO da completare magari non necessaria
            return false;
        }

        public List<Type> GetVisitorFromFile(string fileName)
        {
            return GetTypeFromFile(fileName,interfaceVisitor);
        }

        public List<Type> GetProviderFromFile(string fileName)
        {
            return GetTypeFromFile(fileName, interfaceProvider);
        }

        private List<Type> GetTypeFromFile(string fileName,Type interf)
        {
            var q = from type in Assembly.LoadFile(fileName).GetExportedTypes()
                    where type.IsClass && type.GetInterface(interf.Name) != null
                    select type;
            return q.ToList<Type>();
        }


    }
}