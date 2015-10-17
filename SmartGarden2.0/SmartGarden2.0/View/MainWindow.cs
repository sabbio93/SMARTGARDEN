
using SmartGarden.Control;
using System;
using System.Windows.Forms;

namespace SmartGarden
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GestioneGiardino gestoreGiardino = new GestioneGiardino();
            Controller controller = new Controller(gestoreGiardino);

            bool loginOk = controller.CreateLoginForm();
            if (!loginOk)
                this.Close();
            
            _pannelloDestra.GestoreGiardino = gestoreGiardino; //set del model
            _pannelloDestra.Controller = controller; //set del controller
            _treeView.GestoreGiardino = gestoreGiardino;
            _treeView.Controller = controller;

            _dateStatusBar.Text = DateTime.Now.ToShortDateString();

            controller.SettaTimer();

            controller.CaricaTreeView();

            controller.CaricaInfoGiardino();

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
