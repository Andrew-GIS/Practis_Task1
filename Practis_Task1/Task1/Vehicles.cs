using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    //
    //Link - https://docs.google.com/document/d/1FpgqIMQZixLwckypAdN0tQQZ0dtEoV8xKWTd7dcsC7k/edit.
    //
    class Vehicle
    {
        private int wheelCount;
        public ConsoleColor Color { get; set; }
        private int maxSpeed;
        public int PassengerCount { get; set; }

        public int WheelCount
        {
            get { return wheelCount; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Wheel number value should be more than 0");
                }
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
            this.WheelCount = wheelCount;
            this.Color = color;
            this.MaxSpeed = maxSpeed;
            this.PassengerCount = passengerCount;
        }

        public void Move(int metres)
        {
            Console.ForegroundColor = Color; // color of console
            Console.WriteLine($"{GetType().Name} has moved {metres} meters");
        }

        public virtual void DisplayCharacteristics(Vehicle vehicle)
        {
            Console.WriteLine(String.Format("{0, 6} | {1, 10} | {2, 9} | {3,10}", 
                "Wheels",
                "Color",
                "Max Speed",
                "Passengers"));
            Console.Write(String.Format("{0, 6} | {1, 10} | {2, 9} | {3,10}",
                vehicle.WheelCount,
                vehicle.Color,
                vehicle.MaxSpeed,
                vehicle.PassengerCount));
            Console.WriteLine();
        }

    }
}
