using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    public class TypeEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.HasKey(t => t.ID);

            builder.HasData(new Type { ID = 1, Name = "Electric" });

            builder.HasData(new Type { ID = 2, Name = "Ground" });

            builder.HasData(new Type { ID = 3, Name = "Fire" });

            builder.HasData(new Type { ID = 4, Name = "Rock" });

            builder.HasData(new Type { ID = 5, Name = "Flying" });

            builder.HasData(new Type { ID = 6, Name = "Fighting" });

            builder.HasData(new Type { ID = 7, Name = "Bug" });

            builder.HasData(new Type { ID = 8, Name = "Ghost" });

            builder.HasData(new Type { ID = 9, Name = "Psychic" });

            builder.HasData(new Type { ID = 10, Name = "Dragon" });

            builder.HasData(new Type { ID = 11, Name = "Grass" });

            builder.HasData(new Type { ID = 12, Name = "Fairy" });

            builder.HasData(new Type { ID = 13, Name = "Dark" });

            builder.HasData(new Type { ID = 14, Name = "Water" });

            builder.HasData(new Type { ID = 15, Name = "Steel" });

            builder.HasData(new Type { ID = 16, Name = "Posion" });

            builder.HasData(new Type { ID = 17, Name = "Normal" });

            builder.HasData(new Type { ID = 18, Name = "Ice" });

        }
    }
}
