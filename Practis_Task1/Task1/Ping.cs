using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    class Ping
    {
        public event EventHandler pingEvent;

        protected virtual void OnPing(EventArgs e)
        {
            if (pingEvent != null)
                pingEvent(this, e);
        }

        public void DoPing()
        {
            Console.WriteLine($"Ping is done ...{Environment.NewLine}");
            Thread.Sleep(1000);
            this.OnPing(new EventArgs());
        }
    }
}
