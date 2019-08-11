using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2
{
    class HuntingProcess
    {
        Rabbit rabbit = new Rabbit();

        Hunter hunter = new Hunter();

        public void DoHuntingProcess()
        {
            this.rabbit.NewRabbitLocation += this.InvokedNewLocation;
            this.rabbit.RabbitMoving();
            this.rabbit.NewRabbitLocation -= this.InvokedNewLocation;
        }

        public void InvokedNewLocation(int locationX, int locationY)
        {
            this.hunter.GetRabbitLocation(locationX, locationY);
        }
    }
}
