using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Bank
{
    class DepositAccount : BankAccount, IPercentAccrual
    {
        protected double depositeTime;

        public double DepositeTime {
            get {
                return depositeTime;
            }
            set {
                if (value <= 0)
                    throw new ArgumentException("Time can't be lowwer than 0");
                else
                    depositeTime = value;
            }
        }

        public DepositAccount(decimal presentBalance, string owner)
            : base(presentBalance, owner)
        {
            
        }

        public double PercentAccural()
        {
            
            double percent = 0;
            {
                Console.WriteLine("Choose your Deposit Time? " +
                    "\n1. 1 - 6 months = 2%;" +
                    "\n2. 6 - 9 months = 5%;" +
                    "\n3. More that 9 months = 7%");
                
                while (true)

                {
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        percent = 2;
                        Console.WriteLine($"Ok, your current perent rate = {percent}");
                        break;
                    }
                    else if (answer == 2)
                    {
                        percent = 5;
                        Console.WriteLine($"Ok, your current perent rate = {percent}");
                        break;
                    }
                    else if (answer == 3)
                    {
                        percent = 7;
                        Console.WriteLine($"Ok, your current perent rate = {percent}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Inpute correct answer");
                        continue;
                    }
                }
                return percent;
            }
        }

        public void IncreaseBalance()
        {
            double percent = PercentAccural();

            decimal percentTemp;

            percentTemp = (decimal)percent;

            decimal increase = presentBalance * (percentTemp / 100);

            presentBalance = increase + presentBalance;

            Console.WriteLine($"After deposit period your account will increase by {increase}, as result you account sum become {presentBalance} ");
        }
    }
}
