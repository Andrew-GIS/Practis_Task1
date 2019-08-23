using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3
{
    class TestSpace
    {
        //
        //IDisposable realization.
        //
        public void Check()
        {
            Pupil pupil = null;
            try
            {
                pupil = new Pupil();
            }
            finally
            {
                if (pupil != null)
                {
                    pupil.Dispose();
                }
            }
        }

        //
        //Realization of freeing memory with 2 ways(Destructor).
        //
        public void Check2()
        {
            Teacher teacher = null;
            try
            {
                teacher = new Teacher();
            }
            finally
            {
                if (teacher != null)
                {
                    teacher.Dispose();
                }
            }
        }
    }
}
