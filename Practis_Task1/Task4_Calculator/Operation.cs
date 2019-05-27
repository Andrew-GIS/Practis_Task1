using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task4_Calculator
{
    public abstract class Operation
    {
        public string action;

        public virtual string Action
        {
            get {
                return action = GetType().Name;
            }
        }
        public abstract double Calculate(double first, double second);

        public override string ToString()
        {
            return $"Вычисление происходит с помощью операции {GetType().Name}";
        }
    }
}
