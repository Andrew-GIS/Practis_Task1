using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Program
    {
        //
        //Link - https://docs.google.com/document/d/1V5IDam36AkdjpfqL0rr_JYCF8bPIwrXyti_BxC3hkqM/edit.
        //
        static void Main(string[] args)
        {
            //Task2.done.
            //Determine_Symvol();

            //Task3.done.
            //ChangeStringPosition();

            //Task4.
            DeleteSpacesBetweenQuestionSigns();
        }

        public static void Determine_Symvol()
        {
            Console.WriteLine("Inpute your string ");
            string test = Console.ReadLine();
            Console.WriteLine("Symbol that you want to found ");
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
            Console.Write($"Symbol '{found}' is meeting = {counter} times\n");
        }

        public static void ChangeStringPosition()
        {
            Console.WriteLine("Inpute some symvols to your string");
            string first = Console.ReadLine();
            Console.WriteLine("Inpute some symvols to your second string");
            string second = Console.ReadLine();
            Console.WriteLine("Inpute symvol position that you want split our strings");
            int position = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Resalt = " + first.Insert(position, second));
        }

        public static void DeleteSpacesBetweenQuestionSigns()
        {
            string test = "How are you? Are you fine? Yes!";
            string second = "";
            char quation = '?';
            test.IndexOf("?");
            Console.WriteLine(test.IndexOf("?"));
            //for (int i = 0; i < test.Length; i++)
            //{
            //    Console.Write(test[i]);
            //    if (test[i] == quation)
            //    {
            //        //second = test[i];
            //    }
            //}
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


   

