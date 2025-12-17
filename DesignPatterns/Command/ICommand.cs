using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// Interface for Command
    /// </summary>
    public interface ICommand
    {
        public void Execute();
    }
}
