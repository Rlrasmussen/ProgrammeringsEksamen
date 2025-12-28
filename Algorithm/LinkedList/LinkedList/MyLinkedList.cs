using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList : IEnumerable
    {
        #region Field

        #endregion

        #region Properties
        public Node First { get; set; }
        public Node Last { get; set; }

        #endregion

        #region Method

        public Node AddFirst(object value)
        {
            Node n = new Node(value);

            if (First == null)
            {
                First = Last = n;
            }
            else
            {
                First.Previous = n;
                n.Next = First;
                First = n;
            }

            return n;
        }

        public Node AddLast(object value)
        {
            Node n = new Node(value);

            if (First == null)
            {
                First = Last = n;
            }
            else
            {
                n.Previous = Last;
                Last.Next = n;
                Last = n;
            }

            return n;
        }


        public IEnumerator GetEnumerator()
        {
            Node current = First;

            while (current != null)
            {
                yield return current.NodeValue; 
                current = current.Next;
            }
        }

        #endregion
    }
}
