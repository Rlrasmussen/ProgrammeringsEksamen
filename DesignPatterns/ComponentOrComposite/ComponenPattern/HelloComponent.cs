using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenPattern
{
    public class HelloComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Hello world");
        }
    }
}
