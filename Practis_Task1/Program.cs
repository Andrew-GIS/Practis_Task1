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
            //Task1();
            //Task2();
            Task3();

        }
        public static void Task1()
        {
            //
            //C начала суток прошло N секунд. Найдите количесвто полных часов прошедших с начала суток.
            //
            Console.WriteLine("Input number of second");
            int second = Convert.ToInt32(Console.ReadLine());
            int hours = second / 3600;
            Console.WriteLine($"Number of hours = {hours}");
        }
        public static void Task2()
        {
            //
            //Даны 3 числа: A,B,C; Проверить истинность высказывания Данное число находиться между числами А и С.
            //
            Console.WriteLine("Input А value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input B value");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input C value");
            int c = Convert.ToInt32(Console.ReadLine());
            if (b < a && b > c)
            {
                Console.WriteLine("B value locate between A and C");
            }
            else if (b > a && b < c)
            {
                Console.WriteLine("B value locates between A and C");
            }
            else
            {
                Console.WriteLine("B value doesn't locate between A and C");
            }
            
        }
        public static void Task3()
        {
            //
            //Дано целое положительное число. Проверте истоинность высказывания: "Данное число являеться нечетным трехзнаным". 
            //
            Console.WriteLine("Input your value");
            double value = Convert.ToInt32(Console.ReadLine());
            if ((value / 100 > 1) && (value / 1000 < 1) && (value % 2 == 1))
            {
                Console.WriteLine("Your value is odd and with three-digit");
            }
            else
            {
                Console.WriteLine("Your value is does not conform to condition");
            }

        }

    }

   
}
