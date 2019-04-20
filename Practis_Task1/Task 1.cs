using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public static class Task_1
    {
        public static void Calculate()
        {
            Console.WriteLine("Input first value");
            double first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second value");
            double second = Convert.ToInt32(Console.ReadLine());
            char sign = ChooseOperation();
            //Console.WriteLine(sign);
            double result = ResaltOfOperation(first, second, sign);
            Console.WriteLine(result);
        }

        public static double AddOperation(double first, double second)
        {
            double sum = 0;
            sum = first + second;
            return (sum);
        }
        public static double SubOperation(double first, double second)
        {
            double sub = 0;
            sub = first - second;
            return (sub);
        }
        public static double MulOperation(double first, double second)
        {
            double mul = 0;
            mul = first * second;
            return (mul);
        }
        public static double DivOperation(double first, double second)
        {
            double div = 0;
            if (first == 0 || second == 0)
            {
                Console.WriteLine("Error - one of you values is 0");
            }
            else
            {
                div = first + second;
            }
            return (div);
        }
        public static char ChooseOperation()
        {
            Console.WriteLine("You must choose what you want to do with our value");
            char sign = Convert.ToChar(Console.ReadLine());
            return sign;
        }
        public static double ResaltOfOperation(double first, double second, char sign)
        {
            double result = 0;
            switch (sign)
            {
                case '+':
                    result = AddOperation(first, second);
                    break;
                case '-':
                    result = SubOperation(first, second);
                    break;
                case '*':
                    result = MulOperation(first, second);
                    break;
                case '/':
                    result = DivOperation(first, second);
                    break;
                default:
                    Console.WriteLine("Return");
                    break;
            }
            return result;
        }
    }
}

