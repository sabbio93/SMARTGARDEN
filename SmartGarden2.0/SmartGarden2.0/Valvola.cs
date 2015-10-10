using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerPassivo
{
    class Valvola : IObserver<long>
    {
        private String _name;
        private IDisposable unsubscriber;

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
            unsubscriber = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("Manage of Valvola would not be more available");
        }

        public virtual void OnError(Exception error)
        {
            // Do nothing.
        }

        public void OnNext(long value)
        {
            Console.WriteLine(_name + ":mi apro");
        }
    }
}
