using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    public class CoordinateEventArgs : EventArgs
    {
        public int LocationX { get; set; }

        public int LocationY { get; set; }

        public CoordinateEventArgs(int locationX, int locationY)
        {
            this.LocationX = locationX;
            this.LocationY = locationY;
        }
    }
}
