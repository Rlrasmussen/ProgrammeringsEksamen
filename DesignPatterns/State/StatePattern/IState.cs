using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface IState
    {
        public void Enter(GameObject parrent);
        public void Execute();
        public void Exit();
    }
}
