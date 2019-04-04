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
            Console.ReadKey();
        }

    }

   
}
