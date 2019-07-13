using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Practis_Task1.Task1._2.PingPongEventArgs;

namespace Practis_Task1.Task1._2
{
    class Pong2
    {
        //public delegate void pongDelegate(object sender, PingPongEventArgs e);

        public event EventDelegate pongEvent2;

        protected virtual void OnPong2(PingPongEventArgs e)
        {
            if (pongEvent2 != null)
                pongEvent2(this, e);
        }

        public void DoPong2()
        {
            Console.WriteLine($"Pong is done ...{Environment.NewLine}");
            Thread.Sleep(1000);
            this.OnPong2(new PingPongEventArgs(DateTime.Now));
        }
    }
}
