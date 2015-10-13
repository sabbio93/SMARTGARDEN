using System;

namespace SmartGarden2._0
{
    public class Valvola
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

        public void Apri(object sender, EventArgs e)
        {
            Console.WriteLine("sono : " + _name + " mi apro");
        }

        public void Chiudi(object sender, EventArgs e)
        {
            Console.WriteLine("sono : " + _name + " mi chiudo");
        }
    }
}
