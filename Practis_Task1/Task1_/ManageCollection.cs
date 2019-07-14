using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_
{
    class ManageCollection
    {
        StudentCollection instance = new StudentCollection();

        public void Execute()
        {
            Console.WriteLine($"All students at group now");
            ShowStudents();
            Console.Write("Count of sudent: ");
            CountOfStudent();
            Console.WriteLine("After adding student Ivan Petrov");
            AddStudent();
            Console.WriteLine(Environment.NewLine);
            ShowStudents();
            Console.Write("Number of student become: ");
            CountOfStudent();
            Console.WriteLine("List of student after removing Ivan Petrov");
            ShowStudents();
        }

        public void AddStudent()
        {
            Student added = new Student("Ivan", "Petrov", "3", "432", "4");
            instance.GetList().Add(added);

        }

        public void RemoveStudent()
        {
            instance.GetList().Remove(new Student("Ivan", "Petrov", "3", "432", "4"));
        }

        public void CountOfStudent()
        {
            int count = instance.GetList().Count();
            Console.WriteLine($"Number of students - {count}");
        }

        public void ShowStudents()
        {
            Console.WriteLine("List of students:");
            for (int i = 0; i < instance.GetList().Count; i++)
            {
                Console.WriteLine(instance.GetList()[i].ToString());
            }
        }
    }
}
