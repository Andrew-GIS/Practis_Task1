using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Mammals
{
    public class FeedingAndMoving
    {
        public void FeedAndMoveProcess()
        {
            Mammals[] mammals = { new Arboreal(0.6), new Aquatic (0.250), new Arial (0.5), new Subterranean (0.5), new Terrestrial(0.5)};

            for (int i = 0; i < mammals.Length; i++)
            { 
                mammals[i].Eat();
                mammals[i].Move();
            }
        }


    }
}
