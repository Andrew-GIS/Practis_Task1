using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    public class Ping
    {
        public event EventHandler PingEvent;

        protected virtual void OnPing(EventArgs e)
        {
            if (this.PingEvent != null)
                this.PingEvent(this, e);
        }

        public void DoPing()
        {
            Console.WriteLine($"Ping is done ...{Environment.NewLine}");
            Thread.Sleep(1000);
            this.OnPing(new EventArgs());
        }
    }
}
