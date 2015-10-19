using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Fornitori
{
    class ProviderTemperaturaDefaultHttp : IinformationProvider
    {
        //TODO da lavorarci
        FornitoreInformazioniMeteoHttp giver;
        public ProviderTemperaturaDefaultHttp()
        {
            giver = FornitoreInformazioniMeteoHttp.GetFornitore();
        }
        public void Accept(IinformationProviderVisitor visitor)
        {
            visitor.Visit(this);
        }

        public double GetPrecipitazioni()
        {
            return giver.GetDato("precipitazioni", new DateTime(), new DateTime());
        }
    }
}
