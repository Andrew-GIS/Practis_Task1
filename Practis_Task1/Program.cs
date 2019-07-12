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
            //Massive_First_Step();
            //done.Task1.
            //Duplicate();
            //done.Task2.
            //Found_Of_Index();
            //done.Task3.
            //More_Than_average();
            //done.Task4.
            //Task5 - Reverse array and Task6 - 
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            MyReverse(array);
            //Task5.done
            

        }

        public static void Massive_First_Step()
        //
        //Min, Max, Median, Sum, UnCount Values.
        //
        {
            while (true)
            {
                Console.WriteLine("Inpute lenth of our massive ");
                try
                {
                    int lenth = Convert.ToInt32(Console.ReadLine());

                    int[] numbers = new int[lenth];
                    Random rnd = new Random();

                    Console.Write($"Our massive:");
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = rnd.Next(0, 10);
                        Console.Write($"{ numbers[i]}, ");
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
                            Console.Write($"{numbers[i]} ");
                        }
                    }
                    Console.WriteLine();
                    Console.ReadKey();
                    break;
                }
                catch
                {
                    Console.WriteLine("Input correct value, you must input a digit");
                }
            }
        }

        public static void Duplicate()
        //
        //Deletion of duplicates.
        //
        {
            int[] array = new int[] {1, 1, 2, 13, 22, 2, 22};

            int[] arrayWithOutDuplicates = new int[array.Length];
            int duplicates = 0;
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int counter = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }

                if (counter == 1)
                {
                    arrayWithOutDuplicates[index] = array[i];
                    index++;
                }
                else
                {
                    duplicates++;
                }
            }

            index = 0;
            int[] arrayWithoutZeros = new int[arrayWithOutDuplicates.Length - duplicates];
            for (int i = 0; i < arrayWithOutDuplicates.Length; i++)
            {
                if (arrayWithOutDuplicates[i] != 0)
                {
                    arrayWithoutZeros[index] = arrayWithOutDuplicates[i];
                    index++;
                }
            }

            Array.Sort(array);
            Array.Sort(arrayWithOutDuplicates);
            Array.Sort(arrayWithoutZeros);
            Console.WriteLine("Array:\n" + string.Join(" , ", array));
            Console.WriteLine("Array without duplicates:\n" + string.Join(" , ", arrayWithOutDuplicates));
            Console.WriteLine("Array after all operation:\n" + string.Join(" , ", arrayWithoutZeros));
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
                    Console.WriteLine($"Index of element: {i+1}");
                }
            }
        }

        public static void More_Than_average()
        //
        //found elements that more that average value.
        //
        {
            int[] array = new int[] {1, 2, 3, 4, 5, 6};

            Console.WriteLine("Array:\n" + string.Join(" , ", array));

            int sum=0;
            int mediana = 0;
            int counter = 0;

            for (int j = 0; j < array.Length; j++)
            {
                sum += array[j];
                counter++;
               
            }
            mediana = sum / counter;
            Console.WriteLine($"\nSum = {sum}; Mediana = {mediana}");
            Console.WriteLine();
            Console.WriteLine("Elements that more than median value");
            
            for (int k = mediana; k < array.Length; k++)
            {
                Console.Write($"{array[k]}  ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public static int[] MyReverse(int[] array)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("\nReverse array: ");
            for (int j = array.Length-1; j >= 0; j--)
            {
                Console.Write($"{array[j]} ");
            }
            return array;
        }
    }
}


   

