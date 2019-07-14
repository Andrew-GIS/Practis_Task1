using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practis_Task1.Task3
{
    public class Node <T>
        //
        //Class of Node(element).
        //
    {
        public T Data { get; set; } //intended for data storage
        public Node<T> Next { get; set; } //for reference to next Node

        public Node(T data)
        {
            Data = data;
        }
    }
}
