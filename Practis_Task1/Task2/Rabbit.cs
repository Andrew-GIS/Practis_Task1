using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Practis_Task1.Task2
{
    public delegate void LocationInfo(CoordinateEventArgs e);

    public class Rabbit
    {
        private int LocationX { get; set; }

        private int LocationY { get; set; }

        public event LocationInfo NewRabbitLocation;

        public Rabbit()
        {
            this.LocationX = 0;
            this.LocationY = 0;
        }

        public void RabbitMoving()
        {
            var random = new Random();
            while (true)
            {
                this.LocationX = random.Next(1, 10);
                this.LocationY = random.Next(1, 10);
                this.EventHandle(new CoordinateEventArgs(this.LocationX, this.LocationY));
                Thread.Sleep(500);
            }
        }

        public void EventHandle(CoordinateEventArgs e)
        {
            this.NewRabbitLocation?.Invoke(e);
        }
    }

}
