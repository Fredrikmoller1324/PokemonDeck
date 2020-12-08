using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PokemonDecks
{
    [DebuggerDisplay("{Name}")]
    class Deck
    {
        public int ID { get; set; }
        public string Name { get; set; }

    }
}
