using System;

namespace SmartGarden2._0.View
{
    public partial class View1 : View
    {
        public View1()
        {
            InitializeComponent();
        }

        protected override void OnModelChanged(object sender, EventArgs e)
        {
            //test
            if (sender == GestoreGiardino)
            {
                _textBox.Text += "Temperatura di domani, Modena: " + GestoreGiardino.Temperatura + "°C\r\n";
                _textBox.Text += "Precipitazioni di domani, Modena: " + GestoreGiardino.Precipitazioni + " mm\r\n";

                if(GestoreGiardino.Giardino.Settori != null)
                {
                    _textBox.Text += "Luogo giardino: " + GestoreGiardino.Giardino.Luogo;
                    _textBox.Text += "\r\nSettori di giardino: \r\n" + GestoreGiardino.Giardino.Settori.ToString() + "\r\n";
                    
                    foreach(Settore s in GestoreGiardino.Giardino.Settori.ListaSettori)
                    {
                        _textBox.Text += "Piante presenti in settore " + s.Nome +": \r\n" + s.Piante.ToString();
                    }
                }

                _textBox.Text += "\r\nCaratteristiche cisterna: Portata=" + GestoreGiardino.Giardino.Cisterna.Portata + "; Capacità=" + GestoreGiardino.Giardino.Cisterna.Capienza;

            }
        }

        private void _caricaSettoriButton_Click(object sender, EventArgs e)
        {
            Controller.CaricaSettori();
        }
    }
}
