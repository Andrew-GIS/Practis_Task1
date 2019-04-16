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
            Unpacking_Array_to_1and0();
        }

        public static void Unpacking_Array_to_1and0()
        //
        //Unpacking of array where each element indicates the number of elements in the next series of zeros or ones.
        //
        {
            Console.WriteLine("Inpute lenth of your array");
            int lenth = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[lenth];
            
            for (int inpute = 0; inpute < lenth; inpute++)
            {
                Console.WriteLine("Inpute some value to your array: {0} = ", inpute+1);
                array[inpute] = Convert.ToInt32(Console.ReadLine());
                //Console.Write($"{array[inpute]} ");
            }
            Console.WriteLine($"Our array:" + string.Join(",", array));

            for (int i = 0; i < lenth; i++)
            {
                if (array[0] != 0)
                {
                    int value_1 = array[i];
                    for (int j = 0; j <= value_1; j++)
                    {
                        if (j % 2 == 1)
                        {
                            for (int k = 0; k < value_1; k++)
                            {
                                Console.Write("0");
                            }
                        }
                        if (j % 2 == 0)
                        {
                            for (int k = 0; k <= value_1; k++)
                            {
                                Console.Write("1");
                            }
                        }
                    }
                    //{
                       
                    //    if (j == array[0])
                    //    {
                    //       Console.Write("1");
                    //    }
                    // }
                    //int value = array[i];
                    //int counter = 0;
                    //for (int j = 0; j < value; j++)
                    //{
                    //    Console.Write("1");
                    //}
                    //int value_s = array[i+1];
                    //for (int k = 0; k < value_s; k++)
                    //{
                    //    Console.Write("0");
                    //}

                }
                if (array[0] == 0)
                {
                }
            }

        }


    }
}      


           



   

