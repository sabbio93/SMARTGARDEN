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
    }
}
