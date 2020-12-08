using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace pokemon
{
    class TypeEntityTypeConfiguration
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.HasKey(t => t.ID);

        }
    }
}
