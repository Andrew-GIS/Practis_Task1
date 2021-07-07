using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class Task5
    {
        public static void CalulateRow()
        {
            Console.WriteLine("Input number of lenth");
            int lenth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum of your row = ");
            Console.Write(SumOfRow(lenth));
            Console.WriteLine();
            //FillingArray();
            
        }

        public static int SumOfRow(int lenth)
        {
            int sum = 0;
            sum = lenth * lenth * lenth;
            return sum;
        }

        //public static void FillingArray()
        //{
        //    int[][] numbers = new int[3][];
        //    numbers[0] = new int[] { 1 };
        //    numbers[1] = new int[] { 1, 3 };
        //    numbers[2] = new int[] { 1, 3, 5 };
        //    for (int i = 0; i < numbers.Length; i++)
        //    {

        //        for (int j = 0; j < numbers[i].Length; j++)
        //        {
        //            if (i % 2 == 1)
        //            {
        //                Console.Write($"{numbers[i][j]} \t");
        //            }
        //        }
                
        //    }
        //}
        //{
        //    int[][] numbers = new int[lenth][];
        //    for (int i = 0; i < lenth; i++)
        //    {
                
        //        int[] temp;
        //        for (int j = 0; j < lenth; j++)
        //        {
        //            if (j % 2 == 1)
        //            {
        //                numbers[i] = new int[] {j};

        //            }
        //            temp = numbers[i];
        //        }
        //        return numbers;
        //    }
            
        }    
       
    }

