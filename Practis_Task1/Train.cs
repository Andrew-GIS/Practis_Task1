using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public struct Train
    {
        /// <summary>
        /// /
        /// </summary>
        private int trainNumber;

        private string destination;

        private DateTime departureTime;

        public Train(int trainNumber, string destination, DateTime departureTime)
        {
            if (trainNumber == 0)
            {
                throw new ArgumentException(nameof(trainNumber));
            }
            if (string.IsNullOrWhiteSpace(destination))
                throw new ArgumentException(nameof(destination));
            this.trainNumber = trainNumber;
            this.destination = destination;
            this.departureTime = departureTime;
        }
    }
}
