namespace ComponenPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component leaf = new Leaf();
            Composite composite = new Composite();
            composite.AddChild(leaf);

            //Kalder Operation() på både leaf og composite på samme tid
            leaf.Operation();
            composite.Operation();


            GameObject go = new GameObject();
            //Adding the component
            go.AddComponent<HelloComponent>();

            //Getting the component
            Console.WriteLine("Getting the component");
            go.GetComponent<HelloComponent>().Operation();
        }
    }
}
