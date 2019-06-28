using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Mammals
{
    class Terrestrial: Mammals
    {
        public Terrestrial(double weight) :
            base(weight)
        {
        }
        public override void Eat()
        {
            Console.WriteLine($"Inpute age of your {GetType().Name}");
            double age = Convert.ToDouble(Console.ReadLine());
            if (age < 0.20)
            {
                Console.WriteLine($"{GetType().Name} takes milk as food");
                Weight = Weight + 1;
                Console.WriteLine($"Weight = {Weight}");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} takes other little mammals as food");
                Weight = Weight + 1;
                Console.WriteLine($"Weight = {Weight}");
            }
        }

        public override void Move()
        {
            string move = "Type of moving: Crawling in Ground";
            Console.WriteLine(move);
        }
    }
}
