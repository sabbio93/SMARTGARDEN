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
            if (sender == GestoreGiardino)
            {
                _textBox.Text += "Temperatura di domani, Modena: " + GestoreGiardino.Temperatura + "°C\r\n";
                _textBox.Text += "Precipitazioni di domani, Modena: " + GestoreGiardino.Precipitazioni + " mm\r\n";

                if(GestoreGiardino.Settori != null)
                {
                    _textBox.Text += "\r\nSettori di giardino: \r\n" + GestoreGiardino.Settori.ToString() + "\r\n";
                    
                    foreach(Settore s in GestoreGiardino.Settori.ListaSettori)
                    {
                        _textBox.Text += "Piante presenti in settore " + s.Nome +": \r\n" + s.Piante.ToString();
                    }
                }

            }
        }

        private void _caricaSettoriButton_Click(object sender, EventArgs e)
        {
            Controller.CaricaSettori();
        }
    }
}
