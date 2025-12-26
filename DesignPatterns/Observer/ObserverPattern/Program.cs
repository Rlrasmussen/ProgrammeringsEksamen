namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            
            ConcreteObserver observerA = new ConcreteObserver("A", subject);
            ConcreteObserver observerB = new ConcreteObserver("B", subject);

            //Attaching Observers to the subject
            subject.Attach(observerA);
            subject.Attach(observerB);

            Console.WriteLine("Changing state to 1");
            subject.State = 1;

            Console.WriteLine("Detaching observer A");
            subject.Detach(observerA);

            Console.WriteLine("Changing state to 2");
            subject.State = 2;
        }
    }
}
