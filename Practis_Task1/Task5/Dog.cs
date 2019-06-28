using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task5
{
    public class Dog : Animal
    {
        public override string Bite()
        {
            string action = $"Собака {Name} кусает" ;
            return (action);
        }
    }
}
