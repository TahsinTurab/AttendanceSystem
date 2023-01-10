using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttendenceSystem
{
    public class DataBaseContext : DbContext
    {
        private string _connectionString;
        private string _assemblyName;
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<AttendenceSheet> AttenantsSheets { get; set; }

        public DataBaseContext()
        {
            _connectionString = "Server = DESKTOP-VFPLJ6B\\SQLEXPRESS; Database = AttendenceSystem; User Id = Assignment3; Password = 12345;";
            _assemblyName = Assembly.GetExecutingAssembly().FullName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString,
                    m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ClassSchedule>().ToTable("ClassSchedules");

            builder.Entity<CourseStudent>().ToTable("CourseStudents");
            builder.Entity<CourseStudent>().HasKey(cs => new { cs.CourseId, cs.StudentId });

            builder.Entity<CourseTeacher>().ToTable("CourseTeachers");
            builder.Entity<CourseTeacher>().HasKey(cs => new { cs.CourseId, cs.TeacherId });

            builder.Entity<Course>()
               .HasMany(p => p.ClassSchedules)
               .WithOne(i => i.Course); 

           builder.Entity<CourseStudent>()
                .HasOne(pc => pc.Course)
                .WithMany(p => p.Students)
                .HasForeignKey(pc => pc.CourseId);

            builder.Entity<CourseStudent>()
                .HasOne(pc => pc.Student)
                .WithMany(c => c.Courses)
                .HasForeignKey(pc => pc.StudentId);

           builder.Entity<CourseTeacher>()
                .HasOne(pc => pc.Course)
                .WithMany(p => p.Teachers)
                .HasForeignKey(pc => pc.CourseId);

            builder.Entity<CourseTeacher>()
                .HasOne(pc => pc.Teacher)
                .WithMany(c => c.Courses)
                .HasForeignKey(pc => pc.TeacherId);

            base.OnModelCreating(builder);
        }
    }
}
