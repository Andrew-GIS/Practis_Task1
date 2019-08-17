using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class Refregerator
    {
        public DoorState MainDoor { get; set; }

        public RefregeratorStatus RefregeratorStatus { get; set; }

        public DoorState FreezerDoor { get; set; }

        public event EventHandler<RefregeratorEventArgs> EventRefregerator;

        public Refregerator()
        {
            this.MainDoor = DoorState.Close;
            this.RefregeratorStatus = RefregeratorStatus.On;
            this.FreezerDoor = DoorState.Close;
        }

        protected virtual void RefregeratorEvent(RefregeratorEventArgs e)
        {
            if (this.EventRefregerator != null)
            {
                e.RefregeratorStatus = this.RefregeratorStatus;
                e.MainDoor = this.MainDoor;
                e.FreezerDoor = this.FreezerDoor;

                this.EventRefregerator(this, e);
            }
        }

        public void SendMessage(string message)
        {
            this.RefregeratorEvent(new RefregeratorEventArgs(this.RefregeratorStatus, this.MainDoor, this.FreezerDoor, message));
        }

        public RefregeratorStatus TurnOnRefregerator()
        {
            this.RefregeratorStatus = RefregeratorStatus.On;
            this.SendMessage($"Refregerator is {this.RefregeratorStatus}");
            return RefregeratorStatus;
        }

        public RefregeratorStatus TurnOffRefregerator()
        {
            this.RefregeratorStatus = RefregeratorStatus.Off;
            this.SendMessage($"Refregerator is {this.RefregeratorStatus}");
            return RefregeratorStatus;
        }

        public DoorState OpenMainDoor()
        {
            this.MainDoor = DoorState.Open;
            this.SendMessage($"Main door is {this.MainDoor}");
            return MainDoor;
        }

        public DoorState CloseMainDoor()
        {
            this.MainDoor = DoorState.Close;
            this.SendMessage($"Main door is {this.MainDoor}");
            return MainDoor;
        }

        public DoorState CloseFreezerDoor()
        {
            this.FreezerDoor = DoorState.Close;
            this.SendMessage($"Freezer door is {this.MainDoor}");
            return FreezerDoor;
        }

        public DoorState OpenFreezerDoor()
        {
            this.FreezerDoor = DoorState.Open;
            this.SendMessage($"Freezer door is {this.MainDoor}");
            return FreezerDoor;
        }

        public override string ToString()
        {
            return $"Your refregerator now is:{Environment.NewLine}" +
                $"-Regime - {this.RefregeratorStatus.ToString()}{Environment.NewLine}" +
                $"-Main Door - {this.MainDoor.ToString()}{Environment.NewLine}" +
                $"-Freezer - {this.FreezerDoor.ToString()} ";
        }
    }
}

public enum DoorState
{
    Close = 0,
    Open = 1
}

public enum RefregeratorStatus
{
    On = 0,
    Off = 1
}