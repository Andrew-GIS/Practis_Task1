using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    public class MyClass
    {
        private string change;

        public string GetClassField()
        {
            return this.change;
        }

        public void SetStructureFirld(string fieldValue)
        {
            this.change = fieldValue;
        }

    }
}
