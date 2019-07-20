using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Manager
    {
        public void ManageRefregerator()
        {
            bool check = true;
            Console.WriteLine("hello let see to our refregerator\nCurrent status");
            Refregerator referegerator = new Refregerator(OperationMode.Off, OpenTypeMain.Open, OpenTypeFrizer.Close);
            referegerator.ToString();
            while (check == true)
            {
                Console.WriteLine($"Menu:\n" +
                    $"1. Turn OFF/ Turn ONN\n" +
                    $"2. Close/Open Main Door\n" +
                    $"3. Close/Open Freezer Dorr\n" +
                    $"4. Exit");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case (1):
                        referegerator.SwitchPowerRegime();
                        Console.WriteLine(Environment.NewLine);
                        continue;
                    case (2):
                        referegerator.ChangeMainDoorRegime();
                        Console.WriteLine(Environment.NewLine);
                        continue;
                    case (3):
                        referegerator.ChangeFrezerDoorRegime();
                        Console.WriteLine(Environment.NewLine);
                        continue;
                    case (4):
                        check = false;
                        break;
                }
            }
        }
    }
}
