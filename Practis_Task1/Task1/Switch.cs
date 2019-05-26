using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    class Switch
    {
        
    }
}

interface ISwitchable
{
    void TurnOn(bool state);
    void TurnOff(bool state);
}

class Toster : ISwitchable
{
    public void State()
    {
        bool state;
        while (true)
        {
            Console.WriteLine("Your toster is ON? Y - if Yes, N - if No ");
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
                Toster toster = new Toster();
                toster.TurnOn(state);
                break;
            }
            else if (state == false)
            {
                Toster toster = new Toster();
                toster.TurnOff(state);
                break;
            }
        }
    }

    public void TurnOn(bool state)
    {
        if (state == true)
            Console.WriteLine("Your Toster is ON");
        //while (true)
        //{
            Console.WriteLine("Do you want torn OFF your toster: Y- yes / N - no");
            string off_er = Console.ReadLine();
            if (off_er == "Y")
                Console.WriteLine("Your Toster is OFF");
            else if (off_er == "N")
                Console.WriteLine("Okay, let it be");
            else
            {
                Console.WriteLine("Inpute correct value");
            //    continue;
            //}
        }
    }

    public void TurnOff(bool state)
    {
        if (state == false)
        Console.WriteLine("Your Toster is OFF");
        //while (true)
        //{
            Console.WriteLine("Do you want torn ON your toster: Y- yes / N - no");
            string on_er = Console.ReadLine();
            if (on_er == "Y")
            {
                Console.WriteLine("Your Toster is ON");
            }
            else if (on_er == "N")
                Console.WriteLine("Okay, let it be");
            else
            {
                Console.WriteLine("Inpute correct value");
        //        continue;
        //    }
            }
    }
}

class Computer : ISwitchable
{
    public void State()
    {
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
        //while (true)
        //{
            Console.WriteLine("Do you want torn OFF your computer: Y- yes / N - no");
            string off_er = Console.ReadLine();
            if (off_er == "Y")
                Console.WriteLine("Your computer is OFF");
            else if (off_er == "N")
                Console.WriteLine("Okay, let it be");
            else
            {
                Console.WriteLine("Inpute correct value");
            //    break;
            //}
        }
    }

    public void TurnOff(bool state)
    {
        if (state == false)
            Console.WriteLine("Your computer is OFF");
        //while (true)
        //{
            Console.WriteLine("Do you want torn ON your computer: Y- yes / N - no");
            string on_er = Console.ReadLine();
            if (on_er == "Y")
                Console.WriteLine("Your computer is OFF");
            else if (on_er == "N")
                Console.WriteLine("Okay, let it be");
            else
            {
                Console.WriteLine("Inpute correct value");
            //    break;
            //}
        }
    }

}