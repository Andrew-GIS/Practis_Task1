﻿using System;
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
            //Massive_First_Step();

            //Duplicate();

            Found_Of_Index();
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
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.Write($"{numbers[i]}");
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void Duplicate()
        //
        //Deletion of duplicates.
        //
        {
            Random rnd = new Random();
            int[] array = new int[5];
            Console.WriteLine("Array at the start position");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
                Console.Write($"{array[i]} , ");
            }
            int[] arrayWithoutDuplicat = new int[array.Length];
            arrayWithoutDuplicat[0] = array[0];
            int position = 0;
            Console.WriteLine("Array after removing of duplicats");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < arrayWithoutDuplicat.Length; j++)
                {
                    if (arrayWithoutDuplicat[j] == 0 && i != 0)
                        break;
                    if (array[i] != arrayWithoutDuplicat[j])
                    {
                        arrayWithoutDuplicat[j] = array[i];
                        position++;
                    }
                    else
                        continue;
                    Console.Write(arrayWithoutDuplicat[j]);
                }

            }


        }

        public static void Found_Of_Index()
        //
        //Find Position of value that include in boundaries.
        //
        {
            Console.WriteLine("I generate array in boundaries of 0 - 20 ");
            Random rnd = new Random();
            Console.WriteLine("Inpute lenth of your Array ");
            int lenth = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[lenth];
            for (int i = 0; i < lenth; i++)
            {
                array[i] = rnd.Next(0, 20);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("Inpute MAX boundaries");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inpute MIN boundaries");
            int min = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lenth; i++)
            {
                if (array[i] > min && array[i] < max)
                {
                    Console.Write($"Value {array[i]} ");
                    Console.WriteLine($"Position {i}");

                }
            }
        }

        public static void More_That_Median()
        {

        }
    }
}


   

