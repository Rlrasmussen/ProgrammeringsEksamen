using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class Edge<T>
    {
        #region Field
        private Node<T> from;
        private Node<T> to;
        private float weight;

        #endregion

        #region Properties
        public Node<T> From { get => from; set => from = value; }
        public Node<T> To { get => to; set => to = value; }
        public float Weight { get => weight; set => weight = value; }

        #endregion

        #region Constructor
        public Edge(Node<T> from, Node<T> to, float weigth = 1)
        {
            this.From = from;
            this.To = to;
            this.Weight = weigth;
        }


        #endregion
    }
}
