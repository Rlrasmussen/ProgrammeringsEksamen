namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameObject go = new GameObject();

            Console.WriteLine($"go color is {go.Color}");

            //Shallow copy
            GameObject goShallow = go.ShallowCopy();
            //Console.WriteLine($"goShallow color is {goShallow.Color}");

            //Changing color Shallow Copy//
            /*Console.WriteLine("goShallow has chenged color to Red");
            goShallow.Color = ConsoleColor.Red;
            Console.WriteLine($"go color is {go.Color}");
            Console.WriteLine($"goShallow color is {goShallow.Color}");

            Console.WriteLine("go has chenged color to Red");
            go.Color = ConsoleColor.Red;
            Console.WriteLine($"go color is {go.Color}");
            Console.WriteLine($"goShallow color is {goShallow.Color}"); */

            //Deep Copy
            GameObject goDeep = go.DeepCopy();
            Console.WriteLine($"goShallow color is {goDeep.Color} /n");


            //Changing color Deep Copy//
            //Console.WriteLine("goDeep has chenged color to Red");
            //goDeep.Color = ConsoleColor.Red;
            //Console.WriteLine($"go color is {go.Color}");
            //Console.WriteLine($"goDeep color is {goDeep.Color}");

            Console.WriteLine("go has chenged color to Red");
            go.Color = ConsoleColor.Red;
            Console.WriteLine($"go color is {go.Color}");
            Console.WriteLine($"goDeep color is {goDeep.Color}");
        }
    }
}
