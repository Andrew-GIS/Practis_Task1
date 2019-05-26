using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Mammals
{
    class Arial: Mammals
    {
        public Arial(double weight) :
            base(weight)
        {
        }
        public override void Eat()
        {
            Console.WriteLine($"Inpute age of your {GetType().Name}");
            double age = Convert.ToDouble(Console.ReadLine());
            if (age < 0.80)
            {
                Console.WriteLine($"{GetType().Name} takes milk as food");
                Weight = Weight + 3;
                Console.WriteLine($"Weight = {Weight}");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} takes other little mammals as food");
                Weight = Weight + 3;
                Console.WriteLine($"Weight = {Weight}");
            }
        }

        public override void Move()
        {
            string move = "Type of moving: Crawling in some caves and other dark and weat places, can make managed fall";
            Console.WriteLine(move);
        }
    }
}
