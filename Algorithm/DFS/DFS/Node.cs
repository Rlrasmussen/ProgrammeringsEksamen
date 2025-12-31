using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    public class Node<T>
    {
        #region field
        private T data;
        private List<Edge<T>> edges = new List<Edge<T>>();
        private bool discovered = false;
        private Node<T> parent;
        private float weight;

        #endregion

        #region properties
        internal List<Edge<T>> Edges { get => edges; private set => edges = value; }
        public T Data { get => data; private set => data = value; }
        public bool Discovered { get => discovered; set => discovered = value; }
        internal Node<T> Parent { get => parent; set => parent = value; }
        public float Weight { get => weight; set => weight = value; }

        #endregion

        #region constructor

        public Node(T data, float weight = 1)
        {
            this.Data = data;
            this.Weight = weight;
        }
        #endregion

        #region method

        public void AddEdge(Node<T> other, float weight = 1)
        {
            //From this (node) to other (node)

            Edges.Add(new Edge<T>(this, other, weight));
        }

        #endregion
    }
}
