﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    class PiantaFactory
    {
       private static readonly Dictionary<string,IDataFlyweight> _piante= new Dictionary<string, IDataFlyweight>();

        public static IDataFlyweight GetDatiPianta(string NomeBotanico,string NomeComune)
        {
            if (!_piante.ContainsKey(NomeBotanico))
            {
                _piante.Add(NomeBotanico, new DatiPiantaFlyweight(NomeComune,NomeBotanico));
            }

            return _piante[NomeBotanico];
        }

        public static IDataFlyweight GetDatiPianta(string key)
        {
            if (!_piante.ContainsKey(key))
            {
                _piante.Add(key,Createinstance(key));
            }
            
                return _piante[key];
        }
        //TODO interrogo database e trovo pianta con caratteristiche
        private static IDataFlyweight Createinstance(string key)
        {
            return new DatiPiantaFlyweight("", "");
        }


        private class DatiPiantaFlyweight : IDataFlyweight
        {
            private string _nomeComune;
            private string _nomeBotanico;
            private List<FabbisognoGiornalieroPeriodo> _fabisogni;
            
            public DatiPiantaFlyweight(string nomeComune,string nomeBotanico)
            {
                _nomeBotanico = nomeBotanico;
                _nomeComune = nomeComune;
                _fabisogni = new List<FabbisognoGiornalieroPeriodo>();
            }

            public string NomeComune
            {
                get
                {
                    return _nomeComune;
                }
            }

            public string NomeBotanico
            {
                get
                {
                    return _nomeBotanico;
                }
            }

            public List<FabbisognoGiornalieroPeriodo> Fabisogni
            {
                get
                {
                    return _fabisogni;
                }
            }

            public void addFabisognoRelativoPeriodo(FabbisognoGiornalieroPeriodo fab)
            {
                _fabisogni.Add(fab);
            }

        }
    }
}
