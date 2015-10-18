using System.Collections.Generic;

namespace SmartGarden
{
    internal interface IDataFlyweight
    {
        string NomeComune{ get; }

        string NomeBotanico{ get;}

        List<FabbisognoGiornalieroPeriodo> Fabisogni{ get;}

        void addFabisognoRelativoPeriodo(FabbisognoGiornalieroPeriodo fab);
        
    }
}