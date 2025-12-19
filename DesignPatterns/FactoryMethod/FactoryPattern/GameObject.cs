using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class GameObject
    {
        private Enum type;

        public GameObject(Enum enumType)
        {
            this.type = enumType;

        }
    }
}
