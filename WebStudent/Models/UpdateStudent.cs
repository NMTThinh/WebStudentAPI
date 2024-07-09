using System.ComponentModel.DataAnnotations;

namespace WebStudent.Models
{
    public class UpdateStudent
    {
        [StringLength(100)]
        public string? LastName { get; set; }

        [StringLength(100)]
        public string? FirstMidName { get; set; }

        public DateTime? EnrollmentDate { get; set; }
    }
}
