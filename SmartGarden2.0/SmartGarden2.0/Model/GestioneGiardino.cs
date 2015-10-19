using System;
using TimerAttivo;

namespace SmartGarden
{
    public class GestioneGiardino
    {
        private Giardino _giardino;
        private MyTimer _timer = new MyTimer();

        public event EventHandler Changed;

        public GestioneGiardino()
        {
            _giardino = new Giardino("Modena");
        }

        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty); //aggiorna la view
        }

        public Giardino Giardino
        {
            get { return _giardino; }
        }

        public void SettaTimer()
        {
            _timer.SetTimer(10000, 5000, "Settore Nord", _settore1.OpenMethodSettore, _settore1.CloseMethodSettore);
            _timer.SetTimer(15000, 10000, "Settore Sud", _settore2.OpenMethodSettore, _settore2.CloseMethodSettore);
            _timer.SetTimer(2000, 10000, "TimerPrincipale", _giardino.Cisterna.SensorePressione.OpenMethodSensorePressione, _giardino.Cisterna.SensorePressione.CloseMethodSensorePressione);
        }

        public MyTimer MyTimer
        {
            get { return _timer; }
        }

        public void ResetGiardino()
        {
            _timer.Timers.Remove("TimerPrincipale");
            _giardino.Reset();
        }

        //codice di prova
        #region CodiceProva 

        private double _temp, _prec;

        public double Temperatura
        {
            get { return _temp; }
        }

        public double Precipitazioni
        {
            get { return _prec; }
        }


        private Settori _settori = new Settori();
        private Settore _settore1 = new Settore("Settore Nord");
        private Settore _settore2 = new Settore("Settore Sud");
        private Piante _piante1 = new Piante();
        private Piante _piante2 = new Piante();
        private Pianta _pianta1 = new Pianta("Pomodoro", "Solanum lycopersicum");
        private Pianta _pianta2 = new Pianta("Lattuga", "Lactuca sativa");
        private FornitoreInformazioniMeteo _fornitorePrec;
        private FornitoreInformazioniMeteo _fornitoreTemp;

        public void ProvaCaricamentoInfo()
        {

            AggiornaInfoMeteo();

            _pianta1.FabbisogniPianta.Add(new FabbisognoGiornalieroPeriodo(new DateTime(2015, 1, 1), new DateTime(2015, 12, 31), 40));
            _pianta2.FabbisogniPianta.Add(new FabbisognoGiornalieroPeriodo(new DateTime(2015, 1, 1), new DateTime(2015, 6, 30), 20));
            _pianta2.FabbisogniPianta.Add(new FabbisognoGiornalieroPeriodo(new DateTime(2015, 7, 1), new DateTime(2015, 12, 31), 100));

            _piante1.ListaPiante.Add(_pianta1);
            _piante1.ListaPiante.Add(_pianta2);
            _settore1.Piante = _piante1;
            _piante2.ListaPiante.Add(_pianta2);
            _settore2.Piante = _piante2;
            _settori.ListaSettori.Add(_settore1);
            _settori.ListaSettori.Add(_settore2);
            _giardino.Settori = _settori;

            _giardino.Cisterna.Capienza = 10;
            _giardino.Cisterna.Portata = 20;

            OnChanged();
        }

        public void AggiornaInfoMeteo()
        {
            _fornitorePrec = new FornitorePrecipitazioni(_giardino.Luogo);
            _fornitoreTemp = new FornitoreTemperatura(_giardino.Luogo);

            _temp = _fornitoreTemp.GetInformazione();
            _prec = _fornitorePrec.GetInformazione();

            OnChanged();
        }

        #endregion
    }
}