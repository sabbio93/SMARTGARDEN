﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1 
{
    class StandardInformationVisitor : IinformationProviderVisitor
    {
        public void Visit(dynamic informationProvider)
        {
            VisitSpecialization(informationProvider as dynamic);
        }

        private void VisitSpecialization(FintoFornitoreInformazioni informationProvider )
        {
            Console.WriteLine(informationProvider.Ciao);
        }

    }
}
