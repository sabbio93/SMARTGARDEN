using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Linq;

namespace TimerPassivo
{
    class Program
    {
        /*
        per poter utilizzare questo timer si deve prima installare il pacchetto RX e poi referenziarlo: Project>add Reference
        servono tutti sopratutto reactive.core e linq
        */

        static void Main(string[] args)
        {
            MyTimer timer = new MyTimer();

            Settore settore= new Settore();
            settore.Nome = "settore1";
        
            settore.setTimer(timer.GetTimerPerValvola(5));

            Settore settore2 = new Settore();
            settore2.Nome = "settore2";

            settore2.setTimer(timer.GetTimerPerValvola(7));

            Console.ReadLine();
        }
    }
}
