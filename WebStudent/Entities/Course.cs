using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStudent.Entities
{
    [Table("Course")]
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public int Credits { get; set; }
            
        public string TimeToStar { get; set; }
        public DateTime? CreatedCl {  get; set; }
        public DateTime? UpdatedCl { get; set; }
    }
}
