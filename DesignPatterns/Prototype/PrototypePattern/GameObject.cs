using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class GameObject : ICloneable
    {
        public int health;
        public int speed;
        private ConsoleColor color = ConsoleColor.White;

        public ConsoleColor Color { get => color; set => color = value; }

        public GameObject ShallowCopy()
        {
            return (GameObject)this.MemberwiseClone();
        }

        public GameObject DeepCopy()
        {
            //Copying the value types
            GameObject coby = (GameObject)this.MemberwiseClone();

            //Creating an new instance
            coby = new GameObject();

            return coby;
        }

        public object Clone()
        {
            //throw new NotImplementedException();

            //Console.WriteLine("This clone is a Shallow Copy");
            //return ShallowCopy();

            Console.WriteLine("This clone is a Deep Copy");
            return DeepCopy();
        }
    }
}
