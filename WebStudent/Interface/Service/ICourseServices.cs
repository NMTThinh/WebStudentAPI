using WebStudent.Entities;
using WebStudent.Models;
//  
namespace WebStudent.Interface.Service
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> GetAllAsync();
        Task<Course> GetCourseIdAsync(int courseid);
        Task CreateCourseAsync(CreateCourse request);
        Task UpdateCourse(int courseid, UpdateCourse request);
        Task DeleteCourseAsync(int courseid);
    }
}
