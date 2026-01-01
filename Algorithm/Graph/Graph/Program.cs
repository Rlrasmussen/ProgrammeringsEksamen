namespace Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph<string> myGraph = new Graph<string>();

            myGraph.AddNode("Kage");
            myGraph.AddNode("Mand");

            myGraph.AddEdge("Kage", "Mand");

        }
    }
}
