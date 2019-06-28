using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_
{
    class ManageCollection
    {
        public void Execute()
        {
            StudentCollection instance = new StudentCollection();
            var list = instance.GetList();
            list.Add(new Student("Ivan", "Petrov", "3", "432", "4"));
            list.RemoveAt(0);
            Console.WriteLine("List of students:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ToString());
            }
        }
        //public void AddStudent()
        //{
        //    list.Add();
        //}

        //public void RemoveStudent()
        //{
        //    students.Remove(new Student("Ivan", "Petrov", "3", "432", "4"));
        //}

        //public void CountOfStudent()
        //{
        //    int count = students.Count();
        //    Console.WriteLine($"Number of students - {count}");
        //}

        //public void ShowStudents()
        //{
        //    Console.WriteLine("List of students:");
        //    for (int i = 0; i < students.Count; i++)
        //    {
        //        Console.WriteLine(students[i].ToString());
        //    }
        //}
    }
}
