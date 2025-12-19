namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            EnemyFactory.Instance.Create(EnemyTypes.Type1);

            ItemFactory.Instance.Create(ItemType.Type2);
        }
    }
}
