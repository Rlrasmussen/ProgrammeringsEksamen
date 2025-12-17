using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Shoot command which write "Phew phew"
    /// </summary>
    public class ShootCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Phew phew");
        }
    }

    /// <summary>
    /// Dodge command which write "Dogde"
    /// </summary>
    public class DogdeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Dogde");
        }
    }
}
