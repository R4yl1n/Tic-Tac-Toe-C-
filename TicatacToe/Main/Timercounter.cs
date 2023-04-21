using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Runtime.InteropServices.ComTypes;

namespace Main
{
    internal class Timecounter
    {
        private int seconds = 0;
        private bool running = false;


        public void StartTimer()
        {
            Thread thread = new Thread(Count);
            running = true;
            thread.Start();
        }

        public void StopTimer()
        {
            running = false;
            Console.WriteLine($"you won this game after {seconds} seconds");
        }

        private void Count()
        {
            while (running)
            {
                seconds++;
                Thread.Sleep(1000);
            }
        }
    }
}
