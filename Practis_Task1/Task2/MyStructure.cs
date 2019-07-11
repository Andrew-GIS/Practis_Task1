using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
   public struct MyStructure
    {
        private string change;

        public string GetStrucureField()
        {
            return this.change;
        }

        public void SetStructureFirld(string fieldValue)
        {
            this.change = fieldValue;
        }
    }
}
