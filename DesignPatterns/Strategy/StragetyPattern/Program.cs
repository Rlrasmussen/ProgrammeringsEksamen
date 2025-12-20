namespace StragetyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strategy pattern for changing colors of the letters//


            //Starting strategy is red letters
            GameObject go = new(new RedComponent());

            //New strategy is blue letters
            go.colorComponent = new BlueComponent();
            go.SayHello();
        }
    }
}
