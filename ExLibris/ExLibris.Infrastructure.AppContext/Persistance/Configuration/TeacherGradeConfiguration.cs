using ExLibris.Contracts.Constants;
using ExLibris.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Infrastructure.AppContext.Persistance.Configuration
{
    public class TeacherGradeConfiguration : IEntityTypeConfiguration<TeacherGrade>
    {
        public void Configure(EntityTypeBuilder<TeacherGrade> builder)
        {
            builder.HasKey(tg => tg.Id);

            builder.HasIndex(tg => new { tg.TeacherId, tg.GradeId })
                .IsUnique();


            builder.Property(tg => tg.TeacherId)
                .IsRequired();

            builder.Property(tg => tg.GradeId)
                .IsRequired();

            builder.HasOne(tg => tg.Teacher)
                .WithMany(t => t.TeacherGrades)
                .HasForeignKey(t => t.TeacherId);

            builder.HasOne(tg => tg.Grade)
                .WithMany(g => g.TeacherGrades)
                .HasForeignKey(g => g.GradeId);
        }
    }
}
