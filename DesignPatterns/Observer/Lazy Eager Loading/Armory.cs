using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lazy_Eager_Loading
{
    public class Armory
    {
        private Lazy<List<Weapon>> weapons;

        public List<Weapon> Weapons 
        {
            get 
            {
                //Lazy loading happens here
                Console.WriteLine("Loading weapons");
                return weapons.Value;
            } 
        }

        public Armory() {
            weapons = new Lazy<List<Weapon>>(() => LoadWeapons());
        }

        public List<Weapon> LoadWeapons()
        {
            List<Weapon> tmpWeapons = new List<Weapon>()
            {
                new Weapon("AK 47", 30),
                new Weapon("Glock", 10),
                new Weapon("Granade", 1)
            };

            return tmpWeapons;
        }
    }
}
