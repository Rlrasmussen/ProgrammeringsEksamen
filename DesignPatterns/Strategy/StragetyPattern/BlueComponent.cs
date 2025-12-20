using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StragetyPattern
{
    public class BlueComponent : Component
    {
        public override void Operation()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
}
