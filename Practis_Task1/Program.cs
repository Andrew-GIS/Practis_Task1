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
            Console.WriteLine("Список задач : ");
            Console.WriteLine("Введите название задачи к решению которого вы хотите перейти (от 1 до 9) ");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Добро пожаловать в задачу 1");
                int x1 = 255;
                Console.WriteLine($"Целочисленная переменная x1 = {x1}");
            }
            if (choose == 2)
            {
                Console.WriteLine("Добро пожаловать в задачу 2");
                Console.WriteLine("Ваше Имя? ");
                string str1 = Console.ReadLine();
                string str2 = "Привет " + str1 + "!";
                Console.WriteLine(str2);
            }
            if (choose == 3)
            {
                Console.WriteLine("Добро пожаловать в задачу 3");
                var v1 = 'v';
                v1 = (char)'c';
                Console.WriteLine(v1);
            }
            if (choose == 4)
            {
                Console.WriteLine("Добро пожаловать в задачу 4");
                Console.WriteLine("В условии дана фигура - квадрат, введите длину стороны квадрата ");
                double side = Convert.ToDouble(Console.ReadLine());
                double Perimetr = side * 4;
                Console.WriteLine($"Периметр данной фигуры = {Perimetr}");
            }
            if (choose == 5)
            {
                Console.WriteLine("Добро пожаловать в задачу 5");
                Console.WriteLine("В условии дана фигура - два круга с общим центром и разными радиусами, при условии того что R1 > R2");
                Console.Write("Введите радиус внешнего круга R1 = ");
                const double pi = 3.14;
                double R1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите радиус внутреннего круга R2 = ");
                double R2 = Convert.ToDouble(Console.ReadLine());
                double S1 = pi * R1 * R1;
                double S2 = pi * R2 * R2;
                double S3 = S1 - S2;
                Console.WriteLine($"Площадь пространства внешнего круга = {S1}");
                Console.WriteLine($"Площадь пространства внутренего круга = {S2}");
                Console.WriteLine($"Площадь пространства между внутреним и внешним кольцом = {S3}");
            }
            if (choose == 6)
            {
                Console.WriteLine("Добро пожаловать в задачу 6");
                int num = 43;
                int tens = num / 10;
                int units = num % 10;
                Console.WriteLine($"Десятки {tens}");
                Console.WriteLine($"Еденицы {units}");
            }
            Console.ReadKey();
        }

    }

   
}
