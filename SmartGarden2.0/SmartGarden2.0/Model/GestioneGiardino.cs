using System;

namespace SmartGarden2._0
{
    public class GestioneGiardino
    {
        private Giardino _giardino;
        public event EventHandler Changed;

        public GestioneGiardino()
        {
            _giardino = new Giardino();
        }

        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty); //aggiorna la view
        }


        /*Piante piante = new Piante();
        piante.ListaPiante.Add(new Pianta("Pomodoro", "Solanum lycopersicum"));
        piante.ListaPiante.Add(new Pianta("Lattuga", "Lactuca sativa"));
        foreach (Pianta pianta in piante.ListaPiante)
        {
            _textBox.Text += pianta.NomeBotanico + "\r\n";
        }*/
    }
}