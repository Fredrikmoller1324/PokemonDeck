using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace pokemon
{
    [DebuggerDisplay("{Name}")]
    public class Deck
    {
        public int ID { get; set; }

        public virtual ICollection<Pokemon_Deck_JT> Pokemon_Deck_JTs { get; set; }

        public string Name { get; set; }

    }
}
