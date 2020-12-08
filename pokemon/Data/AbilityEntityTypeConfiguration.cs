using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class AbilityEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Ability> builder)
        {
            builder
                .HasKey(a => a.ID);
        }
    }
}
