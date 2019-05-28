using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task6__Gallery
{
    public class Worker
    {
        public void WorkWithPlants(Plant plant)
        {
            if (plant is Flowers flowers)
            {
                flowers.TookWater();
                flowers.TookMineral();
                flowers.DoPhotosynthesis();
                flowers.LeafNumberChange();
                flowers.PetalNumberChange();
            }
            else if (plant is Tree tree)
            {
                tree.TookWater();
                tree.TookMineral();
                tree.DoPhotosynthesis();
                tree.BranchNumberChange();
                tree.AnimalsThatLivesInTreeNumberChange();
            }
        }
    }
}
