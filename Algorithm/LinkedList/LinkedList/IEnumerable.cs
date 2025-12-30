using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public interface IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator();
    }
}
