using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConcreteSubject : ISubject
    {
        #region Field
        //List of Observers
        private List<IObserver> listners = new List<IObserver>();

        //When state is chaning it will Notify()
        private int state;

        #endregion

        #region Properties
        public int State
        {
            get => state;
            set
            {
                state = value;
                Notify();
            }
        }

        #endregion

        public void Attach(IObserver observer)
        {
            listners.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            listners.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in listners)
            {
                observer.Update();
            }
        }
    }
}
