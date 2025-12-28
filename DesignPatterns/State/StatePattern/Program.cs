namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameObject go = new GameObject();

            go.ChangeState(new FirstState());
            go.Update();

            Console.WriteLine("Press any key to switch state...");
            Console.ReadKey();

            go.ChangeState(new SecondState());
            go.Update();

            Console.ReadKey();
        }
    }
}
