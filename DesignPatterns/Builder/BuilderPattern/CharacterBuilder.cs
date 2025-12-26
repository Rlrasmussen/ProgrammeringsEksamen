using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CharacterBuilder : ICharacterBuilder
    {
        private Character character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            character.Name = name;
            return this;
        }

        public ICharacterBuilder SetClass(string characterClass)
        {
            character.Class = characterClass;
            return this;
        }

        public ICharacterBuilder SetHealth(int health)
        {
            character.Health = health;
            return this;
        }

        public Character Build()
        {
            return character;
        }
    }
}
