using SmartGarden2._0.Control;
using System;
using System.Windows.Forms;

namespace SmartGarden2._0
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

            controller.CaricaInfoGiardino();
        }
    }
}
