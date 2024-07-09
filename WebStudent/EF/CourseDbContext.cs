using Microsoft.EntityFrameworkCore;
using WebStudent.Entities;
namespace WebStudent.EF
{
    public class CourseDbContext : DbContext
    {
        public CourseDbContext(DbContextOptions<CourseDbContext> options): base(options) 
        {
        }
        public DbSet<Course> Courses { get; set; }
    }
}
