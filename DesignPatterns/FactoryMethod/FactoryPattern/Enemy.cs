using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Enemy : GameObject
    {
        public Enemy(Enum enumType) : base(enumType)
        {
            Console.WriteLine("Enemy " + enumType);
        }
    }

    public enum EnemyTypes
    {
        Type1,
        Type2,
        Type3
    }
}
