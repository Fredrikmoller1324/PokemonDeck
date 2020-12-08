using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace pokemon
{
    [DebuggerDisplay("{Name}")]
    class Trainer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string location { get; set; }
        public int Age { get; set; }

        //Navigation key
        public virtual ICollection<Pokemon> Pokemons { get; set; }

    }
}
