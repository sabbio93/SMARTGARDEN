
using SmartGarden.View;
using System;
using System.Windows.Forms;
using System.Xml.XPath;

namespace SmartGarden.Control
{
    public class Controller
    {
        private readonly GestioneGiardino _gestioneGiardino; //GestioneGiardino è il model

        public Controller(GestioneGiardino gestioneGiardino)
        {
            _gestioneGiardino = gestioneGiardino;
        }

        public bool CreateLoginForm()
        {
            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal void CambiaViewSettore(string nomeSettore)
        {

            Settore settore = _gestioneGiardino.Giardino.Settori.TrovaSettore(nomeSettore);

            using (var pianteForm = new Form())
            {
                PianteView pianteView = new PianteView(settore);
                pianteView.Dock = DockStyle.Fill;
                pianteForm.Text = "Piante di " + settore.Nome;
                pianteForm.Size = new System.Drawing.Size(1000,400);
                pianteForm.Controls.Add(pianteView);
                pianteForm.ShowDialog();
            }
        }

       internal void CambiaProvincia(string provincia)
        {
            _gestioneGiardino.Giardino.Luogo = provincia;
            _gestioneGiardino.AggiornaInfoMeteo();
        }

        internal void CaricaProvinceComboBox(ComboBox provinceComboBox)
        {
            XPathDocument doc = new XPathDocument("ProvinceItaliane.xml");
            XPathNavigator nav = doc.CreateNavigator();

            XPathExpression expr = nav.Compile("./italia/provincia");
            XPathNodeIterator iterator = nav.Select(expr);


            while (iterator.MoveNext())
            {
                provinceComboBox.Items.Add(iterator.Current.Value);
            }
        }

        internal void CaricaInfoGiardino()
        {
            _gestioneGiardino.ProvaCaricamentoInfo();
        }

        internal void SettaTimer()
        {
            _gestioneGiardino.SettaTimer();
        }

        internal void GestisciSettori()
        {
            throw new NotImplementedException();
        }

        internal void NuovoGiardino()
        {
            //*TO DO* cancella giardino
            using (var nuovoGiardinoForm = new Form())
            {
                NuovoGiardinoView nuovoGiardinoView = new NuovoGiardinoView();
                nuovoGiardinoView.Dock = DockStyle.Fill;
                nuovoGiardinoForm.Text = "Nuovo giardino";
                nuovoGiardinoForm.Size = new System.Drawing.Size(380, 170);
                nuovoGiardinoForm.Controls.Add(nuovoGiardinoView);

                var result = nuovoGiardinoForm.ShowDialog();

                if(result == DialogResult.OK)
                {
                    _gestioneGiardino.ResetGiardino();
                    _gestioneGiardino.Giardino.Luogo = nuovoGiardinoView.Controls.Find("_provinceComboBox", false)[0].Text;
                    _gestioneGiardino.AggiornaInfoMeteo();
                }
            }
        }
    }
}
