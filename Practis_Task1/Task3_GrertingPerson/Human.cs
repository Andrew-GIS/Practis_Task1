using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3_GrertingPerson
{
    public abstract class Human
    {
        public string Name { get; set; }

        public Human(string name)
        {
            Name = name;
        }

        public abstract void SayHello();
    }
}
