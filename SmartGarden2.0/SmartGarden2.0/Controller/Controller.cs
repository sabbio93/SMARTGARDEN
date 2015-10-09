using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden2._0.Control
{
    class Controller
    {
        private readonly GestioneGiardino _gestioneGiardino; //GestioneGiardino è il model

        public Controller(GestioneGiardino gestioneGiardino)
        {
            _gestioneGiardino = gestioneGiardino;
        }

        public void CreateLoginForm()
        {
            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //carica schermata principale
                    Piante piante = new Piante();
                    piante.ListaPiante.Add(new Pianta("Pomodoro", "Solanum lycopersicum"));
                    piante.ListaPiante.Add(new Pianta("Lattuga", "Lactuca sativa"));
                    foreach (Pianta pianta in piante.ListaPiante)
                    {
                        _textBox.Text += pianta.NomeBotanico + "\r\n";
                    }
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
