using ExLibris.Contracts.Constants;
using ExLibris.Contracts.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Infrastructure.AppContext.Persistance.Configuration
{
    public class TeacherRewardConfiguration : IEntityTypeConfiguration<TeacherReward>
    {
        public void Configure(EntityTypeBuilder<TeacherReward> builder)
        {
            builder.HasKey(tr => tr.Id);

            builder.HasIndex(tr => new { tr.TeacherId, tr.RewardId })
                .IsUnique();


            builder.Property(tr => tr.TeacherId)
                .IsRequired();

            builder.Property(tr => tr.RewardId)
                .IsRequired();

            builder.HasOne(tr => tr.Teacher)
                .WithMany(t => t.TeacherRewards)
                .HasForeignKey(t => t.TeacherId);

            builder.HasOne(tr => tr.Reward)
                .WithMany(r => r.TeacherRewards)
                .HasForeignKey(r => r.RewardId);
        }
    }
}
