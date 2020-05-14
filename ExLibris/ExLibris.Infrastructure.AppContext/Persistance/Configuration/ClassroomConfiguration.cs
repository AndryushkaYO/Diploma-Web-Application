using ExLibris.Contracts.Constants;
using ExLibris.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Infrastructure.AppContext.Persistance.Configuration
{
    public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasKey(cr => cr.Id);

            builder.Property(cr => cr.Name)
                .IsRequired()
                .HasMaxLength(PropertyConstraints.ClassroomNameLength);
        }
    }
}
