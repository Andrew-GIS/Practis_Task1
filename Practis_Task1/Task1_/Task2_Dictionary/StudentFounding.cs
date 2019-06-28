using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_.Task2_Dictionary
{
    class StudentFounding
    {
        Dictionary<string, Student> student = new Dictionary<string, Student>()
        { 
        { "Ivan Petrov", new Student("Ivan", "Petrov", "3", "432", "4")},
        { "Maria Sklar", new Student("Maria", "Sklar", "2", "324", "3")},
        { "Petro Johnson", new Student("Petro", "Johnson", "1", "512", "5")},
        { "Andrey Vosk", new Student("Andrey", "Vosk", "6", "662", "6")},
        };

        public void Founding()
        {
            string 
            for (int i = 0; i < student.Count; i++)
            {
                Console.WriteLine(student[i,i]);
            }
        }
    }
}
