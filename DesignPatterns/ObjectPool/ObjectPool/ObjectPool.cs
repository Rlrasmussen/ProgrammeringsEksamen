using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    public abstract class ObjectPool
    {
        private List<GameObject> active = new List<GameObject> ();
        private Stack<GameObject> inActive = new Stack<GameObject> ();

        public GameObject GetObject()
        {
            GameObject go;

            if (inActive.Count > 0)
            {
                go = inActive.Pop();
            }
            else
            {
                go = Create();
            }

            active.Add(go);
            return go;
        }

        public void ReleaseObject(GameObject obj)
        {
            inActive.Push(obj);

            active.Remove(obj);

            CleanUp(obj);
        }

        protected abstract GameObject Create();


        protected abstract void CleanUp(GameObject obj);
    }
}
