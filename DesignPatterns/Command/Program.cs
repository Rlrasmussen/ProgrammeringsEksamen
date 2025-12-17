using Command;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Command pattern");

        Dimmer dimser = new Dimmer();

        dimser.AddCommands();

        bool running = true;

        while (running)
        {
            string message = Console.ReadLine().ToLower();

            if (message == null || message=="")
            {
                running = false;
            }

            dimser.RunDutter(message);

        }
    }


    class Dimmer
    {
        #region Fields
        private Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();


        #endregion
        internal void RunDutter(string message)
        {
            if (commands.ContainsKey(message))
            {
                commands[message].Execute();
            }
            else
            {
                Console.WriteLine("You missed");
            }
        }

        internal void AddCommands()
        {
            commands.Add("s", new ShootCommand());
            commands.Add("d", new DogdeCommand());
        }
    }
}