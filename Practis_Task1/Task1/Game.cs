using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    public class Game
    {
        private readonly Ping ping; 
        private readonly Pong pong; 

        public Game()
        {
            this.ping = new Ping();
            this.pong = new Pong();

            this.ping.PingEvent += OnPingInvoke;
            this.pong.PongEvent += OnPongInvoke;

            this.ping.DoPing();
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
