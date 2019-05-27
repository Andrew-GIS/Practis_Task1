using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task4_Calculator
{
    class SubtractOperation : Operation
    {
        private string action;

        public override string Action
        {
            get
            {
                return action = GetType().Name;
            }
        }
        public override double Calculate(double first, double second)
        {
            return first - second;
        }
    }
}
