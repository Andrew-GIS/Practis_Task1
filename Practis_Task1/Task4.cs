using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class Task4
    {
        public static void PIN()
        {
            //Console.WriteLine(Check_Digit());
            string pin = Check_Digit();
            Console.WriteLine(Check_Quantity(pin));
        }

        public static string Check_Digit()
        {
            while (true)
            {
                Console.WriteLine("Inpute youu PIN");
                string inpute = Console.ReadLine();
                if (Int32.TryParse(inpute, out int pin))
                {
                    
                    Console.WriteLine($"Your PIN consist of digit only - good");
                }
                else
                {
                    Console.WriteLine("Inpute correct value");
                    continue;
                }

                return inpute;
            }
        }

        public static bool Check_Quantity(string pin)
        {
            bool check = true;
            while (true)
            {
                if (pin.Length == 4 || pin.Length == 6)
                {
                    Console.WriteLine("You passvord is OK");
                    
                }
                else
                {
                    Console.WriteLine("You PIN is not according to requirements");
                    check = false;
                }
                return check;
            }

        }

    }
}
