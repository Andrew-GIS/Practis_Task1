using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practis_Task1.Enums;

namespace Practis_Task1
{
    class RefregeratorEventArgs: EventArgs
    {
        public DoorState mainDoor { get; set; }

        public RefregeratorStatus refregeratorStatus { get; set; }

        public DoorState freezerDoor { get; set; }

        public string Message { get; }

        public RefregeratorEventArgs(string message)
        {
            this.Message = message;
        }

        public RefregeratorEventArgs(RefregeratorStatus refregeratorStatus, DoorState mainDoor, DoorState freezerDoor, string message)
        {
            this.refregeratorStatus = refregeratorStatus;
            this.mainDoor = mainDoor;
            this.freezerDoor = freezerDoor;
            Message = message;
        }
    }
}