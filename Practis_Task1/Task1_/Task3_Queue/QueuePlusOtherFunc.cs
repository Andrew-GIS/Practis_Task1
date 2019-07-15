using Practis_Task1.Task1_.Task2_Dictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_.Task3_Queue
{
    class QueuePlusOtherFunc
    {
        Queue<string> schedule = new Queue<string>();
        Queue<string> taskList = new Queue<string>();
        StudentDictionary students = new StudentDictionary();

        public void Execute()
        {
            bool work = true;
            while (work==true)
            {
                bool check = true;
                while (check == true)
                {
                    Console.WriteLine($"Glad you at student management program!\nWhat did you want to do with your student?\n" +
                        $"Present students number - {students.GetDictionary().Count}\n" +
                        $"1.Show list of student .\n" +
                        $"2.Add new student.\n" +
                        $"3.Remove some student.\n" +
                        $"4.Remove all student.\n" +
                        $"5.Found some student by name\n"+
                        $"6.Operation with lesson Schedule\n" +
                        $"7.Manage student Task List\n"+
                        $"8.Exit"
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
                        if (choose <= 0 || choose > 8)
                        {
                            Console.WriteLine("Tre again, your answer must be from 1 to 8");
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
                            ScheduleOperation();
                            break;
                        case (7):
                            ManageTaskList();
                            break;
                        case (8):
                            work = false;
                            break;
                    }
                    Console.WriteLine("Do you want to continue? Press 'y' for yes, and 'n' for no");
                    string answerForContinue = Console.ReadLine();
                    if (answerForContinue == "y" || answerForContinue == "Y" || answerForContinue == "yes" || answerForContinue == "YES")
                        continue;
                    else
                        check = false;
                        work = false;
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

        public void ScheduleOperation()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Lesson Manager Program\n" +
                    $"1.Add lesson.\n" +
                    $"2.Remove first lesson\n" +
                    $"3.Show lesson schedule"
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
                    if (choose <= 0 || choose > 3)
                    {
                        Console.WriteLine("Tre again, your answer must be from 1 to 3");
                        continue;
                    }
                    else
                    {
                        switch (choose)
                        {
                            case (1):
                                Console.WriteLine("Input name of subject that you want to add to schedule:");
                                string subjectAdded = Console.ReadLine();
                                schedule.Enqueue(subjectAdded);
                                break;
                            case (2):
                                Console.WriteLine("Removing first lesson");
                                schedule.Dequeue();
                                break;
                            case (3):
                                Console.WriteLine("Full lessons schedule");
                                foreach (var lesson in schedule)
                                {
                                    Console.WriteLine(lesson);
                                }
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

        }

        public void ManageTaskList()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Lesson Manager Program\n" +
                    $"1.Add task.\n" +
                    $"2.Remove first task\n" +
                    $"3.Show task list\n"+
                    $"4.Oversee for a progress of tasks"
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
                    if (choose <= 0 || choose > 4)
                    {
                        Console.WriteLine("Tre again, your answer must be from 1 to 4");
                        continue;
                    }
                    else
                    {
                        switch (choose)
                        {
                            case (1):
                                Console.WriteLine("Add task to task list:");
                                string taskAdded = Console.ReadLine();
                                taskList.Enqueue(taskAdded);
                                break;
                            case (2):
                                Console.WriteLine("Removing first task");
                                taskList.Dequeue();
                                break;
                            case (3):
                                foreach (var task in taskList)
                                {
                                    Console.WriteLine(task);
                                }
                                break;
                            case (4):
                                Console.WriteLine("Task List:");
                                int counter = 1;
                                foreach (var task in taskList)
                                {
                                    Console.Write($"{counter}{task}");
                                    Thread.Sleep(1000);
                                    Console.Write("\tdone;");
                                    counter++;
                                    Console.WriteLine(Environment.NewLine);
                                }
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
        }
    }
}

