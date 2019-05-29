using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task6__Gallery
{
    public class Gallery
    {
        public Plant[] plant;

        public Worker worker;

        public Gallery(Plant[] plant, Worker worker)
        {
            this.plant = plant;
            this.worker = worker;
        }

        public void Work()
        {
            foreach (var item in this.plant)
            {
                Console.WriteLine($"{this.worker.GetType().Name} work with {item.Type}");
                worker.WorkWithPlants(item);
            }
        }
    }
}
