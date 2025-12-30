using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Edge<T>
    {
        #region Field
        private Node<T> from;
        private Node<T> to;
        private float weight;

        #endregion

        #region Properties

        #endregion

        #region Constructor
        public Edge(Node<T> from, Node<T> to, float weigth = 1)
        {
            this.from = from;
            this.to = to;
            this.weight = weigth;
        }

        #endregion
    }
}
