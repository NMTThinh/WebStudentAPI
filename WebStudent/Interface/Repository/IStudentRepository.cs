using WebStudent.Entities;
using WebStudent.Infrastructure;

namespace WebStudent.Interface.Repository
{
    public interface IStudentRepository : IRepository<Student>// kế thừa giúp giảm thiểu sự lặp lại mã và tăng tính tái sử dụng của mã nguồn.
    {
    }
}
