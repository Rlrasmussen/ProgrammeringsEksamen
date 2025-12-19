using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenPattern
{
    public class Leaf : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Leaf operation");
        }
    }
}
