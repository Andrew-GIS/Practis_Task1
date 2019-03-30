using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your radius");
            string radiusString = Console.ReadLine();
            int.TryParse(radiusString, out int radius);
            Console.WriteLine($"The square of the round {Program.PerformCalcul(radius)}");
            Console.ReadKey();
        }
        public static decimal PerformCalcul(int r)
        { 
            const decimal Pi = 3.14m;

            decimal square = Pi * r * r;

            return square;
        }
    }
   
}
