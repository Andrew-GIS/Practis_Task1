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

            //Market_List();

            //Excellent_Number();

            //Encryption();

            Decryption();
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
        //Calculate market list with suport 2 arraes.
        //
        {
            string[] market_list = new string[10] {"Apple", "Pear", "Cucumber", "Tomatoes", "Dill", "Parsley", "Chicken", "Cheese", "Butter", "Milk" };
            double[] price = new double[10] {40.50, 31.20, 21.80, 35, 150, 145, 200, 400, 81.40, 53.35};
            double[] sum_market = new double[10];
            double sum = 0;
            double weight = 0;
            for (int i = 0; i < market_list.Length; i++)
            {
                Console.WriteLine("How much {0} do you want to by (kg)", market_list[i]);
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

        public static void Excellent_Number()
        //
        //We must found all "Excellent" numbers sum of which allow to sum of all of his dividers.
        //
        {
            Console.WriteLine("All excellent numbers at [1-1000] range");
            int sum = 0;
            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        {                        
                            sum += j;
                        }
                    }
                }
                if (sum == i)
                {
                    Console.Write($"Value {i}, ");
                }
                sum = 0;
            }
            Console.WriteLine();
            Console.ReadKey();
            //
            //Resolved this task without massive, because didn't see necessary to used array.
            //
        }

        public static void Encryption()
        //
        //In this task we realize some encryption for the string of values.
        //
        {
            var encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var cipher = new char[11]       { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };
            //Console.WriteLine("Inpute you massage ");
            //char [] massage = new char [10];
            //char[] encrypt_massage = new char[10];
            //for (int i = 0; i < massage.Length; i++)
            //{
            //    Console.Write("Inpute {0} ", i + 1);
            //    massage[i] = Convert.ToChar(Console.ReadLine());
            //}
            //for (int j = massage[0]; j < encrypt_massage.Length; j++)
            //{ 
            //    if (massage[j] == 0)
            //    {
            //        encrypt_massage[j] = cipher[j];
            //    }
            //    else if (massage[j] == 1)
            //    {
            //        encrypt_massage[j] = cipher[j];
            //    }
            //    else if (massage[j] == 2)
            //    {
            //        encrypt_massage[j] = cipher[2];
            //    }
            //    else if (massage[j] == 3)
            //    {
            //        encrypt_massage[j] = cipher[3];
            //    }
            //    else if (massage[j] == 4)
            //    {
            //        encrypt_massage[j] = cipher[4];
            //    }
            //    else if (massage[j] == 5)
            //    {
            //        encrypt_massage[j] = cipher[5];
            //    }
            //    else if (massage[j] == 6)
            //    {
            //        encrypt_massage[j] = cipher[6];
            //    }
            //    else if (massage[j] == 7)
            //    {
            //        encrypt_massage[j] = cipher[7];
            //    }
            //    else if (massage[j] == 8)
            //    {
            //        encrypt_massage[j] = cipher[8];

            //    }
            //    else if (massage[j] == 9)
            //    {
            //        encrypt_massage[j] = cipher[9];

            //    }
            //    else
            //    {
            //        encrypt_massage[j] = cipher[10];
            //    }
            //}
            //Console.WriteLine($"Our array:" + string.Join(",", massage));
            //Console.WriteLine($"Our enqript array:" + string.Join(",", encrypt_massage));
            Console.WriteLine("Enter your massage: ");
            string text = Console.ReadLine();
            char[] encrypt = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < encryptChars.Length; j++)
                {
                    if (text[i] == encryptChars[j])
                    {
                        encrypt[i] = cipher[j];
                        break;
                    }
                }
                if (encrypt[i] == '\x0000')
                {
                    encrypt[i] = cipher[10];
                }
            }
            foreach (var item in encrypt)
            {
                Console.Write(item);
            }
        }

        public static void Decryption()
        {
            var encryptChars = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var cipher = new char[11] { ';', '+', '/', '.', '^', '@', '"', '!', '%', '#', '$' };
            Console.WriteLine("Enter your massage: ");
            string text = Console.ReadLine();
            char[] encrypt = new char[text.Length];
            char not_digit = '-';
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < encryptChars.Length; j++)
                {
                    if (text[i] == encryptChars[j])
                    {
                        encrypt[i] = cipher[j];
                        break;
                    }
                }
                if (encrypt[i] == '\x0000')
                {
                    encrypt[i] = cipher[10];
                }
            }
            Console.WriteLine("Encrypt massage: ");
            foreach (var item in encrypt)
            {
                Console.Write(item);
            }
            char [] decrypt = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < encryptChars.Length; j++)
                {
                    if (encrypt[i] == cipher[j])
                    {
                        decrypt[i] = encryptChars[j];
                        break;
                    }
                }
                if (decrypt[i] == '\x0000')
                {
                    decrypt[i] = not_digit;
                }
            }
            Console.WriteLine("\nDecrypt massage: ");
            foreach (var l in decrypt)
            {
                Console.Write(l);
            }
            Console.WriteLine("\nEnd ");
            //
            //made decription, digit = decription, other - "-".
            //
        }
    }
}
        


           



   

