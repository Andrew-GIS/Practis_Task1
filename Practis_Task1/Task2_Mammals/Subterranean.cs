using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Mammals
{
    class Subterranean: Mammals
    {
        public Subterranean(double weight) :
            base(weight)
        {
        }
        public override void Eat()
        {
            Console.WriteLine($"Inpute age of your {GetType().Name}");
            double age = Convert.ToDouble(Console.ReadLine());
            if (age < 0.40)
            {
                Console.WriteLine($"{GetType().Name} takes milk as food");
                Weight = Weight + 2;
                Console.WriteLine($"Weight = {Weight}");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} takes other little mammals as food");
                Weight = Weight + 2;
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
