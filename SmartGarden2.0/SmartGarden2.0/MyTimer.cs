﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden2._0
{
    class MyTimer
    {
        public IObservable<long> GetTimerPerValvola(int seconds)
        {
            var timer = Observable.Timer(TimeSpan.FromSeconds(seconds));
            return timer;
        }
    }
}
