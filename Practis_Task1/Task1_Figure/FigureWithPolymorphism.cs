using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_Figure
{
    public abstract class FigureWithPolymorphism
    {
        public double CenterCoordinates { get; set; }

        public FigureWithPolymorphism(double centetCoordinates)
        {
            this.CenterCoordinates = centetCoordinates;
        }

        public abstract void Draw();
    }
}
