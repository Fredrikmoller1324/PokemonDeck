using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PokemonDecks
{
    [DebuggerDisplay("{TypeName}")]

    class Type
    {
        public int ID { get; set; }

        public string TypeName { get; set; }

    }
}
