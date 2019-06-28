using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_
{
    class StudentCollection 
    {
        List<Student> students = new List<Student> {
        new Student("Ivan", "Petrov", "3", "432", "4"),
        new Student("Maria", "Sklar", "2", "324", "3"),
        new Student("Petro", "Johnson", "1", "512", "5"),
        new Student("Andrey", "Vosk", "6", "662", "6")};

        public void AddStudent ()
        {
            students.Add(new Student("Ivan", "Petrov", "3", "432", "4"));
        }

        public void RemoveStudent()
        {
            students.Remove(new Student("Ivan", "Petrov", "3", "432", "4"));
        }

        public void CountOfStudent()
        {
            int count = students.Count();
            Console.WriteLine($"Number of students - {count}"); 
        }

        public void ShowStudents()
        {
            Console.WriteLine("List of students:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].ToString());
            }
        }
    }
}
