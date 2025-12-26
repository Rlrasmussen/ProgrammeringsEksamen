using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    public class EnemyPool : ObjectPool
    {
        #region Singleton
        private static EnemyPool instance;

        private EnemyPool()
        {
        }

        public static EnemyPool Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EnemyPool();
                }
                return instance;
            }
        }


        #endregion

        private int number = 0;

        protected override void CleanUp(GameObject obj)
        {
            Enemy enemy = (Enemy)obj;

            enemy.Number = 0;

        }

        protected override GameObject Create()
        {
            Enemy newEnemy = new Enemy();
            newEnemy.Number = number;
            number++;
            return newEnemy;
        }
    }
}
