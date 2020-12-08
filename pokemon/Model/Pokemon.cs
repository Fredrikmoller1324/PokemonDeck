using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace pokemon
{
    [DebuggerDisplay("{Name}")]
    class Pokemon
    {
        public int ID { get; set; }

        public virtual ICollection<Pokemon_Deck_JT> Pokemon_Deck_JTs { get; set; }

        public virtual ICollection<Pokemon_Ability_JT> Pokemon_Ability_JTs { get; set; }

        public string Name { get; set; }

        public int TypeID { get; set; }

        public virtual Type Type { get; set; }

        public int HP { get; set; }

        public int TrainerID { get; set; }

        public virtual Trainer Trainer { get; set; }

        public int Level { get; set; }

    }
}
