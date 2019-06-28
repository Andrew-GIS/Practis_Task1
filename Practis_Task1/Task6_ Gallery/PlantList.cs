using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task6__Gallery
{
    class PlantList
    {
        public static Plant[] GetListOfPlans() 
        {
            Plant[] plant =
            {
                new Flowers("Rose", ConsoleColor.Red, 2, 5),
                new Flowers("Chamomile", ConsoleColor.White, 1, 8),
                new Tree("Oak", ConsoleColor.Gray, 20, 1),
                new Tree("Birth", ConsoleColor.White, 10, 1)
            };
            return plant;
        }
    }
}
