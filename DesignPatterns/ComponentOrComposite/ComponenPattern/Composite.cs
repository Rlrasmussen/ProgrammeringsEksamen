using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenPattern
{
    public class Composite : Component
    {
        private List<Component> children = new List<Component>();

        public void AddChild(Component child)
        {
            children.Add(child);
        }

        public void RemoveChild(Component child)
        {
            children.Remove(child);
        }

        public override void Operation()
        {
            Console.WriteLine("Composite operation");
            foreach (Component child in children)
            {
                child.Operation();
            }
        }


    }
}
