using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//khởi tạo thực thể 
namespace WebStudent.Entities
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string LastName {  get; set; }   
        public string FirstMidName { get; set; }   
        public DateTime EnrollmentDate { get; set; }
        public DateTime? CreatedSt { get; set; }
        public DateTime? UpdatedSt { get; set; }
    }
}
