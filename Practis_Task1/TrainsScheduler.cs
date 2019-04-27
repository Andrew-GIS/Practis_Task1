using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class TrainsScheduler
    {
        private Train GetNewTrain()
        {
            int numbers;
            while (true)
            {
                Console.WriteLine("Eter the number of the train");
                if (int.TryParse(Console.ReadLine(), out numbers))
                {
                    break;
                }
            }
            DateTime departureTime;
            while (true)
            {
                Console.WriteLine("Eter the departure time of the train");
                if (DateTime.TryParse(Console.ReadLine(), out departureTime))
                {
                    break;
                }
            }
           
            string destination = string.Empty;
            while (true)
            {
                Console.WriteLine("Eter the destination of the train");

                destination = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(Console.ReadLine()))
                {
                    break;
                }
            }

            return new Train(numbers, destination, departureTime);
        }
    }
}
