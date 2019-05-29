using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    class House
    {
        public void CheckGadgets()
        {
            Toster toster = new Toster();
            toster.State();
            Computer computer = new Computer();
            computer.State();
            Console.WriteLine("Seems you checked your gadgets, goodbye!");
        }
    }
}

interface ISwitchable
{
    void TurnOn(bool state);
    void TurnOff(bool state);
}



