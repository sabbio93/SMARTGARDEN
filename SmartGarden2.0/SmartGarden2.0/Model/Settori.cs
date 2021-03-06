﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    public class Settori
    {
        private List<Settore> _listaSettori;

        public Settori()
        {
            _listaSettori = new List<Settore>();
        }

        public List<Settore> ListaSettori
        {
            get { return _listaSettori; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Settore settore in ListaSettori)
            {
                sb.AppendLine(settore.Nome);
            }

            return sb.ToString();
        }

        public Settore TrovaSettore(string nomeSettore)
        {
            foreach(Settore settore in _listaSettori)
            {
                if (nomeSettore == settore.Nome)
                    return settore;
            }

            return null;
        }

        public int NumeroPianteTotali()
        {
            int num = 0;

            foreach (Settore s in _listaSettori)
            {
                num += s.Piante.ListaPiante.Count;
            }

            return num;
        }

    }
}
