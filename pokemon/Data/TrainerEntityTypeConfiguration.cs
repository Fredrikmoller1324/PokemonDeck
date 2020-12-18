using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    public class TrainerEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder
                .HasKey(t => t.ID);

            builder.HasData(new Trainer { ID = 1, Name = "Ash", Age = 15, location = "Pallet Town"});

            builder.HasData(new Trainer {ID = 2, Name = "Misty", Age = 17, location = "Anistar City" });

            builder.HasData(new Trainer { ID = 3, Name = "Brook", Age = 19, location = "Cerulean City" });

            builder.HasData(new Trainer { ID = 4, Name = "Tarot", Age = 13, location = "Cinnibar Island" });
   
        }
    }
}
