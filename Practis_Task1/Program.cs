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
            int num1 = 10;
            int num2 = 15;
            Console.WriteLine($"{num1} + {num2} = {Program.Sum(num1, num2)}");
            Console.ReadLine();
        }

        static int Sum(int x, int y)
        {
            return x + y;
        }
            
    }

   
}
