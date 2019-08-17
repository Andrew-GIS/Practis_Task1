using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class Manager
    {
        public Refregerator refregerator;

        public Manager()
        {
            Refregerator refregerator = new Refregerator();
        }
        

        public void ManageRefregerator()
        {
            this.refregerator.EventRefregerator += this.OnRefregiratorEventInvoked;

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
                        if (this.refregerator.RefregeratorStatus == RefregeratorStatus.Off)
                        {
                            Console.WriteLine($"Your refregerator already OFF {Environment.NewLine}");
                            continue;
                        }
                        else
                        {
                            refregerator.TurnOffRefregerator();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (2):
                        if (this.refregerator.RefregeratorStatus == RefregeratorStatus.On)
                        {
                            Console.WriteLine($"Your refregerator already ON {Environment.NewLine}");
                            continue;
                        }
                        else
                        {
                            refregerator.TurnOnRefregerator();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (3):
                        if (this.refregerator.MainDoor == DoorState.Close)
                        {
                            Console.WriteLine($"Your Main door already Closed {Environment.NewLine}");
                            continue;
                        }
                        else
                        {
                            refregerator.CloseMainDoor();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (4):
                        if (this.refregerator.MainDoor == DoorState.Open)
                        {
                            Console.WriteLine($"Your Main door already Open {Environment.NewLine}");
                            continue;
                        }
                        else
                        {
                            refregerator.OpenMainDoor();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (5):
                        if (this.refregerator.FreezerDoor == DoorState.Close && refregerator.MainDoor == DoorState.Open)
                        {
                            Console.WriteLine($"Your Freezer door already Closed {Environment.NewLine}");
                            continue;
                        }
                        else if (refregerator.MainDoor == DoorState.Close)
                        {
                            Console.WriteLine("You should open main door for this action");
                            continue;
                        }
                        else
                        {
                            refregerator.CloseFreezerDoor();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (6):
                        if (this.refregerator.FreezerDoor == DoorState.Open && refregerator.MainDoor == DoorState.Open)
                        {
                            Console.WriteLine($"Your Freezer door already Open {Environment.NewLine}");
                            continue;
                        }
                        else if (this.refregerator.MainDoor == DoorState.Close)
                        {
                            Console.WriteLine("You should open main door for this action");
                            continue;
                        }
                        else
                        {
                            refregerator.OpenFreezerDoor();
                            Console.WriteLine(Environment.NewLine);
                            continue;
                        }
                    case (7):
                        check = false;
                        this.refregerator.EventRefregerator -= this.OnRefregiratorEventInvoked;
                        Console.WriteLine("Good Luck");
                        break;
                }
            }
        }

        public void OnRefregiratorEventInvoked(object sender, RefregeratorEventArgs e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine($"Your refregerator now is:{Environment.NewLine}" +
                $"-Regime - {e.RefregeratorStatus}{Environment.NewLine}" +
                $"-Main Door - {e.MainDoor}{Environment.NewLine}" +
                $"-Freezer - {e.FreezerDoor}");
        }
    }
}
