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
            Determine_Symvol();
        }

        public static void Determine_Symvol()
        {
            Console.WriteLine("Inpute some symvols ");
            string test = Console.ReadLine();
            Console.WriteLine("Symvols that you want to found ");
            char found = Convert.ToChar(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < test.Length; i++)
            {
                //Console.Write(test[i]);
                if (test[i] == found)
                {
                    counter++;
                }
                
            }
            Console.Write($"Number of duplicate symvol = {counter}");
        }

    }
}      


           



   

