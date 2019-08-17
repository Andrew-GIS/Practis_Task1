using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    public class Hunter
    {
        public void GetRabbitLocation(int LocationX, int LocationY)
        {
            Console.WriteLine($"I found rabbit on next coordinate\n" +
                $"X: {LocationX}{Environment.NewLine}" +
                $"Y: {LocationY}{Environment.NewLine}");
        }
    }
}
