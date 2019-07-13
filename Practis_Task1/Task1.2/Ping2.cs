using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Practis_Task1.Task1._2.PingPongEventArgs;

namespace Practis_Task1.Task1._2
{
    class Ping2
    {
        //public delegate void pingDelegate(object sender, PingPongEventArgs e);

        public event EventDelegate pingEvent2;

        protected virtual void OnPing2(PingPongEventArgs e)
        {
            if (pingEvent2 != null)
                pingEvent2(this, e);
        }

        public void DoPing2()
        {
            Console.WriteLine($"Ping is done ...{Environment.NewLine}");
            Thread.Sleep(1000);
            this.OnPing2(new PingPongEventArgs(DateTime.Now));
        }
    }
}
