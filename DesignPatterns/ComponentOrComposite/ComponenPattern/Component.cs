using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenPattern
{
    public abstract class Component
    {
        //Only the GameObject can set a refence to a component, but everone can read it
        //? know it can't be a null
        public GameObject? Go { get; internal set; }
        
        public abstract void Operation();
    }
}
