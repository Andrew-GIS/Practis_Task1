using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Feeder
    {
        Mammals[] mammals =
        {
            new Terrestrial(0.5, 10),
            new Terrestrial(1, 5),
            new Subterranean(0.3, 5),
            new Subterranean(0.3, 43),
            new Arial(1.3, 13),
            new Arial(0.5, 1),
            new Aquatic(2, 3.2),
            new Aquatic(6, 5),
            new Arboreal(0.7, 2),
            new Arboreal(0.5, 3),
        };

        public void Feeding()
        {
            foreach (var item in mammals)
            {
                var rndFoodCount = new Random().Next(1, 40);
                item.Eat(rndFoodCount);
                Thread.Sleep(2000);
            }
        }
    }
}
