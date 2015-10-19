using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    interface IDataPianta
    {
        double Area { get; }
        string NomeComune { get; }
        string NomeBotanico { get; }
        Guid Guid { get; }
    }
}
