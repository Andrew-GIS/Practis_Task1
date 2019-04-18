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
            //Determine_Symvol();

            //Change_Position();

            Delete_Spaces_Between_Signs();
        }

        public static void Determine_Symvol()
        {
            Console.WriteLine("Inpute some symvols ");
            string test = Console.ReadLine();
            Console.WriteLine("Symvols that you want to found ");
            char found = Convert.ToChar(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < test.Length; i++)
            {
                //Console.Write(test[i]);
                if (test[i] == found)
                {
                    counter++;
                }
                
            }
            Console.Write($"Number of duplicate symvol = {counter}");
        }

        public static void Change_Position()
        {
            Console.WriteLine("Inpute some symvols to your string");
            string first = Console.ReadLine();
            Console.WriteLine("Inpute some symvols to your second string");
            string second = Console.ReadLine();
            Console.WriteLine("Inpute symvol position that you want split our strings");
            int position = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Resalt = " + first.Insert(position, second));
        }

        public static void Delete_Spaces_Between_Signs()
        {
            string test = "How are you? Are you fine? Yes!";
            string second = "";
            char quation = '?';
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write(test[i]);
                if (test[i] == quation)
                {
                    second = test[i];
                }
            }
            //string[] second = test.Split(' ');
            //foreach (var space in second)
            //{
            //    Console.Write($"{space}");
            //}

        }
    }
}      


           
//string[] textWithDeletedSpaces = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//            Console.WriteLine(string.Join(" ", textWithDeletedSpaces));


   

