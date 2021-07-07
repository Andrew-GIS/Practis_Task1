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
            string first = "";
            string second = "";
            first = PrintFirst(first);
            second = PrintSecond(second);
            Console.WriteLine("First string = {0};\nSecond string = {1};", first, second);
            string combine = Combine(first, second);
            char[] alphabetSort = SortByAlphabet(combine);
            DisplayResult(alphabetSort);
            Console.ReadLine();
        }

        public static bool CheckLettersForFirst(string first)
        {
            foreach (char c in first)
                if (Char.IsNumber(c))
                    return false;
            return true;
        }

        public static string PrintFirst(string first)
        {
            while (true)
            {
                Console.WriteLine("Inpute first string");
                first = Console.ReadLine();
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
            return first;
        }

        public static bool CheckLettersForSecond(string second)
        {
            foreach (char c in second)
                if (Char.IsNumber(c))
                    return false;
            return true;

        }

        public static string PrintSecond(string second)
        {
            while (true)
            {
                Console.WriteLine("Inpute second string");
                second = Console.ReadLine();
                if (CheckLettersForFirst(second) == true)
                {
                    Console.WriteLine("Second String is OK, we can continue");
                    break;
                }
                else
                {
                    Console.WriteLine("Second String Not OK");
                    continue;
                }
            }
            return second;
        }

        public static string Combine(string first, string second)
        {
            string combine = first + second;
            Console.WriteLine("Combile String  = {0}", combine);
            return combine;
        }

        public static char[] SortByAlphabet(string combine)
        {
            //string resalt_of_sort = combine.ToLower();
            char temp;
            char[] char_of_sort = combine.ToCharArray();
            for (int i = 1; i < char_of_sort.Length; i++)
            {
                for (int j = 0; j < char_of_sort.Length - 1; j++)
                {
                    if (char_of_sort[j] > char_of_sort[j + 1])
                    {
                        temp = char_of_sort[j];
                        char_of_sort[j] = char_of_sort[j + 1];
                        char_of_sort[j + 1] = temp;
                    }
                }
            }
            return char_of_sort;
        }

        public static void DisplayResult(char[] alphabetSort)
        {
            Console.Write("Sort string = ");
            foreach (var item in alphabetSort)
            {
                Console.Write(item);
            }
            Console.WriteLine("\nGlad to work with you, goodbye!");
        }
    }
}
