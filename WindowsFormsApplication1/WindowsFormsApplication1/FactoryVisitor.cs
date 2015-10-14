using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    internal class FactoryVisitor
    {
        Dictionary<Type, IinformationProviderVisitor> visitors;

        public FactoryVisitor()
        {
            visitors = new Dictionary<Type, IinformationProviderVisitor>();
        }
        internal IinformationProviderVisitor GetVisitor(Type type)
        {
           if(visitors.ContainsKey(type))
            {
                return visitors[type];
            }
           else
            {
                IinformationProviderVisitor _visitor = (IinformationProviderVisitor) Activator.CreateInstance(type);
                visitors.Add(type, _visitor);
                 return _visitor;
            }
        }
    }
}