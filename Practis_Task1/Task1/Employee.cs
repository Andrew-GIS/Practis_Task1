using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }


        public static IEnumerable<Employee> GetEmployee()
        {
            return
                new List<Employee>
                {
                    new Employee{FirstName = "Andrey", LastName = "Fedorchenko", Gender = "M", Age = 23 },
                    new Employee{FirstName = "Vlad", LastName = "Radchenko", Gender = "M", Age = 25 },
                    new Employee{FirstName = "Kiril", LastName = "Novikov", Gender = "M", Age = 30 },
                    new Employee{FirstName = "Ann", LastName = "Kolomeitc", Gender = "F", Age = 30 },
                };
        }

        public void DeferedExemple()
        {
            var employee = Employee.GetEmployee().ToList();
            var maleEmployee = employee.Where(e => e.Gender == "M");
            DisplayEmployee(maleEmployee);
            employee.Add(new Employee { FirstName = "Ivan", LastName = "Rilkov", Gender = "M", Age = 25 });
            DisplayEmployee(maleEmployee);
        }

        public void UneferedExemle()
        {
            var employee = Employee.GetEmployee().ToList();
            var maleEmployee = employee.Where(e => e.Gender == "M").ToList();
            DisplayEmployee(maleEmployee);
            employee.Add(new Employee { FirstName = "Ivan", LastName = "Rilkov", Gender = "M", Age = 25 });
            DisplayEmployee(maleEmployee);
        }

        public void DisplayEmployee(IEnumerable<Employee> employees)
        {
            foreach (var employer in employees)
            {
                Console.WriteLine("{0} {1} with {2} years old - {3}", employer.FirstName, employer.LastName, employer.Age, employer.Gender);
            }
            Console.WriteLine("-------------------------");
        }
    }
}
