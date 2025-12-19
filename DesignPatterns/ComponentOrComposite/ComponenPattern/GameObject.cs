using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenPattern
{
    public class GameObject
    {
        //List of components
        private List<Component> components = new List<Component>();

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public Component GetComponent<T>() where T : Component
        {
            //Tjecking if the componet is in the list components
            foreach (var component in components)
            {
                if (component is T)
                {
                    return component;
                }
            }

            //If there isn't any Component of the type T, it will return null
            return null;
        }

        /// <summary>
        /// Adding a component to GameObject
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T AddComponent<T>() where T : Component, new() //Making sure new T() works
        {
            //The conponent has the same class as T
            T component = new T();

            //Adding the component to this GameObject
            component.Go = this;

            //Adding components to the list components
            //If a component isn't added to components GetComponent() doesn't work
            components.Add(component);

            //Returning the component
            return component;

        }

    }
}
