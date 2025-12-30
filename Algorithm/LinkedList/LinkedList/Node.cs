using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        //The Node's value
        public T NodeValue { get; set; }
        //The next Node
        public Node<T> Next { get; set; }
        //The previous Node
        public Node<T> Previous { get; set; }

        public Node(T nodeValue)
        {
            this.NodeValue = nodeValue;
        }
    }
}
