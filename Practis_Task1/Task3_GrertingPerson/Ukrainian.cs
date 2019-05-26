using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3_GrertingPerson
{
    class Ukrainian: Human
    {
        public Ukrainian(string name) : base(name)
        {
            this.Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"{GetType().Name} greeting you with word - \"Слава Iссу - Слава Українi\" \nAlso {GetType().Name} loved tea without sugar");
        }
    }
}
