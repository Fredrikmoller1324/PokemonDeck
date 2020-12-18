using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    public class AbilityEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Ability> builder)
        {
            builder
                .HasKey(a => a.ID);

            builder.HasData(new Ability { ID = 1, Name = "Lightning Bolt", MinDmg = 10, MaxDmg = 23 });

            builder.HasData(new Ability { ID = 2, Name = "Thunder", MinDmg = 15, MaxDmg = 37 });

            builder.HasData(new Ability { ID = 3, Name = "Bubble", MinDmg = 11, MaxDmg = 21 });

            builder.HasData(new Ability { ID = 4, Name = "Hydro Pump", MinDmg = 20, MaxDmg = 55 });

            builder.HasData(new Ability { ID = 5, Name = "Psy beam", MinDmg = 11, MaxDmg = 24 });

            builder.HasData(new Ability { ID = 6, Name = "Razor Leaf", MinDmg = 9, MaxDmg = 19 });

            builder.HasData(new Ability { ID = 7, Name = "Flamethrower", MinDmg = 16, MaxDmg = 57 });

            builder.HasData(new Ability { ID = 8, Name = "Eathquake", MinDmg = 17, MaxDmg = 52 });

            builder.HasData(new Ability { ID = 9, Name = "Bite", MinDmg = 15, MaxDmg = 26 });

        }
    }
}
