namespace Console_projekt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            Console.WriteLine(train.Ticketprice(1));
            Console.WriteLine(train.Ticketprice(10));
            Console.WriteLine(train.Ticketprice(20));
            Console.WriteLine(train.Ticketprice(100));
        }
    }
}
