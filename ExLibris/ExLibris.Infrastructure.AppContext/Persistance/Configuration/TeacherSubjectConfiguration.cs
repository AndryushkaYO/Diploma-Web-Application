using ExLibris.Contracts.Constants;
using ExLibris.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Infrastructure.AppContext.Persistance.Configuration
{
    public class TeacherSubjectsonfiguration : IEntityTypeConfiguration<TeacherSubject>
    {
        public void Configure(EntityTypeBuilder<TeacherSubject> builder)
        {
            builder.HasKey(ts => ts.Id);

            builder.HasIndex(ts => new { ts.TeacherId, ts.SubjectId })
                .IsUnique();


            builder.Property(ts => ts.TeacherId)
                .IsRequired();

            builder.Property(ts => ts.SubjectId)
                .IsRequired();

            builder.HasOne(ts => ts.Teacher)
                .WithMany(t => t.TeacherSubjects)
                .HasForeignKey(t => t.TeacherId);

            builder.HasOne(ts => ts.Subject)
                .WithMany(s => s.TeacerSubjects)
                .HasForeignKey(s => s.SubjectId);
        }
    }
}
