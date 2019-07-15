using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_.Task2_Dictionary
{
    class StudentFounding
    {
        StudentDictionary students = new StudentDictionary();

        public void Execute()
        {
            bool work = true;
            while (work==true)
            { 
            bool check = true;
                while (check == true)
                {
                    Console.WriteLine($"Glad you at student managment proggram!\nWhat did you want to do with your student?\n" +
                        $"Present students number - {students.GetDictionary().Count}\n" +
                        $"1.Show student list.\n" +
                        $"2.Add new student.\n" +
                        $"3.Remove some student.\n" +
                        $"4.Remove all student.\n" +
                        $"5.Found some student by name\n"+
                        $"6.Exit"
                        );
                    string read = Console.ReadLine();
                    int choose;
                    if (!Int32.TryParse(read, out choose))
                    {
                        Console.WriteLine("Not a number, try again");
                        continue;
                    }
                    else
                    {
                        if (choose <= 0 || choose > 6)
                        {
                            Console.WriteLine("Tre again, your answer must be from 1 to 5");
                            check = true;
                            continue;
                        }
                        else
                        {
                            check = false;
                        }
                    }
                    switch (choose)
                    {
                        case (1):
                            ShowStudents();
                            break;
                        case (2):
                            AddStudent();
                            break;
                        case (3):
                            RemoveStudent();
                            break;
                        case (4):
                            RemoveAll();
                            break;
                        case (5):
                            FoundStudent();
                            break;
                        case (6):
                            Console.WriteLine("GoodBy");
                            work = false;
                            break;
                    }
                    Console.WriteLine("Do you want to continue? Press 'y' for yes, and 'n' for no");
                    string answerForContinue = Console.ReadLine();
                    if (answerForContinue == "y" || answerForContinue == "Y" || answerForContinue == "yes" || answerForContinue == "YES")
                        continue;
                    else
                        break;
                }
            }
        }

        public void AddStudent()
        {
            while (true)
            {
                Console.WriteLine("Input info about new student.\nName:");
                string name = Console.ReadLine();
                Console.WriteLine("Lastname:");
                string lastname = Console.ReadLine();
                Console.WriteLine("Cours:");
                string cours = Console.ReadLine();
                Console.WriteLine("Group:");
                string group = Console.ReadLine();
                Console.WriteLine("Faculty:");
                string faculty = Console.ReadLine();
                var student = new Student(name, lastname, cours, group, faculty);
                this.students.GetDictionary().Add(student.FirstName + " " + student.LastName, student);
                Console.WriteLine("Do you go out from program of Adding Student? y- yes/n-no");
                string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y" || answer == "yes" || answer == "YES")
                {
                    continue;
                }
                else
                {
                    break;
                };
            }
        }

        public void RemoveStudent()
        {
            bool check = true;
            while (check == true)
            {
                while (true)
                {
                    Console.WriteLine("Inpute name and lastname of student whom you want to remove from list:\nName:");
                    string name = Console.ReadLine();
                
                    Console.WriteLine("Lastname:");
                    string lastname = Console.ReadLine();
                    if (students.GetDictionary().ContainsKey(name + " " + lastname))
                    {
                        students.GetDictionary().Remove(name + " " + lastname);
                        
                        Console.WriteLine("Do you go out from program of Adding Student? y- yes/n-no");
                        string answer = Console.ReadLine();
                        if (answer == "Y" || answer == "y" || answer == "yes" || answer == "YES")
                        {
                            check = false;
                            break;
                        }
                        else
                        {
                            check = true;
                        };
                    }
                    else
                    {
                        Console.WriteLine("List didn't have student with this name and lastname, try again");
                        continue;
                    }
                }
            }
        }

        public void RemoveAll()
        {
            students.GetDictionary().Clear();
        }

        public void FoundStudent()
        {
            Console.WriteLine("Founding of student, inpute name and last name of your student.\nName:");
            string name = Console.ReadLine();
            Console.WriteLine("Lastname:");
            string lastname = Console.ReadLine();
            if (students.GetDictionary().ContainsKey(name + " " + lastname))
            {
                var strudent = students.GetDictionary().TryGetValue(name + " " + lastname, out Student value);
                Console.WriteLine($"Student present in list - {strudent.ToString()}\n");
                Console.WriteLine(value.ToString());
            }
            else
            {
                Console.WriteLine("No student with this data");
            }
        }


        public void ShowStudents()
        {
            Console.WriteLine("Full list of your present students");
            int counter = 1;
            foreach (var item in this.students.GetDictionary())
            {
                Console.WriteLine($"{counter}.{item.Value.ToString()}");
                counter++;
            }
        }
    }
}
