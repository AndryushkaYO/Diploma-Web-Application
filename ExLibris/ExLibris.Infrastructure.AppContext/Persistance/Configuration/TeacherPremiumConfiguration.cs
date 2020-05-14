using ExLibris.Contracts.Constants;
using ExLibris.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Infrastructure.AppContext.Persistance.Configuration
{
    public class TeacherPremiumConfiguration : IEntityTypeConfiguration<TeacherPremium>
    {
        public void Configure(EntityTypeBuilder<TeacherPremium> builder)
        {
            builder.HasKey(tp => tp.Id);

            builder.HasIndex(tp => new { tp.TeacherId, tp.PremiumId })
                .IsUnique();


            builder.Property(tp => tp.TeacherId)
                .IsRequired();

            builder.Property(tp => tp.PremiumId)
                .IsRequired();

            builder.HasOne(tp => tp.Teacher)
                .WithMany(t => t.TeacherPremiums)
                .HasForeignKey(t => t.TeacherId);

            builder.HasOne(tp => tp.Premium)
                .WithMany(p => p.TeacherPremiums)
                .HasForeignKey(p => p.PremiumId);
        }
    }
}
