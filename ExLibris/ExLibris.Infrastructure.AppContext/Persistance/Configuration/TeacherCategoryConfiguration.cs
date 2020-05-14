using ExLibris.Contracts.Constants;
using ExLibris.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Infrastructure.AppContext.Persistance.Configuration
{
    public class TeacherCategoryConfiguration : IEntityTypeConfiguration<TeacherCategory>
    {
        public void Configure(EntityTypeBuilder<TeacherCategory> builder)
        {
            builder.HasKey(tc => tc.Id);

            builder.HasIndex(tc => new { tc.TeacherId, tc.CategoryId })
                .IsUnique();


            builder.Property(tc => tc.TeacherId)
                .IsRequired();

            builder.Property(tc => tc.CategoryId)
                .IsRequired();

            builder.HasOne(tc => tc.Teacher)
                .WithMany(t => t.TeacherCategories)
                .HasForeignKey(t => t.TeacherId);

            builder.HasOne(tc => tc.Category)
                .WithMany(c => c.TeacherCategories)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
