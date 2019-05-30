using Practis_Task1.Task1;
using Practis_Task1.Task2_Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Task1 - train with interfaces. 
            //
            //House house = new House();
            //house.CheckGadgets();

            //
            //Task2 - Bank proggram.
            //
            //BankAccount account = new BankAccount(1000, "Petro");
            //account.GetOwner();
            //account.GetBalance();
            //account.ClosureAccount();
            DepositAccount deposit = new DepositAccount(1000, "Ivan");
            deposit.TakeOffMoney();

        }
    }
}








