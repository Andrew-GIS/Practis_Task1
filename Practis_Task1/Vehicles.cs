using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Vehicle
    {
        private int wheelCount = 1;
        public ConsoleColor Color { get; set; }
        private int maxSpeed = 1;
        public int PassengerCount { get; set; }

        public int WheelCount
        {
            get { return wheelCount; }
            set
            {
                if (value > 0)
                {
                    wheelCount = value;
                }
            }
        }

        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Speed value should be more than 0");
                }
                else maxSpeed = value;
            }
        }

        public Vehicle(int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
        {
            WheelCount = wheelCount;
            Color = color;
            MaxSpeed = maxSpeed;
            PassengerCount = passengerCount;
        }

        public void Move(int metres)
        {
            Console.ForegroundColor = Color; // color of console
            Console.WriteLine($"{GetType().Name} has moved {metres} meters");
        }

    }
}
