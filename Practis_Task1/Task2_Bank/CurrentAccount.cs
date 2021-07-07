using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Bank
{
    class CurrentAccount : BankAccount, IAccountChange
    {
        public CurrentAccount(decimal presentBalance, string owner)
        : base(presentBalance, owner)
        {

        }

        public void PutMoney()
        {
            Console.WriteLine("Do you want to put some money to your account");
            Console.WriteLine("Y - yes / N - no");
            while (true)
            {
                string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y" || answer == "yes")
                {
                    Console.WriteLine("Okey! How much money, do you want to put?");
                    decimal inputting = Convert.ToDecimal(Console.ReadLine());
                    presentBalance += inputting;
                    break;
                }
                else if (answer == "N" || answer == "n" || answer == "no")
                {
                    Console.WriteLine("Okey, suppose you have enafe money in your account");
                    break;
                }
                else
                {
                    Console.WriteLine("Something strange, repeat inpute");
                    continue;
                }
            }
        }

        public void TakeOffMoney()
        {
            Console.WriteLine("Do you want to Tack off some money from your account");
            Console.WriteLine("Y - yes / N - no");

            while (true)
            {
                string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y" || answer == "yes")
                {
                    Console.WriteLine("Okey! How much money, do you want to tack?");
                    decimal inputting = Convert.ToDecimal(Console.ReadLine());
                    presentBalance -= inputting;
                    Console.WriteLine($"You current balance = {presentBalance}");
                    break;

                }
                else if (answer == "N" || answer == "n" || answer == "no")
                {
                    Console.WriteLine("Okey!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Something strange, repeat inpute");
                    continue;
                }
            }
        }
    }
}
