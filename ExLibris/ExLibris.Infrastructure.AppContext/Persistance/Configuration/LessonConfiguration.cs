using ExLibris.Contracts.Constants;
using ExLibris.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Infrastructure.AppContext.Persistance.Configuration
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(l => l.Id);

            builder.HasIndex(l => new { l.TeacherSubjectId, l.MaterialId, l.ClassroomId })
                .IsUnique();

            builder.Property(l => l.TeacherSubjectId)
                .IsRequired();

            //builder.Property(l => l.MaterialId)
            //    .IsRequired();

            builder.Property(l => l.ClassroomId)
               .IsRequired();

            builder.HasOne(l => l.TeacherSubject)
                .WithMany(l => l.Lessons)
                .HasForeignKey(l => l.TeacherSubjectId);

            builder.HasOne(l => l.Classroom)
                .WithMany(l => l.Lessons)
                .HasForeignKey(l => l.ClassroomId);

            builder.HasOne(l => l.Material)
                .WithMany(l => l.Lessons)
                .HasForeignKey(l => l.MaterialId);
        }
    }
}
