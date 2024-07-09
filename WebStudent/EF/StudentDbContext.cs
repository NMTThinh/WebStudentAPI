using Microsoft.EntityFrameworkCore;
using WebStudent.Entities;
//Tương tác với CSDL thông qua EF
namespace WebStudent.EF
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }   
}
