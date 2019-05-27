using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task5
{
    public class Lynx: Animal, IPurr
    {
        public override string  Bite()
        {
            string action = $"Рысь {0} кусает", Name;
            return action;
        }

        public void Purr()
        {
            Console.WriteLine("Рысь {0} мурчит", Name);
        }
    }
}
