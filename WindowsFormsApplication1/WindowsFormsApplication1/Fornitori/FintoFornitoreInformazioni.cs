﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Fornitori;

namespace WindowsFormsApplication1
{
    class FintoFornitoreInformazioni : IinformationProvider
    {
        private String _ciao = "hola como estas";
        public String Ciao
        {
            get
            {
                return _ciao;
            }
        }

        public void Accept(IinformationProviderVisitor v)
        {
            v.Visit(this);
        }
    }
}
