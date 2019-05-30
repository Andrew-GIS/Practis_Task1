using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Bank
{
    class BankAccount
    {
        protected decimal presentBalance;
        public string owner;

        public decimal PresentBalance
        {
            get { return presentBalance; }
        }

        public string Owner
        {
            get { return owner; }
        }

        public BankAccount(decimal presentBalance, string owner)
        {
            this.presentBalance = presentBalance;
            this.owner = owner;
        }

        public decimal GetBalance()
        {
            Console.WriteLine($"Balance of your card = {presentBalance}");
            return presentBalance;
        }

        public void GetOwner()
        {
            string resalt = $"This card's owner is - {owner}";
            Console.WriteLine(resalt);
        }

        public decimal ClosureAccount()
        {
            presentBalance = 0;
            Console.WriteLine("Your bank account is closed");
            return presentBalance;
        }
    }
}

interface IPercentAccrual
{
    double PercentAccural();
    void IncreaseBalance();
}

interface IAccountChange
{
    void PutMoney();
    void TakeOffMoney();
}
