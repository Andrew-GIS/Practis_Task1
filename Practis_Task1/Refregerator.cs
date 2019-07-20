using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Refregerator
    {
        private OpenTypeMain mainDoor;
        private OperationMode operationMode;
        private OpenTypeFrizer freezerDoor;

        public OpenTypeMain MainDoor
        {
            get
            {
                return mainDoor;
            }
            set
            {
                mainDoor = value;
            }
        }

        public OperationMode OperationMode
        {
            get
            {
                return operationMode;
            }
            set
            {
                operationMode = value;
            }
        }

        public OpenTypeFrizer FreezerDoor
        {
            get
            {
                return freezerDoor;
            }
            set
            {
                freezerDoor = value;
            }
        }

        public event EventHandler someEvent;

        public Refregerator(OperationMode mode, OpenTypeMain main, OpenTypeFrizer frezer)
        {
            this.mainDoor = main;
            this.operationMode = mode;
            this.freezerDoor = frezer;
        }

        protected virtual void EventMassage(EventArgs e)
        {
            this.someEvent?.Invoke(this, e);
        }


        public void ChangeMainDoorRegime()
        {
            Console.WriteLine($"lets look to our door");
            if (mainDoor == OpenTypeMain.Close)
            {
                Console.WriteLine("Main Door is close, lets open it.");
                mainDoor = OpenTypeMain.Open;
                this.EventMassage(new EventArgs());
            }
            else
            {
                Console.WriteLine("Main Door is open, lets close it.");
                mainDoor = OpenTypeMain.Close;
                this.EventMassage(new EventArgs());
            }
        }

        public void ChangeFrezerDoorRegime()
        {
            Console.WriteLine($"lets look to our frizer door");
            if (freezerDoor == OpenTypeFrizer.Close)
            {
                Console.WriteLine("Freezer Door is close, lets open it.");
                freezerDoor = OpenTypeFrizer.Open;
                this.EventMassage(new EventArgs());
            }
            else
            {
                Console.WriteLine("Freezer Door is open, lets close it.");
                freezerDoor = OpenTypeFrizer.Close;
                this.EventMassage(new EventArgs());
            }
        }

        public void SwitchPowerRegime()
        {
            Console.WriteLine("Lets check power regime of our refregerator");
            if (operationMode == OperationMode.Off)
            {
                Console.WriteLine("Our refregerator is ON lets turn ON it.");
                operationMode = OperationMode.On;
                this.EventMassage(new EventArgs());
            }
            else
            {
                Console.WriteLine("Our refregerator is ON lets turn OFF it.");
                operationMode = OperationMode.Off;
                this.EventMassage(new EventArgs());
            }
        }

        public override string ToString()
        {
            return $"Your refregerator now is: Regime - {this.operationMode.GetType()}, Main Door - {this.mainDoor}, Freezer - {this.freezerDoor.ToString()} ";
        }
    }
}

public enum OpenTypeMain
{
    Close,
    Open
}

public enum OpenTypeFrizer
{
    Close,
    Open
}

enum OperationMode
{
    On,
    Off
}
    