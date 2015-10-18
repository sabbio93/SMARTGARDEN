using System;
using SmartGarden.View;
using System.IO;
using System.Xml.XPath;

namespace SmartGarden2._0.View
{
    public partial class CambiaProvinciaView : MainView
    {
        private string _provinciaSelezionata = "";

        public CambiaProvinciaView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            XPathDocument doc = new XPathDocument("ProvinceItaliane.xml");
            XPathNavigator nav = doc.CreateNavigator();

            XPathExpression expr = nav.Compile("./italia/provincia");
            XPathNodeIterator iterator = nav.Select(expr);
            

            while (iterator.MoveNext())
            {

            }

        }

        public string ProvinciaSelezionata
        {
            get { return _provinciaSelezionata; }
        }
    }
}
