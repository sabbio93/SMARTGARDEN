using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGarden2._0
{
    class FabbisogniGiornalieriPeriodo
    {
        private List<FabbisognoGiornalieroPeriodo> _fabbisogni;

        public FabbisogniGiornalieriPeriodo()
        {
            _fabbisogni = new List<FabbisognoGiornalieroPeriodo>();
        }

        public List<FabbisognoGiornalieroPeriodo> FabbisogniGiornalieri
        {
            get
            {
                return _fabbisogni;
            }
        }
    }
}
