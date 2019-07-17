using Practis_Task1.task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Practis_Task1.Employee;
using static Practis_Task1.task2.CompanyEmployer;

namespace Practis_Task1.Task2
{
    class EmployesComparing
    {
        CompanyEmployer[] fullEmployeeList = new CompanyEmployer[] {
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

        CompanyEmployer[] employersOnProbation = new CompanyEmployer[] {
            new CompanyEmployer{Name = "Andrey", LastName = "Fedorchenko", Age= 23, Gender = "M", Company = "Intetics", Status = "Probation" },
            new CompanyEmployer{Name = "Ivan", LastName = "Rilkov", Age= 33, Gender = "M", Company = "Intetics", Status = "Probation" },
            new CompanyEmployer{Name = "Kate", LastName = "Zvarich", Age= 53, Gender = "F", Company = "Epam", Status = "Probation" },
            new CompanyEmployer{Name = "Oleg", LastName = "Sherstuc", Age= 23, Gender = "M", Company = "Intetics", Status = "Probation" },
            new CompanyEmployer{Name = "Dmitro", LastName = "Koval", Age= 23, Gender = "M", Company = "Epam", Status = "Probation" },
        };

        public void UnionWithDuplicate()
        {
            //
            //hard way.
            //
            //var union = new CompanyEmployer[fullEmployeeList.Length + employersOnProbation.Length];
            //fullEmployeeList.CopyTo(union, 0);
            //employersOnProbation.CopyTo(union, fullEmployeeList.Length);
            //int counter = 1;
            //foreach (var item in union)
            //{
            //    Console.WriteLine($"{counter}.{item.ToString()}");
            //    counter++;
            //}
            //
            //true way.
            //
            int counter = 1;
            var union = fullEmployeeList.Union(employersOnProbation);
            foreach (var item in union)
            {
                Console.WriteLine($"{counter}.{item.ToString()}");
                counter++;
            }

        }

        public void UnionWithoutDuplicate()
        {
            var union = fullEmployeeList.Union(employersOnProbation);
            union.Distinct(new CompanyEmployeeComparer());
            int counter = 1;
            foreach (var item in union)
            {
                Console.WriteLine($"{counter}.{item.ToString()}");
                counter++;
            }
            //
            //hard way
            //
            //int duplicateCount = 0;
            //for (int i = 0; i < fullEmployeeList.Length; i++)
            //{
            //    for (int j = 0; j < employersOnProbation.Length; j++)
            //    {
            //        if (fullEmployeeList[i].LastName == employersOnProbation[j].LastName
            //            && fullEmployeeList[i].Name == employersOnProbation[j].Name &&
            //            fullEmployeeList[i].Age == employersOnProbation[j].Age &&
            //            fullEmployeeList[i].Company == employersOnProbation[j].Company &&
            //            fullEmployeeList[i].Gender == employersOnProbation[j].Gender &&
            //            fullEmployeeList[i].Status == employersOnProbation[j].Status)
            //        {
            //            duplicateCount++;
            //        }
            //    }
            //}
            //int index = 0;
            //Console.WriteLine($"Numbers of duplicate - {duplicateCount}");
            //var union = new CompanyEmployer[(fullEmployeeList.Length + employersOnProbation.Length) - duplicateCount + 1];
            ////fullEmployeeList.CopyTo(union, 0);
            ////employersOnProbation.CopyTo(union, fullEmployeeList.Length);

            //for (int i = 0; i < fullEmployeeList.Length; i++)
            //{
            //    for (int j = 0; j < employersOnProbation.Length; j++)
            //    {
            //        //for (int k = 0; k < union.Length; k++)
            //        //{
            //        if (fullEmployeeList[i].LastName != employersOnProbation[j].LastName 


            //                //&& fullEmployeeList[i].Name != employersOnProbation[j].Name &&
            //                //fullEmployeeList[i].Age != employersOnProbation[j].Age &&
            //                //fullEmployeeList[i].Company != employersOnProbation[j].Company &&
            //                //fullEmployeeList[i].Gender != employersOnProbation[j].Gender &&
            //                //fullEmployeeList[i].Status != employersOnProbation[j].Status
            //                )
            //            {
            //                union[index] = fullEmployeeList[i];
            //                Console.WriteLine($"{counter}.{union[index].ToString()}");
            //                index++;
            //                counter++;
            //            }
            //        //}
            //    }

            //}
            ////int counter = 1;
            //foreach (var item in union)
            //{
            //    Console.WriteLine($"{counter}.{item.ToString()}");
            //    counter++;
            //}
        }

        public void DisplayDuplicateEmployee()
        {
            Console.WriteLine("Employes that duplicated in both collections");
            var duplEmployee = fullEmployeeList.Intersect(employersOnProbation, new CompanyEmployeeComparer());
            int counter = 1;
            foreach (var item in duplEmployee)
            {
                Console.WriteLine($"{counter}.{item.ToString()}");
                counter++;
            }
        }

        public void AddingEmployee()
        {
            var listWithAdding = fullEmployeeList.ToList();
            listWithAdding.Add(new CompanyEmployer { Name = "Vasily", LastName = "Ivanov", Age = 26, Gender = "M", Company = "Intetics", Status = "Head" });
            int counter = 1;
            foreach (var item in listWithAdding)
            {
                Console.WriteLine($"{counter}.{item.ToString()}");
                counter++;
            }
        }
    }
}
