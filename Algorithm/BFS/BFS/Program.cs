namespace BFS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GraphClass<string> myGraph = new GraphClass<string>();

            #region Adding nodes to myGraph
            myGraph.AddNode(Park.Entrance.ToString());
            myGraph.AddNode(Park.SlotMachines.ToString());
            myGraph.AddNode(Park.IcaBlaster.ToString());
            myGraph.AddNode(Park.FunHoude.ToString());
            myGraph.AddNode(Park.Hotdogs.ToString());
            myGraph.AddNode(Park.LogFlume.ToString());
            myGraph.AddNode(Park.BigDipper.ToString());
            myGraph.AddNode(Park.Rollercoaster.ToString());
            myGraph.AddNode(Park.RocketShips.ToString());
            myGraph.AddNode(Park.Cinema3D.ToString());
            myGraph.AddNode(Park.PirateShip.ToString());
            myGraph.AddNode(Park.GhostTrain.ToString());
            myGraph.AddNode(Park.Carousel.ToString());
            myGraph.AddNode(Park.FlyingChairs.ToString());

            #endregion

            #region Adding edges to myGraph
            myGraph.AddEdge(Park.Entrance.ToString(), Park.IcaBlaster.ToString());
            myGraph.AddEdge(Park.Entrance.ToString(), Park.FunHoude.ToString());
            myGraph.AddEdge(Park.Entrance.ToString(), Park.SlotMachines.ToString());

            myGraph.AddEdge(Park.IcaBlaster.ToString(), Park.SlotMachines.ToString());
            myGraph.AddEdge(Park.IcaBlaster.ToString(), Park.RocketShips.ToString());
            myGraph.AddEdge(Park.IcaBlaster.ToString(), Park.Cinema3D.ToString());
            myGraph.AddEdge(Park.IcaBlaster.ToString(), Park.FunHoude.ToString());

            myGraph.AddEdge(Park.Cinema3D.ToString(), Park.RocketShips.ToString());
            myGraph.AddEdge(Park.Cinema3D.ToString(), Park.FunHoude.ToString());
            myGraph.AddEdge(Park.Cinema3D.ToString(), Park.PirateShip.ToString());

            myGraph.AddEdge(Park.SlotMachines.ToString(), Park.Hotdogs.ToString());
            myGraph.AddEdge(Park.SlotMachines.ToString(), Park.RocketShips.ToString());

            myGraph.AddEdge(Park.GhostTrain.ToString(), Park.RocketShips.ToString());
            myGraph.AddEdge(Park.GhostTrain.ToString(), Park.BigDipper.ToString());
            myGraph.AddEdge(Park.GhostTrain.ToString(), Park.Carousel.ToString());
            myGraph.AddEdge(Park.GhostTrain.ToString(), Park.FlyingChairs.ToString());

            myGraph.AddEdge(Park.BigDipper.ToString(), Park.Rollercoaster.ToString());
            myGraph.AddEdge(Park.BigDipper.ToString(), Park.LogFlume.ToString());

            myGraph.AddEdge(Park.Hotdogs.ToString(), Park.LogFlume.ToString());
            myGraph.AddEdge(Park.Carousel.ToString(), Park.FlyingChairs.ToString());
            #endregion

            BreadthFirstSearch<string> BFS = new BreadthFirstSearch<string>(myGraph);

            Node<string> start = myGraph.Nodes.Find(x => x.Data == Park.Entrance.ToString());
            Node<string> goal = myGraph.Nodes.Find(x => x.Data == Park.GhostTrain.ToString());

            BFS.Search(start, goal);

            List<Node<string>> pathBFS = BFS.TrackPath(start, goal);

            foreach (var node in pathBFS)
            {
                Console.WriteLine(node.Data);
            }
        }

        public enum Park
        {
            Entrance,
            SlotMachines,
            IcaBlaster,
            FunHoude,
            Hotdogs,
            LogFlume,
            BigDipper,
            Rollercoaster,
            RocketShips,
            Cinema3D,
            PirateShip,
            GhostTrain,
            Carousel,
            FlyingChairs
        }
    }
}
