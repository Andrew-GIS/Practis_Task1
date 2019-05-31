using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    class Printer
    {
        public string InputeColorProgram()
        {
            Console.WriteLine("Hello!\nWe use alphabetic color order to print different color labels");
            while (true)
            {
                Console.WriteLine("Input your color order");
                string colorOrder = Console.ReadLine();
                if (colorOrder.Any(char.IsUpper) || colorOrder.Any(char.IsDigit))
                {
                    Console.WriteLine("Operator, no Uppercase and digits in order, please");
                    continue;
                }
                else
                {
                    ColorErrors(colorOrder);
                    return colorOrder;
                    break;
                }
            }
        }

        public int ColorErrors(string colorOrder)
        {
            
            string goodOrder = "abcdefghijklm";
            int counter = 0;
            for (int i = 0; i < colorOrder.Length; i++)
            {
                for (int j = 0; j < goodOrder.Length; j++)
                {
                    if (colorOrder[i] == goodOrder[j])
                    {
                        counter++;
                    }
                }
            }

            return colorOrder.Length-counter;

        }

        public void ShowResult()
        {
            string colorOrder = InputeColorProgram();
            int error = ColorErrors(colorOrder);

            Console.WriteLine($"Our program color order: {colorOrder}.");
            Console.WriteLine($"The result is {error}/{colorOrder.Length}.");
            Console.WriteLine($"That means {error} is number of illegal characters.");
            Console.WriteLine($"{colorOrder} - number of all characters.");
        }
    }
}
