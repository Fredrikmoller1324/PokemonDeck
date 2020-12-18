using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    public class DeckEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Deck> builder)
        {
            builder
                .HasKey(d => d.ID);

            builder.HasData(new Deck {ID = 1, Name = "Standard" });
        }
    }
}
