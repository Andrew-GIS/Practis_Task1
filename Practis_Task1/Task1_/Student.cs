using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1_
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string cours;
        private string groupe;
        private string faculty;

        public string FirstName
        { get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Cours
        {
            get
            {
                return cours;
            }
            set
            {
                cours = value;
            }
        }
        
        public string Groupe
        {
            get
            {
                return groupe;
            }
            set
            {
                groupe = value;
            }
        }
        
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }

        public Student(string firstname, string lastName, string cours, string groupe, string faculty)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
            this.Cours = cours;
            this.Groupe = groupe;
            this.Faculty = faculty;
        }

        public override string ToString()
        {
            return this.FirstName + ", " + this.LastName + ", " + Cours + ", " + Groupe + ", " + Faculty + ".";
        }

    }
}
