using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    public class Giardino
    {
        public event EventHandler Changed;

        private Cisterna _cisterna;
        private Settori _settori;
        private string _luogo;

        public Giardino(string luogo = null)
        {
            _luogo = luogo;
            _cisterna = new Cisterna();
            _settori = new Settori();
        }

        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty); //aggiorna la view
        }


        public Settori Settori
        {
            get { return _settori; }
            set
            {
                _settori = value;
                OnChanged();
            }
        }


        public string Luogo
        {
            get { return _luogo; }
            set
            {
                _luogo = value;
                OnChanged();
            }
        }

        public Cisterna Cisterna
        {
            get { return _cisterna; }
        }

        public void Reset()
        {
            _luogo = "";
            _cisterna = new Cisterna();
            _settori = new Settori();
        }
    }
}
