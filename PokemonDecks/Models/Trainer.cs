using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PokemonDecks
{
    [DebuggerDisplay("{Name}")]
    class Trainer
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public int Age { get; set; }
    }
}
