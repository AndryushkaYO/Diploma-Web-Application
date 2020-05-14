using ExLibris.Contracts.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ExLibris.Infrastructure.AppContext.Persistance
{
    public class AppDbContext : IdentityDbContext<Teacher>
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Premium> Premiums { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherCategory> TeacherCategories { get; set; }
        public DbSet<TeacherGrade> TeacherGrades { get; set; }
        public DbSet<TeacherPremium> TeacherPremiums { get; set; }
        public DbSet<TeacherReward> TeacherRewards { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
