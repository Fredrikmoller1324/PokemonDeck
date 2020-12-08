using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class TrainerEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder
                .HasKey(t => t.ID);
        }
    }
}
