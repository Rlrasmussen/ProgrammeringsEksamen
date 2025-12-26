namespace ObjectPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(EnemyPool.Instance.GetObject().Number);
            Console.WriteLine(EnemyPool.Instance.GetObject().Number);
            Console.WriteLine(EnemyPool.Instance.GetObject().Number);
            Console.WriteLine(EnemyPool.Instance.GetObject().Number);


        }
    }
}
