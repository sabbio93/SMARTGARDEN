using System;

namespace SmartGarden2._0
{
    public class GestioneGiardino : IObserver<long>
    {
        private Giardino _giardino;
        public event EventHandler Changed;
        private IDisposable _unsubscriber;

        public GestioneGiardino()
        {
            _giardino = new Giardino();
        }
        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty); //aggiorna la view
        }
        
        public virtual void Subscribe(IObservable<long> provider)
        {
            _unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }

        public void OnNext(long value)
        {
            //inizio irrigazione
        }

        public void OnError(Exception error)
        {
           //nothing
        }

        public void OnCompleted()
        {
            //nothing
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
        private Piante _piante = new Piante();
        private Pianta _pianta1 = new Pianta("Pomodoro", "EGhh efcds");
        private Pianta _pianta2 = new Pianta("Lattuga", "GGhhf vvvvv");

        public void ProvaCaricamentoInfo()
        {
            FornitoreInformazioniMeteo fornitorePrec = new FornitorePrecipitazioni("Modena");
            FornitoreInformazioniMeteo fornitoreTemp = new FornitoreTemperatura("Modena");
            _temp = fornitoreTemp.GetInformazione();
            _prec = fornitorePrec.GetInformazione();
            
            _piante.ListaPiante.Add(_pianta1);
            _piante.ListaPiante.Add(_pianta2);
            _settore1.Piante = _piante;
            _settori.ListaSettori.Add(_settore1);
            _settori.ListaSettori.Add(_settore2);
            _giardino.Settori = _settori;

            _giardino.Cisterna.Capienza = 10;
            _giardino.Cisterna.Portata = 20;

            OnChanged();
        }

        public Giardino Giardino
        {
            get { return _giardino; }
        }
        #endregion
    }
}