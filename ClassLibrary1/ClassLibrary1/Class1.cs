﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1 : Interface1
    {
        public string saluta()
        {
            Salutatore sal = new Salutatore();
            return "sono bello"+sal.hello();
        }

        
    }
}
