using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practis_Task1.Calculator;
using Practis_Task1.task2;

namespace Practis_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Execution().Execute();
            //new ExecutionFunk().ExecuteFunk();
            //
            //task1.
            ////
            //Employee employee = new Employee();
            //employee.DeferedExemple();
            //employee.UneferedExemle();
            //
            //task2.
            //
            CompanyEmployer em = new CompanyEmployer();
            //em.AlphabetDisplay();
            //em.DisplayMoreThan30Years();
            //em.GenderDisplay();
            //em.NameLastNameDisplay();
            //em.O_NameAge20();
            //em.NumberOfCompanyEmployer();
            em.FirstEmployer();
            em.LastEmployer();
            //em.FirstOf25();
            //em.OlegSearch();
        }
    }
}
            //
            // with "static"
            //
            //MyDelegate myDelegate = new MyDelegate(MyClass.Method);
            //myDelegate.Invoke();
            //myDelegate();

//
//without static
//
//MyClass instance = new MyClass();
//MyDelegate myDelegate = new MyDelegate(instance.Method);
//myDelegate.Invoke();
//myDelegate();

//
//c возвращяемым значением
//
//MyClass instance = new MyClass();
//MyDelegate myDelegate = new MyDelegate(instance.Method);
//string greeting = myDelegate.Invoke("Jeffry");
//Console.WriteLine(greeting);
//greeting = myDelegate("Grandy");
//Console.WriteLine(greeting);

//MyDelegate myDelegate = null;
//MyDelegate myDelegate1 = new MyDelegate(Method1);
//MyDelegate myDelegate2 = new MyDelegate(Method2);
//MyDelegate myDelegate3 = new MyDelegate(Method3);

//myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

//while (true)
//{ 
//Console.WriteLine("Inpute number from 1 to 7");
//string choise = Console.ReadLine();

//    switch (choise)
//    {
//        case "1":
//            {
//                myDelegate1.Invoke();
//                continue;
//            }
//        case "2":
//            {
//                myDelegate2.Invoke();
//                break;
//            }
//        case "3":
//            {
//                myDelegate3.Invoke();
//                break;
//            }
//        case "4":
//            {
//                MyDelegate myDelegate4 = myDelegate - myDelegate1;
//                myDelegate4.Invoke();
//                break;
//            }
//        case "5":
//            {
//                MyDelegate myDelegate5 = myDelegate - myDelegate2;
//                myDelegate5.Invoke();
//                break;
//            }
//        case "6":
//            {
//                MyDelegate myDelegate6 = myDelegate - myDelegate3;
//                myDelegate6.Invoke();
//                break;
//            }
//        case "7":
//            {
//                myDelegate.Invoke();
//                break;
//            }
//        default:
//            {
//                Console.WriteLine("Incorrect value");
//                break;
//            }
//    }

//public static void Method1()
//{
//    Console.WriteLine("M1");
//}

//public static void Method2()
//{
//    Console.WriteLine("M2");
//}

//public static void Method3()
//{
//    Console.WriteLine("M3");
//}



//static class MyClass
//{
//    public static void Method()
//    {
//        Console.WriteLine("String displayed massege with delegat");
//    }
//}

//class MyClass
//{
//    public void Method()
//    {
//        Console.WriteLine("String displayed massege with delegat");
//    }
//}

//class MyClass
//{
//    public string Method(string name)
//    {
//        return "Hello" + name;
//    }
//}




//public delegate void MyDelegate();









