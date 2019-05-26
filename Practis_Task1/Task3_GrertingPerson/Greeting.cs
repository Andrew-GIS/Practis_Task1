using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3_GrertingPerson
{
    public class Greeting
    {
        public void HelloWord()
        {
            Human[] human = { new British("Scott"), new American("Jhon"), new Francian("Stefan"), new Polish("Zuzanna"), new Ukrainian("Степан") };

            foreach (var item in human)
            {
                item.SayHello();
            }
        }  
    }
}
