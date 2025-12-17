using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ShootCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Phew phew");
        }
    }

    public class DogdeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Dogde");
        }
    }
}
