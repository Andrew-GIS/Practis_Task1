using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practis_Task1.Calculator;
using Practis_Task1.task2;
using Practis_Task1.Task2;

namespace Practis_Task1
{
    class Program
    {
        //
        //Link - https://docs.google.com/document/d/1eVjkYsZ4cj4n9m5bj7B9yKTxRhziUM3JV9fryvlSG5M/edit.
        //
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
            //CompanyEmployer em = new CompanyEmployer();
            //em.AlphabetDisplay();
            //em.DisplayMoreThan30Years();
            //em.GenderDisplay();
            //em.NameLastNameDisplay();
            //em.O_NameAge20();
            //em.NumberOfCompanyEmployer();
            //em.FirstEmployer();
            //em.LastEmployer();
            //em.FirstOf25();
            //em.OlegSearch();
            //
            //Task3.
            //
            EmployesComparing employes = new EmployesComparing();
            //employes.UnionWithDuplicate();
            //employes.UnionWithoutDuplicate();
            //employes.DisplayDuplicateEmployee();
            employes.AddingEmployee();
        }
    }
}









