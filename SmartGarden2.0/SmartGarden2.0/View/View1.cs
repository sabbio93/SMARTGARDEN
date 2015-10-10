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
            }
        }
    }
}
