using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class PokemonDeckEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Pokemon_Deck_JT> builder)
        {
            builder.HasKey(pd => new { pd.DeckID, pd.PokemonID });

            builder.HasOne<Deck>()
                .WithMany()
                .HasForeignKey(pd => pd.DeckID);

            builder.HasOne<Pokemon>()
               .WithMany()
               .HasForeignKey(pd => pd.PokemonID);

        }
    }
}
