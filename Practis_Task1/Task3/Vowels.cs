using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3
{
    class Vowels
    {
        public string GetText()
        {
            while (true)
            {
                Console.WriteLine("Hello, inpute your text please");
                string text = Console.ReadLine();

                if (text.Any(char.IsUpper) || text.Any(char.IsDigit))
                {
                    Console.WriteLine("Your message must consist of lowercase letters only");
                    continue;
                }

                return text;
            }
        }

        public void FoundingVowels()
        {
            var message = GetText();
            int counter = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'a' || message[i] == 'e' || message[i] == 'i' || message[i] == 'o' || message[i] == 'u')
                {
                    counter += 1;
                }
            }
            Console.WriteLine($"Message : have {counter} vowels");
        }
    }
}
