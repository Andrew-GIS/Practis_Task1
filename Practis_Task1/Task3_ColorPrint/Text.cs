using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3_ColorPrint
{
    public class TextPrint
    {
        string text = InputText();
        
        public static string InputText()
        {
            Console.WriteLine("Hello, you can write your text: ");
            string text = Console.ReadLine();

            while (true)
            {
                int color;
                Console.WriteLine("Please choose your color: " +
                    "\n1.Red" +
                    "\n2.Green" +
                    "\n3.Blue");

                if (!Int32.TryParse(Console.ReadLine(), out color))
                {
                    Console.WriteLine("Inpute correct value!");
                    continue;
                }
                else
                {
                    switch (color)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(text);
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(text);
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(text);
                            break;
                        default:
                            Console.WriteLine("Inpute corret value");
                            continue;
                    }
                }
                return text;
            }
        }
    }
}
