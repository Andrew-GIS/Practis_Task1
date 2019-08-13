using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practis_Task1.Task3
{
    class Pupil : IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
            Console.WriteLine("Disposing");
            for (int i = 1; i <= 3; i++)
            {
                Thread.Sleep(500);
                Console.Beep();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            Dispose();
        }
    }
}
