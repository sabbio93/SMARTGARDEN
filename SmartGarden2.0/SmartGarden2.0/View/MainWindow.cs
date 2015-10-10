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

            _pannelloSinistra.GestoreGiardino = gestoreGiardino; //set del model
            _pannelloSinistra.Controller = controller; //set del controller




            //TEST

            // FornitoreDatiMeteo fornitore = new FornitoreDatiMeteo("Modena");

            FornitoreInformazioniMeteo fornitorePrec = new FornitorePrecipitazioni("Modena");
            FornitoreInformazioniMeteo fornitoreTemp = new FornitoreTemperatura("Modena");


            _textBox.Text += "Meteo di domani a Modena\r\n";

            double temp = fornitoreTemp.GetInformazione();
            _textBox.Text += "\r\nTemperatura: " + temp + "°C";

            double prec = fornitorePrec.GetInformazione();
            _textBox.Text += "\r\nPrecipitazioni: " + prec + " mm";
        }
    }
}
