using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFS
{
    public class BreadthFirstSearch<T>
    {
        #region Field
        GraphClass<T> graph;
        Queue<Edge<T>> edges = new Queue<Edge<T>>();

        Node<T> start;
        Node<T> end;
        Node<T> goal;
        #endregion

        #region Properties

        #endregion

        #region Constructor
        public BreadthFirstSearch(GraphClass<T> graph)
        {
            this.graph = graph;

        }
        #endregion

        #region Method

        public Node<T> Search(Node<T> start, Node<T> goal)
        {
            edges.Enqueue(new Edge<T>(start, start));

            while (edges.Count > 0)
            {
                Edge<T> edge = edges.Dequeue();

                if (!edge.To.Discovered)
                {
                    edge.To.Discovered = true;
                    edge.To.Parent = edge.From;
                }

                if (edge.To == goal)
                {
                    //Have found the goal
                    return edge.To;
                }

                foreach (Edge<T> e in edge.To.Edges)
                {
                    if (!e.To.Discovered)
                    {
                        edges.Enqueue(e);

                    }
                }
            }

            //Haven't the goal
            return null;
        }


        public List<Node<T>> TrackPath<T>(Node<T> start, Node<T> goal)
        {
            //List for the path
            List<Node<T>> path = new List<Node<T>>();

            if (goal == null)
            {
                return null;
            }

            Node<T> current = goal;
            while (current != null && current != start) //Finding the differen nodes for the path
            {
                path.Add(current); //Adding to path
                current = current.Parent; //Adding parent
            }

            //Adding start node
            path.Add(start);

            //Was adding the path in reverse so for getting the right path it needs to get reversed
            path.Reverse();

            //Returning the path
            return path;
        }

        #endregion
    }
}
