using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Moto: Vehicle
    {
        public MotoType Type { get; set; }
        public Moto (MotoType type,
        int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            Type = type;
        }
        public override void DisplayCahracteristics(Vehicle vehicle)
        {
            Console.WriteLine(String.Format("{0, 6} | {1, 10} | {2, 9} | {3,10} | {4,5}",
                "Wheels",
                "Color",
                "Max Speed",
                "Passengers",
                "MotoType"));
            Console.Write(String.Format("{0, 6} | {1, 10} | {2, 9} | {3,10}",
                vehicle.WheelCount,
                vehicle.Color,
                vehicle.MaxSpeed,
                vehicle.PassengerCount,
                this.Type
                ));
            Console.WriteLine();
        }
    }
    enum MotoType
    {
        Adventure,
        Chopper,
        Cruiser,
        Enduro
    }
}
