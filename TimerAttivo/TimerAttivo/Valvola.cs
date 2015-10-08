using System;

namespace TimerAttivo
{
    internal class Valvola
    {
        String _name;

        public Valvola(String name)
        {
            _name = name;
        }

        public void apro(object sender, EventArgs e)
        {
            Console.WriteLine("sono : " + _name + " mi apro");
        }

        public void chiudo(object sender, EventArgs e)
        {
            Console.WriteLine("sono : " + _name + " mi chiudo");
        }
    }
}