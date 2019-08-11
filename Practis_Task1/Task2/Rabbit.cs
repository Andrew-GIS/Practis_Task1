using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practis_Task1.Task2
{
    class Rabbit
    {
        public int locationX { get; set; }

        public int locationY { get; set; }

        public Random random = new Random();

        public delegate void LocationInfo(int locationX, int locationY);

        public event LocationInfo NewRabbitLocation;
        
        public void RabbitMoving()
        {
            while(true)
            {
                this.locationX = random.Next(1, 10);
                this.locationY = random.Next(1, 10);
                this.EventHandle(this.locationX, this.locationY);
                Thread.Sleep(random.Next(500, 1000));
            }
        }

        public void EventHandle(int locationX, int locationY)
        {
            this.NewRabbitLocation.Invoke(locationX, locationY);
        }
    }
}
