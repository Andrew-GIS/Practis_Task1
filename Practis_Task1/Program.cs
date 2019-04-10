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
            //Task10();
            //Task11();
            //Defining_of_value();
            //Route();
            //Value_Between_Numbers();
            //QuantityNumbers_InValue();
            //Average_Of_Value();
            //Skier();
            //Multiply_Without_Multiply();
            //Square_of_numbers();
            //Fibonacci_Void();
            //Fibonachy_Count();
            Parsing_Of_Value();
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
            Console.WriteLine($"factorial {value} = {factorial}");
        }

        public static void Task11() //pboblem with rhombus
        {
            //
            //Drawing some figure (string; rectangle; right triangle; equilateral triangle; rhombus).
            //
            bool repit = true;
            while (repit = true)
            {
                char star = '*';
                Console.WriteLine("Choose your figure");
                Console.WriteLine("1.String");
                Console.WriteLine("2.Rectangle");
                Console.WriteLine("3.Right Triangle");
                Console.WriteLine("4.Equilateral Triangle");
                Console.WriteLine("5.Rhombus");
                int choose = Convert.ToInt32(Console.ReadLine());


                switch (choose)
                {
                    case 1:
                        int width = 68;
                        Console.Write("String of:");
                        for (int i = 0; i < width; i++)
                        {
                            Console.Write(star);
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        int width_for_rectangle = 5;
                        string space = "     ";
                        for (int i = 0; i < width_for_rectangle + 2; i++)
                        {
                            Console.Write(star);
                        }
                        Console.Write("\n");
                        for (int i = 0; i < width_for_rectangle; i++)
                        {
                            Console.WriteLine($"{star}{space}{star}");
                        }
                        for (int i = 0; i < width_for_rectangle + 2; i++)
                        {
                            Console.Write(star);
                        }
                        Console.WriteLine();
                        break;
                    case 4: //with internet support

                        int lenth = 1;
                        Console.Write($"    {star}");
                        while (lenth <= 5)
                        {

                            int k = 5;
                            int hight = 1;

                            Console.WriteLine("");
                            while (k > lenth)
                            {
                                Console.Write(" ");
                                k--;
                            }
                            while (hight <= lenth)
                            {
                                Console.Write($"{star}{star}");
                                hight++;
                            }
                            lenth++;
                        }
                        Console.WriteLine();

                        break;

                    case 3:
                        int number_of_lines = 5;
                        int count = 1;
                        while (number_of_lines-- != 0)
                        {
                            int c = count;
                            while (c-- != 0)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                            count += 1;
                        }
                        // second variant 
                        //int num_row = 5;
                        //for (int n = 0; n < num_row; n++)
                        //{
                        //    for (int j_trianng = 0; j_trianng<=n_row;j_trianng++)
                        //    {
                        //        Console.WriteLine(star);
                        //    }  
                        //}
                        break;
                    case 5:

                        break;
                    default:
                        Console.WriteLine("Number of figure that you input doesn't exist in sample");
                        repit = false;
                        break;
                }
            }
        }

        public static void Defining_of_value()
        {
            bool repite = true;
            while (repite == true)
            {
                Console.WriteLine("Inpute your value");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choose variant what you want to check in this value");
                Console.WriteLine("1. Check your value on sign (negative or positive)");
                Console.WriteLine("2. Check our value to simple (simple or no)");
                Console.WriteLine("3. Check our value about dividing to 2;5;3;6;9 ");
                int choose = Convert.ToInt32(Console.ReadLine());
                int counter = 0;
                switch (choose)
                {
                    case 1:
                        if (value > 0)
                        {
                            Console.WriteLine("Your Value is positive");
                        }
                        else if (value < 0)
                        {
                            Console.WriteLine("Your Value is negative");
                        }
                        else
                        {
                            Console.WriteLine("Your Value is ZERO");
                        }
                        break;

                    case 2:

                        for (int i = 1; i <= value; i++)
                        {
                            if (value % i == 0)
                            {
                                counter++;
                            }
                        }
                        if (counter == 2)
                        {
                            Console.WriteLine("Your value is simple");
                        }
                        else if (counter != 2)
                        {
                            Console.WriteLine("Your value is NOT Simple");
                        }

                        break;
                    case 3:
                        if (value % 2 == 0 && value % 5 == 0 && value % 3 == 0 && value % 6 == 0 && value % 9 == 0)
                        {
                            Console.WriteLine("OK - Your value is DEVIDE by 2;3;5;6;9 at the same time");
                        }
                        else
                        {
                            Console.WriteLine("NOT - Your value is DOESN'T devide by 2;3;5;6;9 at the same time");
                        }
                        Console.WriteLine("Numbers from 0 to 1000 that devides by 2;3;5;6;9 at the same time");
                        for (int i = 0; i < 1000; i++)
                        {
                            if (i % 2 == 0 && i % 5 == 0 && i % 3 == 0 && i % 6 == 0 && i % 9 == 0)
                            {
                                Console.Write($"{i}; ");
                            }
                        }
                        break;
                }
                Console.WriteLine("\n Work was end, would you like to continue enter: Y - if continue; and N - if  end");
                string reth = Console.ReadLine();
                if (reth == "Y")
                {
                    continue;
                }
                else
                {
                    repite = false;
                }
            }
        }

        public static void Route()
        {
            int start = 1;
            Console.WriteLine("Inpute number of clients ");
            int clients = Convert.ToInt32(Console.ReadLine());
            int route = 1;
            do
            {
                route *= start;
                start++;
            }
            while (start <= clients);
            {
                Console.WriteLine($"Number of roads that car can send some gifts {route}");
            }

        }

        public static void Value_Between_Numbers()
        {
            Console.WriteLine("Inpute first value");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inpute second value");
            int second = Convert.ToInt32(Console.ReadLine());
            int sum_between = 0;
            for (int i = first; i <= second; i++)
            {
                //Console.WriteLine($"{i}, ");
                sum_between += i;
            }
            Console.WriteLine($"Sum of numbers bitween {first} and {second} = {sum_between}");
            Console.WriteLine("All neagtive value located between our numbers: ");
            for (int i = first; i <= second; i++)
            {

                if (i % 2 == 1)
                {
                    Console.Write($"{i}, ");
                }
            }
            Console.WriteLine();
        }

        public static void QuantityNumbers_InValue()
        {
            Console.WriteLine("Input your natural value ");
            int value = Convert.ToInt32(Console.ReadLine());
            int counter = 0;
            while (value != 0)
            {
                if (value % 2 == 0)
                {
                    counter++;
                }
                value = value / 10;
            }
            Console.WriteLine($"Quantity of count numbers = {counter}");

        }

        public static void Average_Of_Value()
        {
            Console.WriteLine("Input first value, first value must be smaller than second ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inpute second value ");
            int second = Convert.ToInt32(Console.ReadLine());
            double avarage = 0;
            double sum = 0;
            int counter = 0;
            if (second >= first)
            {
                for (int i = first; i <= second; i++)
                {

                    sum += i;
                    counter++;
                    avarage = sum / counter;

                }
                //Console.WriteLine($"Kol {counter}; Sum {sum} ;  Avarage {avarage}");
                Console.WriteLine($"Avarage of values between firs and second = {avarage}");

            }
            else
            {
                Console.WriteLine("Your first value is beggest than Second - this is didn't corresponds to our conditions");
            }
        }

        public static void Skier()
        {
            double start = 10;
            double finish = 100;
            double distance;
            double increment;
            int counter = 0;

            do
            {
                increment = start * 0.1;
                start = increment + start;
                distance = start;
                counter++;


            }
            while (distance <= finish);
            {
                Console.WriteLine($"Our skier will reach 100km point at the {counter}th day");
            }
        }

        public static void Multiply_Without_Multiply()
        {
            Random rnd = new Random();
            int first = rnd.Next(-10, 10);
            Console.WriteLine("First value = {0}", first);
            Random rnd2 = new Random();
            int second = rnd.Next(-10, 10);
            Console.WriteLine("Second value = {0}", second);
            int multiply = 0;

            for (int i = 1; i <= second; i++)
            {
                multiply = multiply + first;
            }
            Console.WriteLine($"Multiply = {multiply}");
            //
            //test with simple value.
            //
            //Console.WriteLine("First ");
            //int first = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Second ");
            //int second = Convert.ToInt32(Console.ReadLine());
            //int resalt = 0;
            //for (int i = 1; i <= second; i++)
            //{
            //    resalt = resalt + first;
            //}
            //Console.WriteLine("Multiply  = {0}", resalt);
        }

        public static void Square_of_numbers()
        {
            //
            //Print all squares of natural numbers not exceeding a given number N.
            //
            Console.WriteLine("Inpute you N value ");
            int N = Convert.ToInt32(Console.ReadLine());
            int square = 1;
            for (int i = 1; i < N; i++)
            {
                square = i * i;
                if (square < N)
                {
                    Console.WriteLine("Squares of {0} = {1}", i, square);
                }
            }
        }

        public static void Fibonacci_Void()
        {
            Console.WriteLine("Input your k value ");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;
            int sum = 0;
            Console.Write("0 , ");
            Console.Write("1 , ");
            Console.Write("1 , ");
            for (int i = 0; i < k; i++)
            {
                //if (i == 0 || i == 1)
                //{
                //    Console.Write($"{i}, ");

                //}

                if (sum < k)
                {
                    sum = a + b;
                    Console.Write($"{sum} , ");
                    a = b;
                    b = sum;
                }
            }
            //
            //Program displays one extra value 
            //
        }

        public static void Fibonachy_Count()
        {
            Console.WriteLine("Input numbers of Fibonachy values that you want to display");
            int k = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 1;
            int sum = 0;
            int conter = 0;
            Console.Write("0 , "); Console.Write("1 , "); Console.Write("1 , ");
            for (int i = 0; i <= k-4; i++)
            {
                do
                {
                    sum = a + b;
                    a = b;
                    b = sum;
                    conter++;
                }
                while (conter == k);
                {
                    Console.Write($"{sum} , ");
                }
            }
            //
            //realized with BIG KOSTILE, didn't have enough time, sorry(((.
            //
        }

        public static void Parsing_Of_Value()
        {
            //
            //Determine what digits a number consists of (a number is entered, you need to parse it and output all the digits into it in order).
            //
            Console.WriteLine("Input you value ");
            int value = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            while (value >= 1)
            {
                temp = value % 10;
                value = value / 10;
                Console.Write($" {temp} ,");
                //string temp_resth = Convert.ToString(temp);
                //char[] arr = temp_resth.ToCharArray();
                //Array.Reverse(arr);
                //Console.Write(arr);
            }
            //
            //Problem with revers of value.
            //
        }

        

    }
}

           



   

