using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task6__Gallery
{
    public class Gallery
    {
        private Plant[] plants;

        private Worker worker;

        public Gallery(Plant[] plants, Worker worker)
        {
            this.plants = plants;
            this.worker = worker;
        }

        public void Work()
        {
            foreach (var item in this.plants)
            {
                Console.WriteLine($"{this.worker.GetType().Name} manage {item.Type}");
                worker.WorkWithPlants(item);
            }
        }
    }
}
