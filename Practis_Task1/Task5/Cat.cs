using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task5
{
    public class Cat : Animal, IPurr
    {
        public override string Bite()
        {
            string action = $"Кошка {0} кусает", Name;
            return action;
        }

        public void Purr()
        {
            Console.WriteLine("Кошка {0} мурчит", Name);
        }
    }
}
