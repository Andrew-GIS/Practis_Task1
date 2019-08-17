using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class RefregeratorEventArgs : EventArgs
    {
        public DoorState MainDoor { get; set; }

        public RefregeratorStatus RefregeratorStatus { get; set; }

        public DoorState FreezerDoor { get; set; }

        public string Message { get; }

        //public RefregeratorEventArgs(string message)
        //{
        //    this.Message = message;
        //}

        public RefregeratorEventArgs(RefregeratorStatus refregeratorStatus, DoorState mainDoor, DoorState freezerDoor, string message)
        {
            this.RefregeratorStatus = refregeratorStatus;
            this.MainDoor = mainDoor;
            this.FreezerDoor = freezerDoor;
            this.Message = message;
        }
    }
}