namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CharacterBuilder builder = new CharacterBuilder();

            Character mortenChar = builder.SetName("Morten").SetClass("Munk").SetHealth(20).Build();
            Console.WriteLine(mortenChar.Name);


            CharacterDirector director = new CharacterDirector(new CharacterBuilder());

            Character kajChar = director.Construct();
            Console.WriteLine(kajChar.Name);
            

        }
    }
}
