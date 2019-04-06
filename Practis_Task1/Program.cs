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
            //Task3();
            //Task4();
            Task5();

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
        public static void Task4()
        {
            //
            // Math operation with some value (x;y;z)
            //
            int x = 10;
            int y = 12;
            int z = 3;
            x+= y-x++*y;
            Console.WriteLine($"First ex. x = {x}");
            z = --x - y * 5;
            Console.WriteLine($"Second ex. z = {z}");
            y /= x + 5 % z;
            Console.WriteLine($"Third ex. y = {y}");
            z = x++ + y * 5;
            Console.WriteLine($"Forth ex. z = {z}");
            x = y - x++ * z;
            Console.WriteLine($"First ex. x = {x}");

        }
        public static void Task5()
        {
            //
            //Calculator
            //
            Console.WriteLine("Inpute first value");
            int operator1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inpute second value");
            int operator2 = Convert.ToInt32(Console.ReadLine());
            int result;
            Console.WriteLine("Inpute sign");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":

                    result = operator1 + operator2;
                    Console.WriteLine($"Resalt of sum  = {result}");
                    break;
                case "-":

                    result = operator1 - operator2;
                    Console.WriteLine($"Resalt of different  = {result}");
                    break;
                case "*":

                    result = operator1 * operator2;
                    Console.WriteLine($"Resalt of multiply  = {result}");
                    break;
                case "/":
                    
                    if (operator2 == 0)
                    {
                        Console.WriteLine("Second value can't be 0");
                        break;
                    }
                    else
                    {
                        result = operator1 / operator2;
                        Console.WriteLine($"Resalt of divide  = {result}");
                        break;
                    }
                default:
                    Console.WriteLine("Inpute correct sign '+'; '-'; '*'; '/'");
                    break;
            }
        }

    }

}

   

