using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Mammals
{
    public class Arboreal: Mammals
    {
        public Arboreal(double weight) :
            base(weight)
        {
        }
        public override void Eat()
        {
            Console.WriteLine($"Inpute age of your {GetType().Name}");
            double age = Convert.ToDouble(Console.ReadLine());
            if (age < 0.50)
            {
                Console.WriteLine($"{GetType().Name} takes milk as food");
                Weight = Weight + 5;
                Console.WriteLine($"Weight = {Weight}");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} takes plants or other little mammals as food");
                Weight = Weight + 5;
                Console.WriteLine($"Weight = {Weight}");
            }
        }

        public override void Move()
        {
            string move = "Type of moving: Crawling or Climbing on trees";
            Console.WriteLine(move);
        }
    }
}
