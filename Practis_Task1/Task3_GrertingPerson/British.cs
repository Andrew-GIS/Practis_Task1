using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3_GrertingPerson
{
    class British : Human
    {
        public British(string name) :base(name)
        {
            this.Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"{GetType().Name} greeting you with word - \"Hello - God, Save the Queen\" \nAlso {GetType().Name} loved tea");
        }
    }
}
