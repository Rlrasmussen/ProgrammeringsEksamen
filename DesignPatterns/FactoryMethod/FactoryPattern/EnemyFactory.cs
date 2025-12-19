using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class EnemyFactory : Factory
    {
        #region
        private static EnemyFactory? instance;

        public static EnemyFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EnemyFactory();
                }

                return instance;
            }
        }

        private EnemyFactory()
        {
        }
        #endregion

        public override GameObject Create(Enum enumType)
        {
            return new Enemy(enumType);
        }


    }
}
