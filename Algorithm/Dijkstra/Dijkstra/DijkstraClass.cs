using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class DijkstraClass<T>
    {
        #region Field
        Dictionary<Node<T>, float> distances = new Dictionary<Node<T>, float>();
        HashSet<Node<T>> unvisitedNodes = new HashSet<Node<T>>();
        GraphClass<T> graph;


        #endregion

        #region Properties

        #endregion

        #region Constructor
        public DijkstraClass(GraphClass<T> graph)
        {
            this.graph = graph;
        }

        public Dictionary<Node<T>, float> Distances { get => distances; set => distances = value; }

        #endregion

        #region Method
        public List<Node<T>> Search(Node<T> start, Node<T> goal)
        {
            //initial setup
            foreach (Node<T> node in graph.Nodes)
            {
                //distance to every node is infinity
                Distances.Add(node, float.PositiveInfinity);
                //we havent visited anything yet
                unvisitedNodes.Add(node);
            }
            //distance to start is 0
            Distances[start] = 0;
            Node<T> current = null;
            while (unvisitedNodes.Count != 0)
            {
                //Select node with shortest distance to startnode
                float minValue = float.PositiveInfinity;
                foreach (var unvisited in unvisitedNodes)
                {
                    if (Distances[unvisited] < minValue)
                    {
                        minValue = Distances[unvisited];
                        current = unvisited;
                    }
                }
                //remove selected from unvisited
                unvisitedNodes.Remove(current);
                //look at edges
                foreach (var edge in current.Edges)
                {

                    if (edge.Weight + Distances[current] < Distances[edge.To])
                    {
                        //update path for backtracking
                        edge.To.Parent = current;
                        //update weight
                        Distances[edge.To] = edge.Weight + Distances[current];
                    }
                }
            }
            Node<T> currentGoal = goal;
            List<Node<T>> nodes = new List<Node<T>>();

            while (currentGoal.Parent != null)
            {
                nodes.Add(currentGoal.Parent);
                currentGoal = currentGoal.Parent;
            }
            return nodes;
        }

        #endregion
    }
}
