using System.ComponentModel.DataAnnotations;

namespace WebStudent.Models
{
    public class UpdateCourse
    {
        [StringLength(100)]
        public string? CourseName { get; set; }
        public int? Credits { get; set; }
        [StringLength(100)]
        public string? TimeToStar { get; set; }
   
    }
}
