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
        private Pong2 pong;

        public GamePartSecond()
        {
            this.ping = new PingSecond();
            this.pong = new Pong2();

            ping.PingEvent2 += OnPingInvoke;
            pong.PongEvent2 += OnPongInvoke;

            ping.DoPing2();
        }

        public void OnPingInvoke(object sender, PingPongEventArgs e)
        {
            Console.WriteLine(e.ToString());
            this.pong.DoPong2();
        }

        public void OnPongInvoke(object sender, PingPongEventArgs e)
        {
            Console.WriteLine(e.ToString());
            this.ping.DoPing2();
        }
    }
}
