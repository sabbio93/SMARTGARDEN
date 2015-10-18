using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{ 
   interface IPianta
    {
       
        GestoreInformazioni GestoreInformazioni { get; set; }
        List<FabbisognoGiornalieroPeriodo> FabbisogniPianta{ get; }
        void AddFabisogno(FabbisognoGiornalieroPeriodo fab);
        double FabbisognoPiantaAttuale();
        Guid Guid { get; }
    }
}
