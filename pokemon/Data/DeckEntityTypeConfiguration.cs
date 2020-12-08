using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class DeckEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Deck> builder)
        {
            builder
                .HasKey(d => d.ID);
        }
    }
}
