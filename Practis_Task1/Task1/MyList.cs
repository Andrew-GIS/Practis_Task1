using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task1
{
    class MyList<T> : IMyList<T>
    {
        public T[] array { get; set; }

        public MyList()
        {
            this.array = new T[0];
        }

        public int Count
        {
            get
            {
                int count = array.Length;
                return count;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.array[index];
            }
        }

        public void Add(T a)
        {
            T[] arr = new T[array.Length + 1];
            array.CopyTo(arr, 0);
            array = arr;
            array[array.Length - 1] = a;
        }

        public void Clear()
        {
            this.array = new T[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            Console.WriteLine("Detailed Inforamtion");
            Console.Write("Elements of your array: ");
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"Length of your array - {array.Length}");
            string finish = "This us the end, good lack.";
            return finish;
        }
    }

}

public interface IMyList<T>

{
    void Add(T a);

    T this[int index] { get; }

    int Count { get; }

    void Clear();

    bool Contains(T item);
}