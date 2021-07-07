using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    public class Task3
    //
    //Program count debt settlement
    //
    {
        public static void DeptDisplay()
        {
            Console.WriteLine("Welcome to Bank programm");
            decimal [] dept = InputeOfDept();
            Console.WriteLine("For now - you dept is : {0}", dept[0]);
            decimal[] money_that_you_pay = MoneyThatYouPay();
            Console.WriteLine("Now you had paid {0}", money_that_you_pay[0]);
            decimal [] rest = DisplayOurRest(dept[0], money_that_you_pay[0]);
            Console.WriteLine("You must pay {0} to cover", rest[0]);
        }

        public static decimal [] InputeOfDept()
        {
            decimal[] array = new decimal[1];
            while (true)
            {
                Console.WriteLine("Inpute your dept");
                if (Decimal.TryParse(Console.ReadLine(), out decimal dept))
                {
                    array[0] = dept; 
                }
                else
                {
                    Console.WriteLine("Add correct value");
                    continue;
                }
                return array;
            }
        }

        public static decimal [] MoneyThatYouPay()
        {
            decimal[] array1 = new decimal[1];
            while (true)
            {
                Console.WriteLine("How many money did you pay");
                if (Decimal.TryParse(Console.ReadLine(), out decimal money_that_wepay))
                {
                    array1[0] = money_that_wepay;
                }
                else
                {
                    Console.WriteLine("Add correct value");
                    continue;
                }
                    return array1;
            }
            
        }

        public static decimal [] DisplayOurRest(decimal dept, decimal money_that_you_pay)
        {
            decimal [] array2 = new decimal [1];
            array2 [0] = dept - money_that_you_pay;
            return array2;
        }

    }
}
