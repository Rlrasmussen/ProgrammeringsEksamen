using System.Numerics;

namespace Astar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grid
            int heigth = 10;
            int width = 10;
            Node<Vector2>[,] grid = new Node<Vector2>[width, heigth];

            for (int y = 0; y < heigth; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    grid[x, y] = new Node<Vector2>(new Vector2(x, y), true);
                }
            }

            //Unwaklabel
            //grid[3, 0].Walkabel = false;
            //grid[3, 1].Walkabel = false;
            //grid[3, 3].Walkabel = false;
            //grid[3, 4].Walkabel = false;
            //grid[3, 5].Walkabel = false;

            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                grid[random.Next(0, 10), random.Next(0, 10)].Walkabel = false;
            }

            //Adding edges
            //Coodinate of the neighbors
            int[] dx = { 0, 1, 0, -1 };
            int[] dy = { -1, 0, 1, 0 };

            for (int y = 0; y < heigth; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Node<Vector2> node = grid[x, y];

                    if (!node.Walkabel)
                    {
                        continue;
                    }

                    //Bounds check
                    for (int i = 0; i < 4; i++)
                    {
                        //Neighbor coordinats
                        int nx = x + dx[i];
                        int ny = y + dy[i];

                        if (nx >= 0 && nx < width && ny >= 0 && ny < heigth && grid[nx, ny].Walkabel == true)
                        {
                            node.AddEdge(grid[nx, ny]);
                        }
                    }

                }
            }

            //Graph
            GraphClass<Vector2> myGraph = new GraphClass<Vector2>();

            //Adding the nodes to myGraph
            foreach (var node in grid)
            {
                myGraph.Nodes.Add(node);
            }

            //A*
            AStarClass<Vector2> myAStar = new AStarClass<Vector2>(myGraph);

            //Start and goal
            Node<Vector2> start = grid[0, 0];
            Node<Vector2> goal = grid[9, 9];

            //Path
            List<Node<Vector2>> aStarPath = myAStar.Search(start, goal);

            PrintGrid(grid, aStarPath, start, goal);

        }

        public static void PrintGrid(Node<Vector2>[,] grid, List<Node<Vector2>> path, Node<Vector2> start, Node<Vector2> goal)
        {
            Console.WriteLine(". = walkabel\n" +
                "# = wall\n" +
                "S = start\n" +
                "G = goal\n" +
                "* = path\n");

            int width = grid.GetLength(0);
            int height = grid.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Node<Vector2> node = grid[x, y];

                    if (node == start)
                        Console.Write("S ");
                    else if (node == goal)
                        Console.Write("G ");
                    else if (!node.Walkabel)
                        Console.Write("# ");
                    else if (path != null && path.Contains(node))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("* ");
                    }
                    else Console.Write(". ");

                    Console.ResetColor();
                }
                
                //Next line
                Console.WriteLine("");
            }

        }
    }
}
