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
            //Console.WriteLine("Input your radius");
            //string radiusString = Console.ReadLine();
            //int.TryParse(radiusString, out int radius);
            //Console.WriteLine($"The square of the round {Program.PerformCalcul(radius)}");
            //Console.ReadKey();
            //task 1
            int uberful = 5;
            int _Identifier = 4;
            int \u006fldenifier;
            int myVariab1le;
            double pi = 3.141592653;
            double e = 2.7182818284590452;
            Console.WriteLine($"Pi = {pi}, E = {e}");
            string first = "\nмоя строка 1";
            string second = "\tмоя строка 2";
            string third = "\aмоя строка 3";
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);

        }
        public static decimal PerformCalcul(int r)
        { 
            const decimal Pi = 3.14m;

            decimal square = Pi * r * r;

            return square;
        }
    }

   
}
