using InterfacciaGestoreInformazioni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1 ;

namespace WindowsFormsApplication1
{
    class ProviderVisitorInspector
    {
        
        //sarebbe meglio farlo diventare un flywight o un singleton
        private readonly string @namespaceVisitor = "WindowsFormsApplication1.Fornitori";
        private readonly string @namespaceProvider = "WindowsFormsApplication1.Fornitori";
        private readonly Type interfaceVisitor = typeof(IinformationProviderVisitor);
        private readonly Type interfaceProvider = typeof(IinformationProvider);

        public List<Type> GetListProvider() //scegli provider
        {
            return GetListTypeAssociatedInterface(namespaceProvider, interfaceProvider);
        }

        public List<Type> GetListVisitor() //scegli visitor
        {
            return GetListTypeAssociatedInterface(namespaceVisitor,interfaceVisitor);
        }

        public List<Type> GetListTypeAssociatedInterface(String name,Type interf)
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

        public List<Type> GetVisitorFromFile( String fileName)
        {
            return GetTypeFromFile(fileName,interfaceVisitor);
        }

        public List<Type> GetProviderFromFile(String fileName)
        {
            return GetTypeFromFile(fileName, interfaceProvider);
        }

        private List<Type> GetTypeFromFile(String fileName,Type interf)
        {
            var q = from type in Assembly.LoadFile(fileName).GetExportedTypes()
                    where type.IsClass && type.GetInterface(interf.Name) != null
                    select type;
            return q.ToList<Type>();
        }


    }
}