using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        //The Node's value
        public object NodeValue { get; set; }
        //The next Node
        public Node Next { get; set; }
        //The previous Node
        public Node Previous { get; set; }

        public Node(object nodeValue)
        {
            this.NodeValue = nodeValue;
        }
    }
}
