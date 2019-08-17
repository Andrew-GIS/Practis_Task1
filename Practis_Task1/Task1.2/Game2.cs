using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1._2
{
    class GamePartSecond
    {
        private PingSecond ping;
        private PongSecond pong;

        public GamePartSecond()
        {
            this.ping = new PingSecond();
            this.pong = new PongSecond();

            ping.PingEventSecond += OnPingInvoke;
            pong.PongEventSecond += OnPongInvoke;

            ping.DoPingSecond();
        }

        public void OnPingInvoke(object sender, PingPongEventArgs e)
        {
            Console.WriteLine(e.ToString());
            this.pong.DoPongSecond();
        }

        public void OnPongInvoke(object sender, PingPongEventArgs e)
        {
            Console.WriteLine(e.ToString());
            this.ping.DoPingSecond();
        }
    }
}
