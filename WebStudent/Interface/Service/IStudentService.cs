using WebStudent.Entities;
using WebStudent.Models;
//  Giúp quản lý dữ liệu Student.
namespace WebStudent.Interface.Service
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student> GetStudentIdAsync(int id);
        Task CreateStudentAsync(CreateStudent request);
        Task UpdateStudent(int id, UpdateStudent request);   
        Task DeleteStudentAsync(int id);
    }
}
