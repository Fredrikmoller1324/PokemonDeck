using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace pokemon
{
    [DebuggerDisplay("{Name}")]
    public class Ability
    {
        public int ID { get; set; }

        public virtual ICollection<Pokemon_Ability_JT> Pokemon_Ability_JTs { get; set; }

        public string Name { get; set; }

        public int MinDmg { get; set; }

        public int MaxDmg { get; set; }

    }
}
