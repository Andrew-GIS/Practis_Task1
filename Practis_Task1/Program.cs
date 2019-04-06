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
            //Task5();
            // Task6();
            //Task7();
            //Task8();
            //Task9();
            Task10();

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
            x += y - x++ * y;
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
        public static void Task6()
        {
            //
            // Task where we must find diapason of numbers
            //
            Console.WriteLine("Inpute you value ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value > 100)
            {
                Console.WriteLine("Our value is biggest than 100");
            }
            if ((value >= 0) && (value <= 14))
            {
                Console.WriteLine("Our value is on the [0-14] diapasone");
            }
            if ((value >= 15) && (value <= 35))
            {
                Console.WriteLine("Our value is on the [15-35] diapasone");
            }
            if ((value >= 36) && (value <= 50))
            {
                Console.WriteLine("Our value is on the [36-50] diapasone");
            }
            if ((value >= 50) && (value <= 100))
            {
                Console.WriteLine("Our value is on the [50-100] diapasone");
            }
        }

        public static void Task7()
        {
            //
            //Translator
            //
            Console.WriteLine("Inpute your word ");
            string word = Console.ReadLine();
            switch (word)
            {
                case "Rain":
                    Console.WriteLine("English: Rain --->  Русский: Дождь");
                    break;
                case "Wind":
                    Console.WriteLine("English: Wind --->  Русский: Ветер");
                    break;
                case "Sunny":
                    Console.WriteLine("English: Sunny --->  Русский: Солнечно");
                    break;
                case "Frosty":
                    Console.WriteLine("English: Frosy --->  Русский: Морозно");
                    break;
                case "Shower":
                    Console.WriteLine("English: Shower --->  Русский: Ливень");
                    break;
                case "Ice":
                    Console.WriteLine("English: Ice --->  Русский: Гололед");
                    break;
                case "Dry":
                    Console.WriteLine("English: Dry --->  Русский: Сухо");
                    break;
                case "Storm":
                    Console.WriteLine("English: Storm --->  Русский: Шторм");
                    break;
                case "Snow":
                    Console.WriteLine("English: Snow --->  Русский: Снег");
                    break;
                case "Frogs falling from sky":
                    Console.WriteLine("English: Frogs falling from sky --->  Русский: Жабы падают с неба");
                    break;
                default:
                    Console.WriteLine("My translator doesn't know this word ");
                    break;
            }
        }

        public static void Task8()
        {
            //
            //Employee bonus calculation.
            //
            Console.WriteLine("input your main salary ");
            double salary = Convert.ToInt32(Console.ReadLine());
            double final_salary;
            Console.WriteLine("Input your work experience, choose from variant bellow: ");
            Console.WriteLine("1. Your work experience is less than 5 years - 10%");
            Console.WriteLine("2. Your work experience is from 5 years but less than 10 - 15%");
            Console.WriteLine("3. Your work experience is from 10 years but less than 15 -25% ");
            Console.WriteLine("4. Your work experience is from 15 years but less than 20 - 35%  ");
            Console.WriteLine("5. Your work experience is from 20 years but less than 25 - 45%  ");
            Console.WriteLine("6. Your work experience is from 25 - 50%  ");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    final_salary = salary + (salary * 0.1);
                    Console.WriteLine($"Your salary with bonus = {final_salary}");
                    break;
                case 2:
                    final_salary = salary + (salary * 0.15);
                    Console.WriteLine($"Your salary with bonus = {final_salary}");
                    break;
                case 3:
                    final_salary = salary + (salary * 0.25);
                    Console.WriteLine($"Your salary with bonus = {final_salary}");
                    break;
                case 4:
                    final_salary = salary + (salary * 0.35);
                    Console.WriteLine($"Your salary with bonus = {final_salary}");
                    break;
                case 5:
                    final_salary = salary + (salary * 0.45);
                    Console.WriteLine($"Your salary with bonus = {final_salary}");
                    break;
                case 6:
                    final_salary = salary + (salary * 0.5);
                    Console.WriteLine($"Your salary with bonus = {final_salary}");
                    break;
                default:
                    Console.WriteLine("Error value! Choose from the list");
                    break;
            }


        }

        public static void Task9()
        {
            //
            //Calculator
            //
            bool main = true;
            while (main == true)
            {

                int operator1 = 0;
                int operator2 = 0;
                Console.WriteLine("Inpute first value");
                string operator_1 = Console.ReadLine();
                bool succses = Int32.TryParse(operator_1, out operator1);
                
                if (!succses)
                {
                    Console.WriteLine("Not valid value");
                    continue;
                }
                Console.WriteLine("Inpute second value");
                string operator_2 = Console.ReadLine();
                bool succses2 = Int32.TryParse(operator_2, out operator2);
                if (!succses2)
                {
                    Console.WriteLine("Not valid value");
                    continue;
                }

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
                Console.WriteLine("Work was end, would you like to continue enter: Y - if continue; and N - if  end");
                string reth = Console.ReadLine();
                if (reth == "Y")
                {
                    continue;
                }
                if (reth == "N")
                {
                    main = false;
                }
            }



        }

        public static void Task10()
        {
            //
            //Factorial of Value
            //
            Console.WriteLine("Inpute our value");
            int value = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;

            for (int i = 1; i <= value; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }
    }
}




   

