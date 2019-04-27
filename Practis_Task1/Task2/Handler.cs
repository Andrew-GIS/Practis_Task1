using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    public class Handler
    {
        public void Execute()
        {
            MyClass myClassInstance = new MyClass();
            myClassInstance.SetStructureFirld("Initial class field value");

            MyStructure myStructureInstance = new MyStructure();
            myStructureInstance.SetStructureFirld("Initial structure field value");

            this.Change(myClassInstance);
            this.Change(myStructureInstance);
            Console.WriteLine($"Class field is: {myClassInstance.GetClassField()}");
            Console.WriteLine($"Structure field is: {myStructureInstance.GetStrucureField()}");
        }
        private void Change(MyStructure instance)
        {
            instance.SetStructureFirld("Structure has benn changed");
        }
        private void Change(MyClass instance)
        {
            instance.SetStructureFirld("Class has been changed");
        }
    }
}
