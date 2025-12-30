using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        #region Field

        #endregion

        #region Properties
        public Node<T> First { get; set; }
        public Node<T> Last { get; set; }

        #endregion

        #region Method

        public void AddFirst(T element)
        {
            Node<T> n = new Node<T>(element);

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

        }

        public void AddLast(T value)
        {
            Node<T> n = new Node<T>(value);

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

        }


        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = First;

            while (current != null)
            {
                yield return current.NodeValue; 
                current = current.Next;
            }
        }

        #endregion
    }
}
