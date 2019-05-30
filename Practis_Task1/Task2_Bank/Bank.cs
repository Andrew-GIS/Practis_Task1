using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task2_Bank
{
    class Bank
    {
        public BankAccount[] CreateAccaunt()
        {
            Console.WriteLine("Hello! Welcome, to Bank program!");
            Console.WriteLine("How many users in the order?");//number of clients - max.Lengths of array
            int clientNumber = Convert.ToInt32(Console.ReadLine());

            BankAccount[] accaunt = new BankAccount[clientNumber];
            

            for (int i = 0; i<accaunt.Length; i++)
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Client {i+1}, welcome!");
                    Console.WriteLine("What type of account do you want to use or create?" +
                    "\n1.DepositAccount" +
                    "\n2.CardAccount" +
                    "\n3.CurrentAccount");

                
                    int answer = Convert.ToInt32(Console.ReadLine());

                    if (answer == 1)
                    {
                        DepositAccount depothAccaunt = new DepositAccount(1000, "Petro");
                        Console.WriteLine($"Cool, you use Deposit Account");
                       
                        while (true)
                        {
                            Console.WriteLine("What do you want to do with your account?" +
                           "\n1. Get Current Balance" +
                           "\n2. Get owner's info" +
                           "\n3. Get info about increasing your balance with percent" +
                           "\n4. Close your account" +
                           "\n5. End of work");
                            int depositAnswer = Convert.ToInt32(Console.ReadLine());
                            if (depositAnswer == 1)
                            {
                                depothAccaunt.GetBalance();
                                Console.WriteLine();
                                continue;
                            }
                            else if (depositAnswer == 2)
                            {
                                depothAccaunt.GetOwner();
                                Console.WriteLine();
                                continue;
                            }
                            else if (depositAnswer == 3)
                            {
                                depothAccaunt.IncreaseBalance();
                                Console.WriteLine();
                                continue;
                            }
                            else if (depositAnswer == 4)
                            {
                                depothAccaunt.ClosureAccount();
                                Console.WriteLine();
                                break;
                            }
                            else if (depositAnswer == 5)
                            {
                                Console.WriteLine("End of working, GoodBye");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Inpute correct value!");
                                continue;
                            }
                        }
                    }
                    
                    else if (answer == 2)
                    {
                        CardAccount cardAccaunt = new CardAccount(5000, "Ivan");
                        Console.WriteLine($"Cool, you use Card Account");

                        while (true)
                        {
                            Console.WriteLine("What do you want to do with your account?" +
                           "\n1. Get Current Balance" +
                           "\n2. Get owner's info" +
                           "\n3. Get info about increasing your balance with percent" +
                           "\n4. Close your account" +
                           "\n5. End of work");
                            int cardAnswer = Convert.ToInt32(Console.ReadLine());
                            if (cardAnswer == 1)
                            {
                                cardAccaunt.GetBalance();
                                Console.WriteLine();
                                continue;
                            }
                            else if (cardAnswer == 2)
                            {
                                cardAccaunt.GetOwner();
                                Console.WriteLine();
                                continue;
                            }
                            else if (cardAnswer == 3)
                            {
                                cardAccaunt.IncreaseBalance();
                                Console.WriteLine();
                                continue;
                            }
                            else if (cardAnswer == 4)
                            {
                                cardAccaunt.ClosureAccount();
                                Console.WriteLine();
                                break;
                            }
                            else if (cardAnswer == 5)
                            {
                                Console.WriteLine("End of working, GoodBye");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Inpute correct value!");
                                continue;
                            }
                        }
                    }
                    else if (answer == 3)
                    {
                        CardAccount currentAccaunt = new CardAccount(2000, "Stepan");
                        Console.WriteLine($"Cool, you use Card Account");

                        while (true)
                        {
                            Console.WriteLine("What do you want to do with your account?" +
                           "\n1. Get Current Balance" +
                           "\n2. Get owner's info" +
                           "\n3. Close your account" +
                           "\n4. End of work");
                            int currentAnswer = Convert.ToInt32(Console.ReadLine());
                            if (currentAnswer == 1)
                            {
                                currentAccaunt.GetBalance();
                                Console.WriteLine();
                                continue;
                            }
                            else if (currentAnswer == 2)
                            {
                                currentAccaunt.GetOwner();
                                Console.WriteLine();
                                continue;
                            }
                            else if (currentAnswer == 3)
                            {
                                currentAccaunt.ClosureAccount();
                                Console.WriteLine();
                                break;
                            }
                            else if (currentAnswer == 4)
                            {
                                Console.WriteLine("End of working, GoodBye");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Inpute correct value!");
                                continue;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Repeat your input");
                        continue;
                    }
                    Console.WriteLine();
                }
            }
            return accaunt;
        }
    }
}
