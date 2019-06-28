using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Calculator
{
    class Culculate_Func
    {
        public double SumFunk(double firstArgument, double secondArgument)
        {
            double result = firstArgument + secondArgument;
            return result;
        }

        public double SubtractFunk(double firstArgument, double secondArgument)
        {
            double result = firstArgument - secondArgument;
            return result;
        }

        public double MultiplayFunk(double firstArgument, double secondArgument)
        {
            double result = firstArgument * secondArgument;
            return result;
        }

        public double DivideFunk(double firstArgument, double secondArgument)
        {
            double result = firstArgument / secondArgument;
            return result;
        }
    }

    public class HelperFunk
    {
        public void Excecute(Func<double, double, double> action)
        {
            double firstArgument = 10;
            double secondArgument = 20;

            var calculationResult = action.Invoke(firstArgument, secondArgument);

            Console.WriteLine(calculationResult);
        }
    }

    public class ExecutionFunk
    {
        public void ExecuteFunk()
        {
            var helper = new HelperFunk();
            var calculator = new Calculator();

            helper.Excecute(calculator.Sum);
            helper.Excecute(calculator.Divide);
        }
    }
    public delegate double CalculateDelegateFunk(double firstArgument, double secondArgument);
}

