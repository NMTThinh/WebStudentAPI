using WebStudent.EF;
using WebStudent.Entities;
using WebStudent.Infrastructure;
using WebStudent.Interface.Repository;

namespace WebStudent.Repository
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public CourseRepository(CourseDbContext context) : base(context)
        {
        }
    }
}