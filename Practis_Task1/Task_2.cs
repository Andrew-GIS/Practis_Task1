using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Task_2
    {
        public static void ConvertOfCurency()
            //
            //Convert of Curency.
            //
        {
            const decimal UAH_cource = 1;
            const decimal Dollar_cource = 0.037m;
            const decimal Euro_cource = 0.33m;
            string curensy = Curensy();
            Console.WriteLine(Converting(Dollar_cource, Euro_cource, curensy));
        }
        public static string Curensy()
        {
            while (true)
            {
                Console.WriteLine("Inpute in what curensy you want to display you UAH (dollar/euro)");
                string curensy = Console.ReadLine();
                if (curensy == "dollar"|| curensy=="euro")
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Inpute coorect curensy");
                    continue;
                }
                return curensy;
            }
            
        }
        public static decimal Converting(decimal Dollar_cource, decimal Euro_cource, string curensy)
        {
            Console.WriteLine("Inpute numbers of UAH");
            decimal quantity = Convert.ToDecimal(Console.ReadLine());
            decimal resultOfConvert = 0;
            if (curensy == "dollar")
            {
                resultOfConvert = quantity * Dollar_cource;
            }
            if (curensy == "euro")
            {
                resultOfConvert = quantity * Euro_cource;
            }
            return resultOfConvert;
        }
    }
}
