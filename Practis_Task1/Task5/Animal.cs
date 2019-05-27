using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task5
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract string Bite();
    }
}

public interface IPurr
{
    void Purr();
}
