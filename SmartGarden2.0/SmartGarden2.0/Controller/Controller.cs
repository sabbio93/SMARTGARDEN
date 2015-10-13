using System;
using System.Windows.Forms;

namespace SmartGarden2._0.Control
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
            MessageBox.Show("cambia ok " + nomeSettore);
        }

        internal void CaricaInfoGiardino()
        {
            _gestioneGiardino.ProvaCaricamentoInfo();
        }

        internal void SettaTimer()
        {
            _gestioneGiardino.SettaTimer();
        }

        internal void CaricaTreeView()
        {
            _gestioneGiardino.CaricaTreeView();
        }
    }
}
