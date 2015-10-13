using System;
using System.Reactive.Linq;

namespace SmartGarden2._0
{
    public class MyTimer
    {
        public IObservable<long> GetTimerPerValvola(int seconds)
        {
            var timer = Observable.Timer(TimeSpan.FromSeconds(seconds));
            return timer;
        }

        public IObservable<long> GetTimerIrrigazone(int seconds)
        {
            var timer = Observable.Timer(TimeSpan.FromSeconds(seconds));
            return timer;
        }
    }
}
