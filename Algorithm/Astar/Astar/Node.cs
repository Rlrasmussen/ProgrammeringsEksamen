using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astar
{
    public class Node<T>
    {
        #region field
        private T data;
        private List<Edge<T>> edges = new List<Edge<T>>();
        private bool discovered = false;
        private Node<T> parent;
        //private float weight;

        //For A*
        private bool walkabel;

        #endregion

        #region properties
        internal List<Edge<T>> Edges { get => edges; private set => edges = value; }
        public T Data { get => data; private set => data = value; }
        public bool Discovered { get => discovered; set => discovered = value; }
        internal Node<T> Parent { get => parent; set => parent = value; }
        //public float Weight { get => weight; set => weight = value; }


        //For A*
        public bool Walkabel { get => walkabel; set => walkabel = value; }
        public float G { get; set; } = float.PositiveInfinity;
        public float H { get; set; }
        public float F => G + H;


        #endregion

        #region constructor

        public Node(T data, bool walkabel = true)
        {
            this.Data = data;
            //this.Weight = weight;
            this.Walkabel = walkabel;

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
