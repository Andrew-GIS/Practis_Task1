using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    class Computer : ISwitchable
    {
        public void State()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Lets check computer!");
            bool state;
            while (true)
            {
                Console.WriteLine("Your computer is ON? Y - if Yes, N - if No ");
                string choose = Console.ReadLine();
                if (choose == "Y")
                    state = true;
                else if (choose == "N")
                    state = false;
                else
                {
                    Console.WriteLine("Inpute correct value");
                    continue;
                }

                if (state == true)
                {
                    Computer computer = new Computer();
                    computer.TurnOn(state);
                    break;
                }
                else if (state == false)
                {
                    Computer computer = new Computer();
                    computer.TurnOff(state);
                    break;
                }
            }
        }

        public void TurnOn(bool state)
        {
            if (state == true)
                Console.WriteLine("Your computer is ON");
            while (true)
            {
                Console.WriteLine("Do you want torn OFF your computer: Y- yes / N - no");
                string off_er = Console.ReadLine();
                if (off_er == "Y")
                {
                    Console.WriteLine("Your computer is OFF"); break;
                }
                else if (off_er == "N")
                {
                    Console.WriteLine("Okay, let it be"); break;
                }
                else
                {
                    Console.WriteLine("Inpute correct value");
                    break;
                }
            }
        }

        public void TurnOff(bool state)
        {
            if (state == false)
            Console.WriteLine("Your computer is OFF");
            while (true)
            {
                Console.WriteLine("Do you want torn ON your computer: Y- yes / N - no");
                string on_er = Console.ReadLine();
                if (on_er == "Y")
                {
                    Console.WriteLine("Your computer is ON"); break;
                }
                else if (on_er == "N")
                {
                    Console.WriteLine("Okay, let it be");break;
                }
                else
                {
                    Console.WriteLine("Inpute correct value");
                    continue;
                }
            }
        }

    }
}
