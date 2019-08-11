using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    class Hunter
    {
        public void GetRabbitLocation(int locationX, int locationY)
        {
            int huntingTry = 0;
            if (huntingTry < 10)
            {
                Console.WriteLine($"I found rabbit on next coordinate\n" +
                    $"X: {locationX}\n" +
                    $"Y: {locationY}\n");
                huntingTry++;
            }
            else
            {
                Console.WriteLine("Need to have some break time");
            }
        }
    }
}
