using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class Pokemon_Deck_JT
    {
        public int DeckID { get; set; }

        public virtual Deck Deck { get; set; }

        public int PokemonID { get; set; }
        public virtual Pokemon Pokemon { get; set; }

    }
}
