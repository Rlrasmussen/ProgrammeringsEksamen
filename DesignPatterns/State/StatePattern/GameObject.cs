using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class GameObject
    {
        public IState currentState;
        public void ChangeState(IState newState)
        {
            if (currentState != null)
            {
                currentState.Exit();
            }

            currentState = newState;
            currentState.Enter(this);
        }

        public void Update()
        {
            currentState?.Execute();
        }
    }
}
