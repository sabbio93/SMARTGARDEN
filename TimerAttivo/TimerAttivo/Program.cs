using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerAttivo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTimer timer = new MyTimer();
            Settore Settore1 = new Settore("uno");
            Settore Settore2 = new Settore("due");

            timer.SetTimerPerSettore(1000, 1000, "uno", Settore1.getOpenMethodSettore(), Settore1.getCloseMethodSettore());
            timer.SetTimerPerSettore(2000, 3000, "due", Settore2.getOpenMethodSettore(), Settore2.getCloseMethodSettore());
            Console.ReadLine();
        }
    }
}
