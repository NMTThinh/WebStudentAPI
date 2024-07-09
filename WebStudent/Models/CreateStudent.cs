using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebStudent.Models
{
    public class CreateStudent
    {
        [Required] //thuộc tính này phải được cung cấp (không thể null hoặc trống).
        [JsonRequired] //thuộc tính là bắt buộc khi đối tượng được tuần tự hóa/giải tuần tự hóa từ JSON.
        [StringLength(100)] //Giới hạn độ dài của chuỗi tối đa là 100 ký tự.
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstMidName { get; set; }

        [Required]
        [JsonRequired]
        public DateTime EnrollmentDate { get; set; }
    }
}
