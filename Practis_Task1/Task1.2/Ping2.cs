using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Practis_Task1.Task1._2.PingPongEventArgs;

namespace Practis_Task1.Task1._2
{
    class PingSecond
    {
        public event EventDelegate PingEventSecond;

        protected virtual void OnPing2(PingPongEventArgs e)
        {
            if (this.PingEventSecond != null)
                this.PingEventSecond(this, e);
        }

        public void DoPingSecond()
        {
            Console.WriteLine($"Ping is done ...{Environment.NewLine}");
            Thread.Sleep(1000);
            this.OnPing2(new PingPongEventArgs(DateTime.Now));
        }
    }
}
