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


        //codice di prova
        private double _temp, _prec;

        public double Temperatura
        {
            get { return _temp; }
        }

        public double Precipitazioni
        {
            get { return _prec; }
        }

        public void ProvaCaricamentoInfoMeteo()
        {
            FornitoreInformazioniMeteo fornitorePrec = new FornitorePrecipitazioni("Modena");
            FornitoreInformazioniMeteo fornitoreTemp = new FornitoreTemperatura("Modena");
            _temp = fornitoreTemp.GetInformazione();
            _prec = fornitorePrec.GetInformazione();
            
            OnChanged();
        }
    }
}