using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class Task6
    {
        public static void SortOfLetters()
        {
            while (true)
            {
                Console.WriteLine("Inpute first string");
                string first = Console.ReadLine();
                if (CheckLettersForFirst(first) == true)
                {
                    Console.WriteLine("First String is OK, we can continue");
                    break;
                }
                else
                {
                    Console.WriteLine("First String Not OK");
                    continue;
                }
            }
            
            
            CheckLettersForSecond();
            Console.WriteLine("Second String is OK, we can continue");
            //CombineOurStrings(first, second);


        }

        public static bool CheckLettersForFirst(string first)
        {
            foreach (char c in first)
                if (Char.IsNumber(c))
                    return false;
            return true;

            //for (int i = 0; i < first.Length; i++)
            //{
            //    if (first[i] > '0' && first[i] <= '9')
            //    {
            //        Console.WriteLine("String contains digit");

            //        return false;
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //return true;
        }

        public static bool CheckLettersForSecond(string second)
        {
            foreach (char c in second)
                if (Char.IsNumber(c))
                    return false;
            return true;
            //    bool check = true;
            //    while (check == true)
            //    {
            //        Console.WriteLine("Inpute second string");
            //        string second = Console.ReadLine();
            //        char[] char_second = second.ToCharArray();
            //        for (int i = 0; i < char_second.Length; i++)
            //        {
            //            if (Char.IsLetter(char_second[i]))
            //            {
            //                check = false;
            //            }

            //            else
            //            {
            //                //Console.WriteLine("Inpute correct value");
            //                check = true;
            //            }
            //        }

            //    }
        }

            public static string CombineOurStrings(string first, string second)
        {
            string combine_string = first + second;
            Console.WriteLine("After combinig our string looks like {0}", combine_string);
            return combine_string;
        }
    }
}
