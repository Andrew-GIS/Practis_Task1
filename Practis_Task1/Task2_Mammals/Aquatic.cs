using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Mammals
{
    class Aquatic: Mammals
    {
        public Aquatic(double weight) :
            base(weight)
        {
        }
        public override void Eat()
        {
            Console.WriteLine($"Inpute age of your {GetType().Name}");
            double age = Convert.ToDouble(Console.ReadLine());
            if (age < 0.30)
            {
                Console.WriteLine($"{GetType().Name} takes milk as food");
                Weight = Weight + 4;
                Console.WriteLine($"Weight = {Weight}");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} takes plants or other little mammals as food");
                Weight = Weight + 4;
                Console.WriteLine($"Weight = {Weight}");
            }
        }

        public override void Move()
        {
            string move = "Type of moving: Crawling near waterline (seaside, riverside and etc) or Swimming in the water";
            Console.WriteLine(move);
        }
    }
}
