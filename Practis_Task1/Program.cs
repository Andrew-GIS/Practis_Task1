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
            //Unpacking_Array_to_1and0();

            Market_List();
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

                    if (value_1 == 0)
                    {
                        Console.WriteLine("");
                    }
                    
                        if (i % 2 != 0)
                        {
                            for (int k = 0; k < value_1; k++)
                            {
                                Console.Write("0");
                            }
                        }
                        if (i % 2 == 0)
                        {
                            for (int k = 0; k < value_1; k++)
                            {
                                Console.Write("1");
                            }
                        }
                    }
                if (array[0] == 0)
                {
                    int value_1 = array[i];

                    if (value_1 == 0)
                    {
                        Console.WriteLine("");
                    }

                    if (i % 2 != 0)
                    {
                        for (int k = 0; k < value_1; k++)
                        {
                            Console.Write("1");
                        }
                    }
                    if (i % 2 == 0)
                    {
                        for (int k = 0; k < value_1; k++)
                        {
                            Console.Write("0");
                        }
                    }
                }
            }

        }

        public static void Market_List()
        //
        //Calculate market list with suport 2 arraes
        //
        {
            string[] market_list = new string[10] {"Apple", "Pear", "Cucumber", "Tomatoes", "Dill", "Parsley", "Chicken", "Cheese", "Butter", "Milk" };
            double[] price = new double[10] {40.50, 31.20, 21.80, 35, 150, 145, 200, 400, 81.40, 53.35};
            double[] sum_market = new double[10];
            double sum = 0;
            double weight = 0;
            for (int i = 0; i < market_list.Length; i++)
            {
                Console.WriteLine("How much {0} do you want to by", market_list[i]);
                weight = Convert.ToDouble(Console.ReadLine());
                
                    sum = price[i] * weight;
                    
                        sum_market[i] = sum;
                  sum = 0;
            }
            Console.WriteLine("Final price list = ");
            for (int k = 0; k < sum_market.Length; k++)
            {
                Console.Write($"{sum_market[k]}, ");
            }
            double sum_of_all_purchase = 0;
            for (int s = 0; s < sum_market.Length; s++)
            {
                sum_of_all_purchase += sum_market[s];
            }
            Console.WriteLine($"\nSum of all you purchase = {sum_of_all_purchase} UAH");
        }
    }
}      


           



   

