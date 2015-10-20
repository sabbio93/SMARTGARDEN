﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SmartGarden.Fornitori;

namespace SmartGarden
{
    class ProviderVisitorInspector
    {
        //TODO cambiare interfaccia con interf 
        private readonly string @namespaceVisitor = "SmartGarden.Fornitori";
        private readonly string @namespaceProvider = "SmartGarden.Fornitori";
        private readonly Type interfaceVisitor = typeof(IinformationProviderVisitor);
        private readonly Type interfaceProvider = typeof(IinformationProvider);
        Dictionary<Type, Type> _providers;
       
        #region Self Inspector
        public List<Type> GetListProvider()
        {
            return GetListTypeAssociatedInterface(namespaceProvider, interfaceProvider);
        }

        public List<Type> GetListVisitor()
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
        #endregion

        #region file inspector
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
        #endregion

    }
}