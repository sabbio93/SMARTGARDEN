using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extern_assembly
{
    class ClasseProva
    {
        public String ciao()
        {
            return "ciao sono una classe di prova";
        }

        public override string ToString()
        {
            return ciao();
        }
    }
}
