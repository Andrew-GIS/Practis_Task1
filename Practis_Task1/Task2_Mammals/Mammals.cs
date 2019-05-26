using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Mammals
{
    public abstract class Mammals
    {
        public double Weight { get; set; }

        public Mammals(double weight)
        {
            Weight = weight;
        }

    public abstract void Eat();

    public abstract void Move();
        
    }
}
