using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class FirstState : IState
    {
        private GameObject parent;
        
        
        void IState.Enter(GameObject parent)
        {
            this.parent = parent;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Entered FirstState (Black)");
                }
        public void Execute()
        {
            Console.WriteLine("FirstState running");
        }

        public void Exit()
        {
            Console.WriteLine("Exiting FirstState");
        }

    }
}
