using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace pokemon
{
    [DebuggerDisplay("{Name}")]
    public class Type
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public ICollection<Pokemon> Pokemons { get; set; }

    }
}
