using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class PokemonEntityTypeConfiguration : IEntityTypeConfiguration<Pokemon>
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.HasKey(p => p.ID);

            /*builder.HasOne<Trainer>()
                .WithMany()
                .HasForeignKey(p => p.TrainerID);

            builder.HasOne<Type>()
                .WithMany()
                .HasForeignKey(p => p.TypeID);
            */
            
        }
    }
}
