using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task4_Calculator
{
    class Calculate
    {
        Operation[] operations = {
            new SumOperation(), new SubtractOperation(), new MultiplyOperation(), new DivideOperation() };

        public void Calculator(double first, double second)
        {
            Console.WriteLine($"First value = {first}, Second value = {second} " +
                $"\nNow we seen the main math operation with this two values ");
            Console.WriteLine();
            foreach (var item in operations)
            {
                Console.WriteLine($"{item.GetType().Name} = {item.Calculate(first, second)}");
            }
            Console.WriteLine("\nThanks for your attention");        
        }
    }
}
