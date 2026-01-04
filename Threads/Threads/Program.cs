namespace Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates a thread
            Thread myThread = new Thread(ThreadWork);
            myThread.IsBackground = true;

            //Starts the thread
            myThread.Start();

            //Starts the thread with parameters
            Thread parameterThread = new Thread(ThreadWithParameters);
            parameterThread.IsBackground = true;
            string message = "This is the parameter";
            parameterThread.Start(message);


            //Thread with Sleep()
            Thread sleepThread = new Thread(ThreadSleep);
            sleepThread.IsBackground = true;
            sleepThread.Start();

            //Thread with Sleep() loop 4
            Thread sleepThread4 = new Thread(ThreadSleep4);
            sleepThread4.IsBackground = true;
            sleepThread4.Start();


            //Starts the thread with parameters by using a lambda expression
            Thread parameterLambdaThread = new Thread(() => ThreadWithParameters(message + " by using lambda"));
            parameterLambdaThread.IsBackground = true;
            parameterLambdaThread.Start();

            Console.WriteLine("This is the main thread");
        }

        private static void ThreadWork()
        {
            Console.WriteLine("Runing in a thread");
        }

        private static void ThreadWithParameters(object o)
        {
            string message = o.ToString();

            Console.WriteLine($"The thread received the following message: {message}");
        }

        private static void ThreadSleep()
        {
            Console.WriteLine("Thread with Sleep()");
            Thread.Sleep(1000);
        }

        private static void ThreadSleep4()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Thread with Sleep() time 4");
                Thread.Sleep(1000);
            }
        }
    }
}
