using System;
using Practis_Task1.Task3_ColorPrint;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3_ColorPrint
{
    public static class Print
    {
        string text = Inpute();
        int color = ChooseColor();
        
        public static string Inpute()
        {
            Console.WriteLine("Inpute you text");
            string text = Console.ReadLine();
            return text;
        }
        public static int ChooseColor()
        {
            int color;
            while (true)
            {
                Console.WriteLine("Please choose your color: " +
                    "\n1.Red" +
                    "\n2.Green" +
                    "\n3.Blue");

                if (!Int32.TryParse(Console.ReadLine(), out color))
                {
                    Console.WriteLine("Inpute correct value!");
                    continue;
                }
                if (color == 0 && color > 3)
                {
                    Console.WriteLine("Inpute correct value!");
                    continue;
                }
                return color;
            }
        }

        public void Result(int color, string text)
        {
            while (true)
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
        }

    }
    
}

