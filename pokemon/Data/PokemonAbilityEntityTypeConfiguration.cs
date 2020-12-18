using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    public class PokemonAbilityEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Pokemon_Ability_JT> builder)
        {
            builder.HasKey(pa => new { pa.AbilityID, pa.PokemonID });

            builder.HasData(new Pokemon_Ability_JT { AbilityID = 1, PokemonID = 1 });

            builder.HasData(new Pokemon_Ability_JT { AbilityID = 2, PokemonID = 1 });

            builder.HasData(new Pokemon_Ability_JT { AbilityID = 3, PokemonID = 2 });

            builder.HasData(new Pokemon_Ability_JT { AbilityID = 4, PokemonID = 2 });

        }
    }
}
