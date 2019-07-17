using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Calculator
{
    public class Calculator
    {
        public double Sum (double firstArgument, double secondArgument)
        {
            double result = firstArgument + secondArgument;
            return result;
        }

        public double Subtract(double firstArgument, double secondArgument)
        {
            double result = firstArgument - secondArgument;
            return result;
        }

        public double Multiplay(double firstArgument, double secondArgument)
        {
            double result = firstArgument * secondArgument;
            return result;
        }

        public double Divide(double firstArgument, double secondArgument)
        {
            double result = firstArgument / secondArgument;
            return result;
        }
    }

    public class Helper
    {
        public void Excecute(CalculateDelegate action)
        {
            double firstArgument = 10;
            double secondArgument = 20;

            var calculationResult = action.Invoke(firstArgument, secondArgument);

            Console.WriteLine(calculationResult);
        }
    }

    public class Execution
    {
        public void Execute()
        {
            var helper = new Helper();
            var calculator = new Calculator();

            helper.Excecute(calculator.Sum);
            helper.Excecute(calculator.Divide);
        }
    }

    public delegate double CalculateDelegate(double firstArgument, double secondArgument);
}
