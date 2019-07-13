using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1._2
{
    class Game2
    {
        private Ping2 ping;
        private Pong2 pong;

        public Game2()
        {
            this.ping = new Ping2();
            this.pong = new Pong2();

            ping.pingEvent2 += OnPingInvoke;
            pong.pongEvent2 += OnPongInvoke;

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
