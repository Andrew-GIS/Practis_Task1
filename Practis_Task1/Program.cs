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
            int i1 = 455;
            int i2 = 84500;
            decimal dec = 7.98845m;

            //
            //приводим два числа типа int к типу short
            //
            Console.WriteLine((short)i1);
            Console.WriteLine((short)i2);
            //
            //приводим два числа типа decimal к типу int
            //
            Console.WriteLine((int)dec);
            Console.ReadLine ();
        }

    }

   
}
