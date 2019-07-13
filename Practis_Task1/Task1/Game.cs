using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    class Game
    {
        private Ping ping; 
        private Pong pong; 

        public Game()
        {
            this.ping = new Ping();
            this.pong = new Pong();

            ping.pingEvent += OnPingInvoke;
            pong.pongEvent += OnPongInvoke;

            ping.DoPing();
        }

        public void OnPingInvoke(object sender, EventArgs e)
        {
            this.pong.DoPong();
        }

        public void OnPongInvoke(object sender, EventArgs e)
        {
            this.ping.DoPing();
        }
    }
}
