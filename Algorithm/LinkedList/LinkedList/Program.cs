namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList linked = new MyLinkedList();

            linked.AddLast(3);
            linked.AddLast(8);
            linked.AddLast(7);
            linked.AddFirst(13);

            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }
        }
    }
}
