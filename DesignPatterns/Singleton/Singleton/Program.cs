using Singleton;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Singleton");

        //Getting the Player instance to call on the method SayHi()
        Player.Instance.SayHi();
    }
}