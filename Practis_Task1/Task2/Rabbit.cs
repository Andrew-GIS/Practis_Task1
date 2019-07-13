using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    class Rabbit
    {
        private int locationX { get; set; }
        private int locationY { get; set; }

        public Rabbit(int longitude, int latitude)
        {
            this.locationX = longitude;
            this.locationY = latitude;
        }

        public void ChengeLocation(int locationX, int locationY)
        {
            Random rnd = new Random();
            locationX = rnd.
        }
    }
}
