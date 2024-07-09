using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebStudent.Models
{
    public class CreateCourse
    {
            [Required]
            [JsonRequired]
            [StringLength(100)]
            public string? CourseName { get; set; }

            [Required]
            public int? Credits { get; set; }
            [StringLength(100)]
            public string? TimeToStar { get; set; }
        
    }
}
