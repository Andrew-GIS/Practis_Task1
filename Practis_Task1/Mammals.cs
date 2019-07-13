using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Mammals
    {
        public double age { get; }
        public double weight { get; private set; }

        public Mammals(double age, double weight)
        {
            this.age = age;
            this.weight = weight;
        }

        public void Eat(int foodAmount)
        {
            if (age > 1)
            {
                Console.WriteLine($"{GetType().Name} takes milk as food");
                if (foodAmount < 5)
                {
                    Console.WriteLine($"{GetType().Name} have not enough milk to grow");
                }
                else if (foodAmount >= 5)
                {
                    weight += 1;
                    Console.WriteLine($"Enough milk for grow weight of {GetType().Name} became {weight}");
                }
            }
            else
            {
                Console.WriteLine($"{GetType().Name} takes meat or plants as food");
                if (foodAmount < 5)
                {
                    Console.WriteLine($"{GetType().Name} have not enough meat or plants to grow");
                }
                else if (foodAmount >= 5)
                {
                    weight += 1;
                    Console.WriteLine($"Enough meat or plants for grow weight of {GetType().Name} became {weight}");
                }
            }
        }
    }
}
