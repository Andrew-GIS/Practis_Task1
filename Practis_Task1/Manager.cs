using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practis_Task1.Enums;

namespace Practis_Task1
{
    class Manager
    {
        Refregerator referegerator = new Refregerator();

        public void ManageRefregerator()
        {
            this.referegerator.refregeratorEvent += this.OnRefregiratorEventInvoked;

            bool check = true;

            while (check == true)
            {
                Console.WriteLine($"Menu:{Environment.NewLine}" +
                    $"1. Turn OFF {Environment.NewLine}" +
                    $"2. Turn ON {Environment.NewLine}" +
                    $"3. Close Main Door {Environment.NewLine}" +
                    $"4. Open Main Door {Environment.NewLine}" +
                    $"5. Close Freezer Dorr {Environment.NewLine}" +
                    $"6. Open Freezer Dorr {Environment.NewLine}" +
                    $"7. Exit{Environment.NewLine}");

                string choose = Console.ReadLine();
                
                int checkedChoose;

                if (!int.TryParse(choose, out checkedChoose))
                {
                    Console.WriteLine("This is not a number, input correct number");
                }

                else if (checkedChoose < 1)
                {
                    Console.WriteLine("Please, input correct variant");
                    continue;
                }

                switch (checkedChoose)
                {
                    case (1):
                        if (referegerator.RefregeratorStatus == RefregeratorStatus.Off)
                        {
                            Console.WriteLine($"Your refregerator already OFF {Environment.NewLine}");
                            continue;
                        }
                        else
                        {
                            referegerator.TurnOffRefregerator();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (2):
                        if (referegerator.RefregeratorStatus == RefregeratorStatus.On)
                        {
                            Console.WriteLine($"Your refregerator already ON {Environment.NewLine}");
                            continue;
                        }
                        else
                        {
                            referegerator.TurnOnRefregerator();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (3):
                        if (referegerator.MainDoor == DoorState.Close)
                        {
                            Console.WriteLine($"Your Main door already Closed {Environment.NewLine}");
                            continue;
                        }
                        else
                        {
                            referegerator.CloseMainDoor();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (4):
                        if (referegerator.MainDoor == DoorState.Open)
                        {
                            Console.WriteLine($"Your Main door already Open {Environment.NewLine}");
                            continue;
                        }
                        else
                        {
                            referegerator.OpenMainDoor();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (5):
                        if (referegerator.FreezerDoor == DoorState.Close && referegerator.MainDoor == DoorState.Open)
                        {
                            Console.WriteLine($"Your Freezer door already Closed {Environment.NewLine}");
                            continue;
                        }
                        else if (referegerator.MainDoor == DoorState.Close)
                        {
                            Console.WriteLine("You should open main door for this action");
                            continue;
                        }
                        else
                        {
                            referegerator.CloseFreezerDoor();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (6):
                        if (referegerator.FreezerDoor == DoorState.Open && referegerator.MainDoor == DoorState.Open)
                        {
                            Console.WriteLine($"Your Freezer door already Open {Environment.NewLine}");
                            continue;
                        }
                        else if (referegerator.MainDoor == DoorState.Close)
                        {
                            Console.WriteLine("You should open main door for this action");
                            continue;
                        }
                        else
                        {
                            referegerator.OpenFreezerDoor();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (7):
                        check = false;
                        this.referegerator.refregeratorEvent -= this.OnRefregiratorEventInvoked;
                        Console.WriteLine("Good Luck");
                        break;
                }
            }
        }

        public void OnRefregiratorEventInvoked(object sender, RefregeratorEventArgs e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine($"Your refregerator now is:{Environment.NewLine}" +
                $"-Regime - {e.refregeratorStatus}{Environment.NewLine}" +
                $"-Main Door - {e.mainDoor}{Environment.NewLine}" +
                $"-Freezer - {e.freezerDoor}");
        }
    }
}
