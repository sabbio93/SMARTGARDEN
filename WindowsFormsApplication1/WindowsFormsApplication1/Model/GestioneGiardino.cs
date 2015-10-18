using System;


namespace SmartGarden
{
    class GestioneGiardino
    {
        private Giardino _giardino;
        public event EventHandler Changed;
        private MyTimer _timers;
        DateTime OraInizioInnaffiatura { get; }
        TimeSpan Intervallo { get; }

        public GestioneGiardino()
        {
            _giardino = new Giardino();
            _timers = new MyTimer();
            OraInizioInnaffiatura = DateTime.Now;
            TimeSpan ts;
            if(OraInizioInnaffiatura.Hour>19)
            {
                ts = new TimeSpan(1, 19, 0, 0);
            }
            else
            {
                ts = new TimeSpan(19, 0, 0);
            }
            OraInizioInnaffiatura = OraInizioInnaffiatura.Date + ts;
            Intervallo = new TimeSpan(1, 0, 0, 0);
        }

        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty); //aggiorna la view
        }

        private void IniziaInnaffiatura()
        {
            foreach(TurnoItem turno in _giardino.GetTurni())
            {
                foreach(IOpenClose openclose in turno.Mehtods)
                _timers.SetTimer(turno.Attesa, turno.Durata,openclose);
            }
        }
        
    }
}