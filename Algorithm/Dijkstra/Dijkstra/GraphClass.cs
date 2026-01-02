using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class GraphClass<T>
    {
        #region field
        private List<Node<T>> nodes = new List<Node<T>>();


        #endregion

        #region properties
        internal List<Node<T>> Nodes { get => nodes; private set => nodes = value; }

        #endregion

        #region constructor


        #endregion

        #region method
        public void AddNode(T value)
        {
            Nodes.Add(new Node<T>(value));
        }

        /// <summary>
        /// Can only go one way
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void AddDirectedEdge(T from, T to, float weight = 1)
        {
            Node<T> fromNode = Nodes.Find(x => EqualityComparer<T>.Default.Equals(x.Data, from));
            Node<T> toNode = Nodes.Find(x => EqualityComparer<T>.Default.Equals(x.Data, to));

            //Adding a edge between (start) fromNode to (end) toNode
            //if (!fromNode.Equals(default(T)) && !toNode.Equals(default(T)))
            if (fromNode != null && toNode != null)
            {
                fromNode.AddEdge(toNode, weight);
            }
            else
            {
                Console.WriteLine("Node doesn't exist");
            }
        }

        /// <summary>
        /// Can go both ways
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        public void AddEdge(T from, T to, float weight = 1)
        {
            Node<T> fromNode = Nodes.Find(x => x.Data.Equals(from));
            Node<T> toNode = Nodes.Find(x => x.Data.Equals(to));

            //Adding a edge between(start) fromNode to(end) toNode
            if (!fromNode.Equals(default(T)) && !toNode.Equals(default(T)))
            {
                fromNode.AddEdge(toNode, weight); //fromNode going to toNode
                toNode.AddEdge(fromNode, weight); //toNode going to fromNode

            }
            else
            {
                Console.WriteLine("Node doesn't exist");
            }
        }

        #endregion
    }
}
