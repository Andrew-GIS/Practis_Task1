﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Car : Vehicle
    {
        //property
        public int DoorsCount { get; set; }
        public EngineType Engine { get; set; }
        public GearBoxType GearBox { get; set; }

        //constructor
        public Car(int doorsCount, EngineType engine, GearBoxType gearBox,
            int wheelCount, ConsoleColor color, int maxSpeed, int passengerCount)
            : base(wheelCount, color, maxSpeed, passengerCount)
        {
            DoorsCount = doorsCount;
            Engine = engine;
            GearBox = gearBox;
        }
    }

    enum EngineType
    {
        Petrol,
        Diesel,
        Electro
    }

    enum GearBoxType
    {
        Manual,
        Auto,
        Robot
    }
}
