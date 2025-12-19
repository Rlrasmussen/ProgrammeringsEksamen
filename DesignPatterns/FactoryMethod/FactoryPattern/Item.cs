using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Item : GameObject
    {
        public Item(Enum enumType) : base(enumType)
        {
            Console.WriteLine("Item " + enumType);

        }
    }

    public enum ItemType
    {
        Type1, Type2, Type3, Type4, Type5, Type6
    }
}
