using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Astar
{
    public class AStarClass<T>
    {
        #region Field
        private GraphClass<Vector2> graph;


        #endregion

        #region Properties

        #endregion

        #region Constructor
        public AStarClass(GraphClass<Vector2> graph)
        {
            this.graph = graph;
        }

        #endregion

        #region Method

        public List<Node<Vector2>> Search(Node<Vector2> start, Node<Vector2> goal)
        {
            //OpenList => hasn't been visted jet
            List<Node<Vector2>> openList = new List<Node<Vector2>>();

            //Has been visted
            HashSet<Node<Vector2>> closedList = new HashSet<Node<Vector2>>();


            foreach (var node in graph.Nodes)
            {
                node.G = float.PositiveInfinity;
                node.Parent = null;
            }

            start.G = 0;
            start.H = Heuristic(start, goal);

            //Adding the start node to the openList
            openList.Add(start);

            while (openList.Count > 0)
            {
                //Node with the lowest F = G + H
                Node<Vector2> current = openList.OrderBy(n => n.F).First();

                //If goal is reached the path will be reaturned with TrackPath
                if (current == goal)
                {
                    return TrackPath(start, goal);
                }

                //Done with the current node and removing it from the openList and adding it to the closedList
                openList.Remove(current);
                closedList.Add(current);

                foreach (var edge in current.Edges)
                {
                    Node<Vector2> neighbor = edge.To;

                    //It the node is not walkabel or the neighbor is in the closedList then continue
                    if (!neighbor.Walkabel || closedList.Contains(neighbor))
                    {
                        continue;
                    }

                    //Calculate the cost to move to the next neighbor
                    float tentativeG = current.G + edge.Weight;

                    if (!openList.Contains(neighbor))
                    {
                        openList.Add(neighbor);
                    }
                    else if (tentativeG >= neighbor.G)
                    {
                        continue;
                    }

                    //Updating the neighbor
                    neighbor.Parent = current;
                    neighbor.G = tentativeG;
                    neighbor.H = Heuristic(neighbor, goal);
                }
            }


            //If goal is never found
            return null;
        }

        private float Heuristic(Node<Vector2> a, Node<Vector2> b)
        {
            return Math.Abs(a.Data.X - b.Data.X) + Math.Abs(a.Data.Y - b.Data.Y);
        }


        public List<Node<Vector2>> TrackPath<Vector2>(Node<Vector2> start, Node<Vector2> goal)
        {
            //List for the path
            List<Node<Vector2>> path = new List<Node<Vector2>>();

            if (goal == null)
            {
                return null;
            }

            Node<Vector2> current = goal;
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
