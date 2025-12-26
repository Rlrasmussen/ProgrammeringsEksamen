using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Eager_Loading
{
    public class Weapon
    {
        private string name;
        private int damage;

        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public string Name { get => name; }
        public int Damage { get => damage; }
    }
}
