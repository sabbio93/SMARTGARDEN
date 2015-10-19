using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    interface IinformationProviderVisitor
    {
        //dynamic act like object in compile time
        void Visit(dynamic informationProvider);

        double GetRequiredWater(IDataPianta pianta);
    }
}
