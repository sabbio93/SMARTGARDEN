using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    interface IinformationProviderVisitor
    {
        //TODO per ora uso l ereditarietà potrei applicare decorator?
        //dynamic act like object in compile time
        void Visit(dynamic informationProvider);

        double GetRequiredWater(IPianta pianta);
    }
}
