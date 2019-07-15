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
            DuplicateRemoving();

            //Task2.done.
            //Determine_Symvol();

            //Task3.done.
            //ChangeStringPosition();

            //Task4.done.
            //DeleteSpacesBetweenQuestionSigns();

            //Task5.done.
            //RemovingExtraSpaces();

            //Task6.done.
            //PrintFirstLetterOfWord();

            //Task7.done.
            //ReverceOderOfWords();

            //Task8.done.
            //DeterminesLengthOfShortestAndLongest();

        }

        public static void DuplicateRemoving()
        //Task1
        {
            string text = "abababa";
            Console.WriteLine($"Start srting: {text}");
            StringBuilder builder = new StringBuilder(text);
            for (int i = 0; i < builder.Length; i++)
            {
                for (int j = 0; j < builder.Length; j++)
                {
                    if (builder[i] == builder[j])
                    {
                        Console.WriteLine(builder.Remove(j, 1));
                    }
                }
            }
            Console.WriteLine($"Result string: {builder}");
        }

        public static void Determine_Symvol()
        //Task2.
        {
            Console.WriteLine("Inpute your string ");
            string test = Console.ReadLine();
            Console.WriteLine("Symbol that you want to found ");
            char found = Convert.ToChar(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == found)
                {
                    counter++;
                }
            }
            Console.Write($"Symbol '{found}' is meeting = {counter} times\n");
        }

        public static void ChangeStringPosition()
        //Task3.
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
        //Task4.
        {
            //
            //approach with removing '?' sign.
            //
            string text = "How are you? Are you fine? Yes!";
            Console.WriteLine($"Text at start:\n{text}");
            //Console.WriteLine($"Start string format {text}");
            //string targetSign = "? ";
            //String[] divide = text.Split(new string[] { targetSign }, StringSplitOptions.None);
            //divide[1] = divide[1].Replace(" ", "");
            //Console.WriteLine($"String with demoving spaces bettwen '?' char: {divide[0] + divide[1] + divide[2]}");

            //
            //approach without removing '?' sign.
            //
            Console.WriteLine("Text after removing spaces: ");
            int indexOfFirstQuestion = text.IndexOf('?');
            int indexOfSecondQuestion = text.IndexOf('?', indexOfFirstQuestion + 1);

            for (int i = 0; i < indexOfFirstQuestion; i++)
            {
                Console.Write(text[i]);
            }
            string textWithoutSpaces = "";
            for (int j = indexOfFirstQuestion; j < indexOfSecondQuestion; j++)
            {
                if (text[j] != ' ')
                {
                    textWithoutSpaces += text[j];
                }
            }
            Console.Write(textWithoutSpaces);
            for (int k = indexOfSecondQuestion; k < text.Length; k++)
            {
                Console.Write(text[k]);
            }
            Console.WriteLine(Environment.NewLine);
        }

        public static void RemovingExtraSpaces()
        //Task5.
        {
            string text = "Hello     ! Glad to    see    you!";
            Console.WriteLine($"Sententh with extra spaces: {text}");
            text = string.Join(" ", text.Split(new string[] { }, StringSplitOptions.RemoveEmptyEntries));
            Console.WriteLine($"Without extra spaces:\n{text}");
        }

        public static void PrintFirstLetterOfWord()
        //Task6.
        {
            string text = "Hello, my name is Andrey and I learn C# programing language now";
            Console.WriteLine($"Our text: {text}");
            while (true)
            {
                Console.WriteLine("Input number of word that you want to found");
                int index = Convert.ToInt32(Console.ReadLine());
                index -= 1;
                if (index > text.Length)
                {
                    Console.WriteLine("Word with this number didn't exist in the this text, try again");
                    continue;
                }
                else
                {
                    string[] words = text.Split(' ');
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (i == index)
                        {
                            Console.WriteLine(words[i].Substring(0, 1));
                        }
                    }
                    break;
                }
            }
        }

        public static void ReverceOderOfWords()
        //Task7.
        {
            Console.WriteLine("Input your text");
            string text = Console.ReadLine();
            Console.WriteLine($"Normal order of the text: {text}");
            string[] array = text.Split(' ');
            string reverceOrder = "";
            for (int i = array.Length - 1; i >= 0; i--)
            {
                reverceOrder += array[i] + ' ';
            }
            Console.WriteLine($"Reverce order of text: {reverceOrder}");
        }

        public static void DeterminesLengthOfShortestAndLongest()
        //Task8.
        {
            string text = "Hello I want to tell you about myself";
            string[] array = text.Split(' ');
            int minLength = array[0].Length;
            int maxLength = array[0].Length;
            string maxWord = "";
            string minWord = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < minLength)
                {
                    minLength = array[i].Length;
                    minWord = array[i];
                }
            }
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j].Length > maxLength)
                {
                    maxLength = array[j].Length;
                    maxWord = array[j];
                }
            }
            Console.WriteLine($"Length of the most longest word is {maxLength} - word: {maxWord},\nthe shortest length is {minLength} in word: {minWord}");
        }
    }
}
      


           



   

