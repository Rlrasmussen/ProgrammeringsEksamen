using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SecondState : IState
    {
        private GameObject parent;
        
        void IState.Enter(GameObject parent)
        {
            this.parent = parent;

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Entered SecondState (Red)");
        }
        public void Execute()
        {
            Console.WriteLine("SecondState running");
        }

        public void Exit()
        {
            Console.WriteLine("Exiting SecondState");

        }

    }
}
