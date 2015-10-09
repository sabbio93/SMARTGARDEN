using SmartGarden2._0.Control;
using SmartGarden2._0.Controller;
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
    public partial class MainWindow : Form
    {
        private GestioneGiardino _gestioneGiardino;
        private Controller _controller;

        public MainWindow()
        {
            InitializeComponent();
            _gestioneGiardino = new GestioneGiardino();
            _controller = new Controller(_gestioneGiardino);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _controller.CreateLoginForm();
          
        }
    }
}
