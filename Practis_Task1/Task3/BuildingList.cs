using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3
{
    class BuildingList
    {
        public void BuildList()
        {
            LinkedList<string> foodChain = new LinkedList<string>();
            foodChain.Add("Corn");
            foodChain.Add("Mouse");
            foodChain.Add("Bird");
            foodChain.Add("Cat");
            foodChain.Add("Wolf");
            foodChain.Add("Hunter");
            foodChain.Add("Person in restaurant");

            Console.WriteLine("Display of chain");
            foreach (var item in foodChain)
            {
                Console.WriteLine($"-{item}");
            }
            Console.WriteLine("Chain after removing:");
            foodChain.Remove("Person in restaurant");

            foreach (var item in foodChain)
            {
                Console.WriteLine($"-{item}");
            }
            bool lookFor = foodChain.Contains("Cat");
            Console.WriteLine(lookFor == true? "Cat is present" : "Cat is absent");

            foodChain.AppendFirst("Mineral");
            Console.WriteLine("Display of chain after changing first element");
            foreach (var item in foodChain)
            {
                Console.WriteLine($"-{item}");
            }
        }
    }
}
