using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class CharacterDirector
    {
        private ICharacterBuilder builder;

        public CharacterDirector(ICharacterBuilder builder)
            { 
            this.builder = builder; 
        }

        public Character Construct()
        {
            return builder
                .SetName("Bob")
                .SetClass("Tank")
                .SetHealth(1)
                .Build();
        }
    }
}
