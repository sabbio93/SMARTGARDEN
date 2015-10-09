using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden2._0
{
    public partial class MainWindow : Form //mainform sarà GestioneGiardino mi sa
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            using(var loginForm = new LoginForm()){
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    //carica schermata principale
                    Piante piante = new Piante();
                    piante.ListaPiante.Add(new Pianta("Pomodoro", "Solanum lycopersicum"));
                    piante.ListaPiante.Add(new Pianta("Lattuga", "Lactuca sativa"));
                    foreach (Pianta pianta in piante.ListaPiante) {
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
