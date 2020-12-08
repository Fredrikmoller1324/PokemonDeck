using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class PokemonAbilityEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Pokemon_Ability_JT> builder)
        {
            builder.HasKey(pa => new { pa.AbilityID, pa.PokemonID });

            builder.HasOne<Pokemon>()
                .WithMany()
                .HasForeignKey(p => p.PokemonID);

            builder.HasOne<Ability>()
                .WithMany()
                .HasForeignKey(p => p.AbilityID);
        }
    }
}
