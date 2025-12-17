using Command;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Command pattern");

        Handler thisHandler = new Handler();

        thisHandler.AddCommands();

        bool running = true;

        while (running)
        {
            string message = Console.ReadLine().ToLower();

            if (message == null || message == "")
            {
                running = false;
            }
            else
            {
                thisHandler.RunDutter(message);
            }
        }
    }

    /// <summary>
    /// Handler like a input handler
    /// </summary>
    class Handler
    {
        #region Fields
        private Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
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

        /// <summary>
        /// Adding the key and command into commands
        /// </summary>
        internal void AddCommands()
        {
            commands.Add("s", new ShootCommand());
            commands.Add("d", new DogdeCommand());
        }
    }
}