using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace SmartGarden2._0
{
    class FornitoreDatiMeteo
    {
        private XmlDocument _xmlDati;
        public string Città { get; set; }

        public FornitoreDatiMeteo(string città)
        {
            Città = città;
            _xmlDati = new XmlDocument();
            AggiornaDatiMeteo(); //appena creato aggiorna i dati meteo
        }

        public void AggiornaDatiMeteo()
        {
            //commentate perchè c'è un limite di richieste al servizio meteo, usiamo l'xml già fatto
            /* if (Città != null)
             {
                 _xmlDati.Load("http://api.openweathermap.org/data/2.5/forecast/city?q=" + Città + "&APPID=3468347b36b867d8ef1978a625d84616&mode=xml");
                 _xmlDati.Save("DatiMeteo.xml");
             }*/
        }

        public double GetTemperatura()
        {
            return GetDato("temperature");
        }

        public double GetPrecipitazioni()
        {
            return GetDato("precipitation");
        }

        private double GetDato(string datoRichiesto)  //funzione generica per prendere temperatura o precipitazioni
        {
            double dato = 0;

            XPathDocument doc = new XPathDocument("DatiMeteo.xml");
            XPathNavigator nav = doc.CreateNavigator();

            XPathExpression expr = nav.Compile("./weatherdata/forecast/time/" + datoRichiesto);
            XPathNodeIterator iterator = nav.Select(expr);

            int i = 0;

            while (iterator.MoveNext())
            {
                if (i == 7) //stabilisce quale "intervallo" di 3 ore parsare
                {
                    if (iterator.Current.HasAttributes)
                        dato = double.Parse(iterator.Current.GetAttribute("value", ""), CultureInfo.InvariantCulture);
                    break;
                }
                i++;
            }

            return dato;
        }
    }
}
