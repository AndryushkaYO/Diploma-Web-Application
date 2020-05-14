using ExLibris.Contracts.Constants;
using ExLibris.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Infrastructure.AppContext.Persistance.Configuration
{
    public class MarkConfiguration : IEntityTypeConfiguration<Mark>
    {
        public void Configure(EntityTypeBuilder<Mark> builder)
        {
            builder.HasKey(m => m.Id);

            builder.HasIndex(m => new { m.StudentId, m.LessonId })
                .IsUnique();

            builder.Property(m => m.StudentId)
                .IsRequired();

            builder.Property(m => m.LessonId)
                .IsRequired();

            builder.Property(m => m.StudentMark)
               .IsRequired();

            builder.HasOne(m => m.Student)
                .WithMany(m => m.Marks)
                .HasForeignKey(m => m.StudentId);

            builder.HasOne(m => m.Lesson)
                .WithMany(m => m.Marks)
                .HasForeignKey(m => m.LessonId);
        }
    }
}
