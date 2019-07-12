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
            //Task1.done.
            //MathOperation();

            //Task2.done.
            //Duplicate();

            //Task3.done.
            //Found_Of_Index();

            //Task4.done.
            //More_Than_average();

            //Task5.done.
            //int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //MyReverse(array);

            //Task6.done.
            //SubArray(array, 1, 3);

            //Task7.done.
            //Add1Element(array);
            //AddToFirstPosition(array, 1);

            //Task8.done.
            //XfoundingInArray(1);

            //Task9.done.
            //ChangePosition();

            //Task10.done.
            SumOfColum(0);
        }

        public static void MathOperation()
        //
        //Task1.Min, Max, Median, Sum, UnCount Values.
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
        //Task2.Deletion of duplicates.
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
        //Task3.Find Position of value that include in boundaries.
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
        //Task3.Found elements that more that average value.
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
            //
            //Task4.
            //
        {
            Console.WriteLine("Array: " + string.Join(", ", array));
            Console.WriteLine("\nReverse array: ");
            for (int j = array.Length-1; j >= 0; j--)
            {
                Console.Write($"{array[j]} ");
            }
            return array;
        }

        public static int[] SubArray(int[] array, int index, int count)
            //
            //Task5.
            //
        {
            Console.WriteLine("Array: " + string.Join(", ", array));
            int totalLength = index + count;
            int[] changedArray = new int[count];
            for (int i = 0; i < changedArray.Length; i++)
            {
                if (totalLength <= array.Length)
                    changedArray[i] = array[index + i];
                else
                {
                    while (index + i < array.Length)
                    {
                        changedArray[i] = array[index + i];
                        i++;
                    }
                }
            }

            if (totalLength > array.Length)
            {
                int zeroNumber = index + count - array.Length;
                int zeroIndexInArray = changedArray.Length - zeroNumber;
                for (int i = zeroIndexInArray; i < changedArray.Length; i++)
                {
                    if (changedArray[i] == 0) changedArray[i] = 1;
                }
            }
            Console.WriteLine("SubArray: " + string.Join(" , ", changedArray));

            return changedArray;
        }

        public static int[] Add1Element(int[] array)
            //
            //Task6.
            //
        {
            Console.WriteLine("Array: " + string.Join(", ", array));
            Console.WriteLine($"Lenth at start = {array.Length}");

            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            Console.WriteLine("NewArray: "+ string.Join(", ", newArray));
            Console.WriteLine($"Lenth of newArray {newArray.Length}");
            return newArray;
        }

        public static int[] AddToFirstPosition(int[] array, int value)
            //
            //Task7.
            //
        {
            Console.WriteLine("Array: " + string.Join(", ", array));
            int[] newArray = new int[array.Length + 1];
            int firstPosition = newArray.Length - array.Length;
            newArray[0] = value;
            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i - 1];
            }
            Console.WriteLine($"NewArray: " + string.Join(", ", newArray));
            return newArray;
        }

        public static void XfoundingInArray(int x)
            //
            //Task8.
            //
        {
            int[,] array = new int[,]{ { 1, 2, 3, 4, 5, 5, 6, 7, 8 } , {1, 4, 5, 6, 7, 8, 9, 10, 3} };
            int counter = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //Console.Write($"{array[i,j]} ");
                    if (array[i, j] == x)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine($"Number of founding of {x} value = {counter} times");
        }

        public static void ChangePosition()
            //
            //Task9.
            //
        {
            int[,] array = new int[,] { {51, 4, 3, 2}, 
                                        { 1, 4, 5, 6},
                                        {3, 5, 9, 6 } };

            int rows = array.GetLength(0);
            int colums = array.GetLength(1);
            int firstRow = 1;
            int secondRow = 2;
            Console.WriteLine("Array at start");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i,j]},\t ");
                }
            }
            Console.WriteLine();
            //change rows position.
            for (int i = 0; i < colums; i++)
            {
                var temp = array[firstRow, i];
                array[firstRow, i] = array[secondRow, i];
                array[secondRow, i] = temp;
            }

            Console.WriteLine("Array after change");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{array[i, j]},\t ");
                }
            }
            Console.WriteLine();
        }

        public static void SumOfColum(int columNumber)
            //
            //Task10.
            //
        {
            int[,] array = new int[,] { {51, 4, 3, 2},
                                        { 1, 4, 5, 6},
                                        {3, 5, 9, 6 } };
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (array[i, j] == array[i, columNumber])
                    {
                        sum += array[i,j];
                    }
                }
            }
            Console.WriteLine($"Sum of {columNumber+1} colum = {sum}");
        }
    }
}


   

