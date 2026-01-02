using System.Xml.Linq;

namespace Dijkstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphClass<string> myGraph = new GraphClass<string>();

            myGraph.AddNode(Position.A.ToString());
            myGraph.AddNode(Position.B.ToString());
            myGraph.AddNode(Position.C.ToString());
            myGraph.AddNode(Position.D.ToString());
            myGraph.AddNode(Position.E.ToString());

            myGraph.AddDirectedEdge(Position.A.ToString(), Position.B.ToString(), 4);
            myGraph.AddDirectedEdge(Position.A.ToString(), Position.C.ToString(), 2);
            myGraph.AddDirectedEdge(Position.C.ToString(), Position.B.ToString(), 1);
            myGraph.AddDirectedEdge(Position.C.ToString(), Position.D.ToString(), 4);
            myGraph.AddDirectedEdge(Position.B.ToString(), Position.C.ToString(), 3);
            myGraph.AddDirectedEdge(Position.B.ToString(), Position.D.ToString(), 2);
            myGraph.AddDirectedEdge(Position.B.ToString(), Position.E.ToString(), 3);
            myGraph.AddDirectedEdge(Position.E.ToString(), Position.D.ToString(), 1);

            DijkstraClass<string> dijkstra = new DijkstraClass<string>(myGraph);

            Node<string> start = myGraph.Nodes.Find(x => x.Data == Position.A.ToString());
            Node<string> goal = myGraph.Nodes.Find(x => x.Data == Position.D.ToString());

            dijkstra.Search(start, goal);

            Console.WriteLine($"The path fra each node from the start node {start.Data}");
            foreach (var node in dijkstra.Distances)
            {
                Console.WriteLine($"[{node.Key.Data} : {node.Value}]");
            }

            Console.WriteLine($"The distance from the start node {start.Data} to the goal node {goal.Data} is {dijkstra.Distances[goal]}");
        }
    }

    public enum Position
    {
        A, B, C, D, E
    }
}
