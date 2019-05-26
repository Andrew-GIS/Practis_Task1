using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3_GrertingPerson
{
    class Francian: Human
    {
        public Francian(string name) : base(name)
        {
            this.Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"{GetType().Name} greeting you with word - \"Salut - Liberté, Égalité, Fraternité\" \nAlso {GetType().Name} loved vine");
        }
    }
}
