﻿using System.Collections.Generic;

namespace SmartGarden
{
    internal interface IDataPiantaFlyweight
    {
        string NomeComune{ get; }

        string NomeBotanico{ get;}

        List<FabbisognoGiornalieroPeriodo> Fabisogni{ get;}

        void addFabisognoRelativoPeriodo(FabbisognoGiornalieroPeriodo fab);
        
    }
}