using Microsoft.EntityFrameworkCore;
using StudentCourseEFcore.Models;


namespace StudentCourseEFcore.DataContext
{
    public class StudentCourseDbContext : DbContext
    {
        public StudentCourseDbContext()
        {

        }
        public StudentCourseDbContext(DbContextOptions<StudentCourseDbContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = StudentCourseDb; Integrated Security = True; Connect Timeout = 30");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            modelBuilder.Seed();
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
    }
}
