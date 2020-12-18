using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    public class PokemonDeckEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Pokemon_Deck_JT> builder)
        {
            builder.HasKey(pd => new { pd.DeckID, pd.PokemonID });

            builder.HasData(new Pokemon_Deck_JT { PokemonID = 1, DeckID = 1 });

            builder.HasData(new Pokemon_Deck_JT { PokemonID = 2, DeckID = 1 });

        }
    }
}
