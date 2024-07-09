using AutoMapper;
using WebStudent.Entities;
using WebStudent.Models;
// sử dụng khi muốn hệ thống hoặc CSDL tự động tạo ra và cập nhật dữ liệu.
namespace WebStudent.MappingProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() { 
            CreateMap<CreateStudent, Student>()//ánh xạ CreateStudent sang Student nhưng bỏ qua ID,CreatedSt và UpdateSt
               .ForMember(dest => dest.Id, opt => opt.Ignore())
               .ForMember(dest => dest.CreatedSt, opt => opt.Ignore())
               .ForMember(dest => dest.UpdatedSt, opt => opt.Ignore());

            CreateMap<UpdateStudent, Student>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedSt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedSt, opt => opt.Ignore())
                .ConvertUsing(new NullValueIgnoringConverter<UpdateStudent, Student>());

            CreateMap<CreateCourse, Course>()
               .ForMember(dest => dest.CourseID, opt => opt.Ignore())
               .ForMember(dest => dest.CreatedCl, opt => opt.Ignore())
               .ForMember(dest => dest.UpdatedCl, opt => opt.Ignore());

            CreateMap<UpdateCourse, Course>()
                .ForMember(dest => dest.CourseID, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedCl, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedCl, opt => opt.Ignore())
                .ConvertUsing(new NullValueIgnoringConverter<UpdateCourse, Course>());
        }
    }
}