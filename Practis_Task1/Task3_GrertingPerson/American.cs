using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3_GrertingPerson
{
    class American: Human
    {
        public American(string name) : base(name)
        {
            this.Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"{GetType().Name} greeting you with word - \"HI - Make America Great Again\" \nAlso {GetType().Name} love Bourbon");
        }
    }
}
