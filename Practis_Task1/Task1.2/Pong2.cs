using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Practis_Task1.Task1._2.PingPongEventArgs;

namespace Practis_Task1.Task1._2
{
     class PongSecond
    {
        public event EventDelegate PongEventSecond;

        protected virtual void OnPong2(PingPongEventArgs e)
        {
            if (this.PongEventSecond != null)
                this.PongEventSecond(this, e);
        }

        public void DoPongSecond()
        {
            Console.WriteLine($"Pong is done ...{Environment.NewLine}");
            Thread.Sleep(1000);
            this.OnPong2(new PingPongEventArgs(DateTime.Now));
        }
    }
}
