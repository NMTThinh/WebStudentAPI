using WebStudent.Entities;
using WebStudent.EF;
using WebStudent.Infrastructure;
using WebStudent.Interface.Repository;
namespace WebStudent.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    //tudentRepository kế thừa tất cả các phương thức CRUD đã được triển khai trong Repository<T>.
    {
        // hàm khởi tạo 
        public StudentRepository(StudentDbContext context) : base(context)
        // nhận vào một đối tượng StudentDBContext và truyền qua cho base
        {
        }
    }
}
