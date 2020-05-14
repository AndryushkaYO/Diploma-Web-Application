using ExLibris.Contracts.Constants;
using ExLibris.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Infrastructure.AppContext.Persistance.Configuration
{
    public class PremiumConfiguration : IEntityTypeConfiguration<Premium>
    {
        public void Configure(EntityTypeBuilder<Premium> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(PropertyConstraints.PremiumNameLength);
        }
    }
}
