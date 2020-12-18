using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    public class PokemonEntityTypeConfiguration : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.HasKey(p => p.ID);

            builder.HasData(new Pokemon {ID = 1, Name = "Pikachu", HP = 50, Level = 22, TrainerID = 1, TypeID = 1});

            builder.HasData(new Pokemon {ID = 2, Name = "Blastoise", HP = 50, Level = 59, TrainerID = 2, TypeID = 14});
            
        }
    }
}
