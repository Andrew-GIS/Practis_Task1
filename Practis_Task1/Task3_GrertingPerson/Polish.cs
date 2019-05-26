using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3_GrertingPerson
{
    class Polish: Human
    {
        public Polish(string name) : base(name)
        {
            this.Name = name;
        }

        public override void SayHello()
        {
            Console.WriteLine($"{GetType().Name} greeting you with word - \"Cześć - Bóg ocalić Rzeczpospolitą\" \nAlso {GetType().Name} loved juice");
        }
    }
}
