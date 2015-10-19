using System.Globalization;
using System.Xml;
using System.Xml.XPath;

namespace SmartGarden
{
    abstract class FornitoreInformazioniMeteo
    {
        private XmlDocument _xmlDati;
        private int _numeroIntervalloTempo = 8; //di default il meteo prende le informazioni di 24 ore dopo (3 ore a intervallo, 8° intervallo->24h)
        public string Città { get; set; }

        public FornitoreInformazioniMeteo(string città)
        {
            Città = città;
            _xmlDati = new XmlDocument();
            AggiornaDatiMeteo(); //appena creato aggiorna i dati meteo
        }

        public void AggiornaDatiMeteo()
        {
            //commentate perchè c'è un limite di richieste al servizio meteo, usiamo l'xml già fatto
             if (Città != null)
             {
                 _xmlDati.Load("http://api.openweathermap.org/data/2.5/forecast/city?q=" + Città + "&APPID=3468347b36b867d8ef1978a625d84616&mode=xml");
                 _xmlDati.Save("DatiMeteo.xml");
             }
        }

        public int NumeroIntervalloTempo
        {
            set
            {
                if (value >= 0)
                    _numeroIntervalloTempo = value;
            }
        }

        abstract public double GetInformazione();  //metodo che ogni classe ridefinisce

        protected double GetDato(string datoRichiesto)  //funzione generica per prendere dati
        {
            double dato = 0;

            XPathDocument doc = new XPathDocument("DatiMeteo.xml");
            XPathNavigator nav = doc.CreateNavigator();

            XPathExpression expr = nav.Compile("./weatherdata/forecast/time/" + datoRichiesto);
            XPathNodeIterator iterator = nav.Select(expr);

            int i = 0;

            while (iterator.MoveNext())
            {
                if (i == _numeroIntervalloTempo) //stabilisce quale "intervallo" di 3 ore parsare
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
