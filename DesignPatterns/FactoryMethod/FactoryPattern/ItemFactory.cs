using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ItemFactory : Factory
    {
        #region
        private static ItemFactory? instance;

        public static ItemFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ItemFactory();
                }

                return instance;
            }
        }

        private ItemFactory()
        {
        }
        #endregion

        public override GameObject Create(Enum enumType)
        {
            return new Item(enumType);
        }
    }
}
