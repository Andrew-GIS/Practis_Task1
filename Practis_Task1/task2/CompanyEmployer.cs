using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.task2
{
    class CompanyEmployer
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Status { get; set; }

        public static IEnumerable<CompanyEmployer> GetCompanyEmployer()
        {
            return
                new List<CompanyEmployer>
                {
                    new CompanyEmployer{Name = "Andrey", LastName = "Fedorchenko", Age= 23, Gender = "M", Company = "Intetics", Status = "Probation" },
                    new CompanyEmployer{Name = "Vlad", LastName = "Radchenko", Age= 23, Gender = "M", Company = "Epam", Status = "Officially" },
                    new CompanyEmployer{Name = "Kiril", LastName = "Novikov", Age= 23, Gender = "M", Company = "Intetics", Status = "Officially" },
                    new CompanyEmployer{Name = "Olga", LastName = "Pavlenko", Age= 83, Gender = "F", Company = "Sigma", Status = "Officially" },
                    new CompanyEmployer{Name = "Ivan", LastName = "Rilkov", Age= 33, Gender = "M", Company = "Intetics", Status = "Probation" },
                    new CompanyEmployer{Name = "Kate", LastName = "Zvarich", Age= 53, Gender = "F", Company = "Epam", Status = "Probation" },
                    new CompanyEmployer{Name = "Ann", LastName = "Ivanova", Age= 40, Gender = "F", Company = "Intetics", Status = "Officially" },
                    new CompanyEmployer{Name = "Ann", LastName = "Simonchuk", Age= 23, Gender = "F", Company = "Sigma", Status = "Officially" },
                    new CompanyEmployer{Name = "Oleg", LastName = "Sherstuc", Age= 23, Gender = "M", Company = "Intetics", Status = "Probation" },
                    new CompanyEmployer{Name = "Dmitro", LastName = "Koval", Age= 23, Gender = "M", Company = "Epam", Status = "Probation" },
                };
        }

        public int GetHashCode(CompanyEmployer obj)
        {
            return obj.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {this.Name};\nLastName: {this.LastName};\nAge: {this.Age};\nGender: {this.Gender};\nCompany: {this.Company};\nWork Status: {this.Status};\n";
        }


        public void AlphabetDisplay()
        {
            var cEmployer = CompanyEmployer.GetCompanyEmployer().ToList();
            var alphabetList = cEmployer.OrderBy(employe => employe.Name);
            DisplayCompanyEmployer(alphabetList);
        }

        public void DisplayMoreThan30Years()
        {
            var cEmployer = CompanyEmployer.GetCompanyEmployer().ToList();
            var moreThan30 = cEmployer.Where(employe => employe.Age > 30);
            DisplayCompanyEmployer(moreThan30);
        }

        public void GenderDisplay()
        {
            var cEmployer = CompanyEmployer.GetCompanyEmployer().ToList();
            var menList = cEmployer.Where(employe => employe.Gender=="M");
            DisplayCompanyEmployer(menList);
            Console.WriteLine("----------------------------------------");
            var womenList = cEmployer.Where(employe => employe.Gender == "F");
            DisplayCompanyEmployer(womenList);
        }

        public void NameLastNameDisplay()
        {
            var cEmployer = CompanyEmployer.GetCompanyEmployer().ToList();
            var nameLastName = cEmployer.Select(employe => $"{employe.Name} {employe.LastName}");
            foreach (var item in nameLastName)
            {
                Console.WriteLine(item);
            }
        }

        public void O_NameAge20()
        {
            var cEmployer = CompanyEmployer.GetCompanyEmployer().ToList();
            var search = cEmployer.Where(employe => employe.Gender=="F" && employe.Name.StartsWith("O") && employe.Age>20);
            
            foreach (var item in search)
            {
                Console.WriteLine(item.LastName);
            }
        }

        public void NumberOfCompanyEmployer()
        {
            var cEmployer = CompanyEmployer.GetCompanyEmployer().ToList();
            var searchIntetics = cEmployer.GroupBy(employe => employe.Company == "Intetics").Select(employe=>employe.Count()).ToList();
            
            var employeeNumber = cEmployer.GroupBy(employee => employee.Company).Select(employee => employee.Count());
            foreach (var item in employeeNumber)
            {
                Console.WriteLine($"{item}");
            }
        }

        public void FirstEmployer()
        {
            var cEmploer = CompanyEmployer.GetCompanyEmployer().ToList();
            var searchfirst = cEmploer.ElementAt(1);
            Console.WriteLine(searchfirst);
        }

        public void LastEmployer()
        {
            var cEmploer = CompanyEmployer.GetCompanyEmployer().ToList();
            var searchlast = cEmploer.Last();
            Console.WriteLine(searchlast);
        }

        public void FirstOf25()
        {
            var cEmploer = CompanyEmployer.GetCompanyEmployer().ToList();
            var search = cEmploer.Where(emploey => emploey.Age > 25).Take(1);
            DisplayCompanyEmployer(search);
        }

        public void OlegSearch()
        {
            var cEmploer = CompanyEmployer.GetCompanyEmployer().ToList();
            var search = cEmploer.Where(emploey => emploey.Name == "Oleg").Select(pupil=>new Pupil(Name = pupil.Name,LastName = pupil.LastName, "12a"));
            foreach (var item in search)
            {
                Console.WriteLine(item);
            }
        }


        public void DisplayCompanyEmployer(IEnumerable<CompanyEmployer> employees)
        {
            int counter = 0;
            foreach (var em in employees)
            {
                Console.WriteLine($"{em.Name} {em.LastName} {em.Age} years old, gender - {em.Gender}, work in company {em.Company}");
                counter++;
            }
            Console.WriteLine($"Number of founding: {counter}");
        }

        public class CompanyEmployeeComparer : IEqualityComparer<CompanyEmployer>
        {
            public bool Equals(CompanyEmployer employee1, CompanyEmployer employee2)
            {
                if (employee1.Name.ToString() == employee2.Name.ToString() && employee1.LastName.ToString() == employee2.LastName.ToString())
                {
                    return true;
                }
                return false;
            }

            public int GetHashCode(CompanyEmployer employee)
            {
                return employee.Name.GetHashCode();
            }
        }
    }



    public class Pupil
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string School { get; set; }

        public Pupil(string firstName, string lastName, string school)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.School = school;
        }
        public override string ToString()
        {
            return $"{this.FirstName} { this.LastName} {this.School}";
        }

    }
}

