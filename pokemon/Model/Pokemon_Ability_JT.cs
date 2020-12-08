using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Pokemon_Ability_JT
    {
        public int PokemonID { get; set; }

        public virtual Pokemon Pokemon { get; set; }

        public int AbilityID { get; set; }

        public virtual Ability Ability { get; set; }

    }
}
