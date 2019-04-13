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
            Massive_First_Step();
        }

        public static void Massive_First_Step()
            //
            //Min, Max, Median, Sum, UnCount Values.
            //
        {

            Console.WriteLine("Inpute lenth of our massive ");
            int lenth = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[lenth];
            Random rnd = new Random();
            
            
            Console.Write($"Our massive:");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 10);
                Console.Write($"{ numbers[i]}");
            }
            int max = numbers[0];
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine($"\nMax = {max}");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine($"\nMin = {min}");
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"\nSum = {sum}");
            int mediana = sum / lenth;
            Console.WriteLine($"\nMediana of the array = {mediana}");

            Console.Write("\nAll uncount values ");
            for (int i = 0; i<numbers.Length;i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.Write($"{numbers[i]}");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
            }
    }
}


   

