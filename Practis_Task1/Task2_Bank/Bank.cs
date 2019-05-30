using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Bank
{
    class Bank
    {
        public void CreateAccaunt()
        {
            Console.WriteLine("Hello! Welcome, to Bank program " +
                "\nWhat type of account you want to use or create?" +
                "1.DepositAccount" +
                "2.CartAccount" +
                "3.CurrentAccount");
            while (true)
            {
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 1)
                { }
                if (answer == 2)
                { }
                if (answer == 3)
                { }
            }

        }

    }
}
