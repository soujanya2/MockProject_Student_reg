using Microsoft.EntityFrameworkCore;

namespace MockProject1.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Students { get;set; }
        public DbSet<Course> Courses { get;set; }
        public DbSet<Hobby> Hobbys { get;set;}
    }
}
