using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_Train
{
    public class TrainsScheduler
    {
        private const int TransMaxNumber = 2;
        private Train[] trainList;

        public TrainsScheduler()
        {
            this.trainList = new Train[TrainsScheduler.TransMaxNumber];
        }

        public void Execute()
        {
            for (int i = 0; i < TrainsScheduler.TransMaxNumber; i++)
            {
                this.trainList[i] = this.GetNewTrain();
            }
            int selectTrainNumber = this.AskTrainNumber();

            this.DisplayTrainInfo(selectTrainNumber);
        }

        private int AskTrainNumber()
        {
            int number;
            while (true)
            {
                Console.WriteLine("Please enter a train number");
                if (int.TryParse(Console.ReadLine(), out number))
                    break;
            }
            return number;
        }

        private void DisplayTrainInfo(int trainNumber)
        {
            Train selectedTrain = new Train();
            for (int i = 0; i < TrainsScheduler.TransMaxNumber; i++)
            {
                if (this.trainList[i].GetTrainNumber() == trainNumber)
                    selectedTrain = this.trainList[i];
            }

            if (selectedTrain.GetTrainNumber() == 0)
            {
                Console.WriteLine($"Train number {trainNumber} was not found in the list of trains.");
                return;
            }
            Console.WriteLine($"Train {trainNumber} is departuring to {selectedTrain.GetDestination()} at {selectedTrain.GetDepartureTime()}");
        }

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
                Console.WriteLine("Enter the destination of the train");

                destination = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(destination))
                {
                    break;
                }
            }

            return new Train(numbers, destination, departureTime);
        }
    }
}
