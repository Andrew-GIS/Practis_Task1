using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    public class Pong
    {
        public event EventHandler PongEvent;

        protected virtual void OnPong(EventArgs e)
        {
            //if (pongAction != null)
            //    pongAction(this, e);
            this.PongEvent?.Invoke(this, e);
        }

        public void DoPong()
        {
            Console.WriteLine($"Pong is done ...{Environment.NewLine}");
            Thread.Sleep(1000);
            this.OnPong(new EventArgs());
        }
    }
}
