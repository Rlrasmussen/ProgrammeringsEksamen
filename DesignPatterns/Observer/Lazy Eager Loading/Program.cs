namespace Lazy_Eager_Loading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var myAmory = new Armory();

            Console.WriteLine("Press key for loading weapons");
            Console.ReadKey();

            List<Weapon> myWeapons = myAmory.Weapons;

            foreach (var item in myWeapons)
            {
                Console.WriteLine($"Name: {item.Name} - Damage: {item.Damage}");
            }
        }
    }
}
