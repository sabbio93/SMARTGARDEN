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
                    //carica utente e schermata principale
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
