using System;

namespace SmartGarden2._0
{
    public class Valvola : IObserver<long>
    {
        private String _name;
        private IDisposable _unsubscriber;

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public virtual void Subscribe(IObservable<long> provider)
        {
            _unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("La gestione della valvola non sarà più disponibile");
        }

        public virtual void OnError(Exception error)
        {
            // Do nothing.
        }

        public void OnNext(long value)
        {
            Console.WriteLine("Valvola " + _name + ": mi apro");
        }
    }
}
