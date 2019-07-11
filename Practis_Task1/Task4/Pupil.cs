using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task4
{
    class Pupil
    {
        private string nameSurname;
        private int age;
        private int schoolNumber;
        private string shoolClass;

        public Pupil(string nameSurname, int age, int schoolNumber, string schoolClass)
        {
            if (string.IsNullOrWhiteSpace(nameSurname))
                throw new ArgumentException(nameof(nameSurname));
            if (string.IsNullOrWhiteSpace(schoolClass))
                throw new ArgumentException(nameof(schoolClass));
            if (age == 0)
            {
                throw new ArgumentException(nameof(age));
            }
            if (schoolNumber == 0)
            {
                throw new ArgumentException(nameof(schoolNumber));
            }
            this.nameSurname = nameSurname;
            this.age = age;
            this.schoolNumber = schoolNumber;
            this.shoolClass = schoolClass;
        }

        public string GetNameSurname()
        {
            return this.nameSurname;
        }

        public int GetAge()
        {
            return this.age;
        }

        public int GetSchoolNumber()
        {
            return this.schoolNumber;
        }

        public string GetSchoolClass()
        {
            return this.shoolClass;
        }
    }
}
