namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> linked = new MyLinkedList<int>();

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
