using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1._2
{
    class PingPongEventArgs : EventArgs
    {
        public delegate void EventDelegate(object sender, PingPongEventArgs e);

        private DateTime EventTime;

        public PingPongEventArgs(DateTime eventTime)
        {
            this.EventTime = eventTime;
        }

        public virtual string ToString()
        {
            return EventTime.ToString();
        }
    }
}
