using AutoMapper;
using Microsoft.AspNetCore.Cors.Infrastructure;
using WebStudent.Entities;
using WebStudent.Interface.Repository;
using WebStudent.Interface.Service;
using WebStudent.Models;

namespace WebStudent.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository courseRepository;
        private IMapper mapper;
        private readonly ILogger<CourseService> logger;
        public CourseService(ICourseRepository courseRepository, IMapper mapper, ILogger<CourseService> logger)
        {
            this.courseRepository = courseRepository;
            this.mapper = mapper;
            this.logger = logger;
        }
        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            var res = await courseRepository.GetAllAsync();
            if (res == null)
            {
                logger.LogInformation($" No Course found");
            }
            return res;
        }
        public async Task<Course> GetCourseIdAsync(int id)
        {
            var res = await courseRepository.GetByIDAsync(id);
            if (res == null)
            {
                logger.LogInformation($"No Course with Id {id} found.");
            }
            return res;
        }
        public async Task CreateCourseAsync(CreateCourse request)
        {
            try
            {
                // DATA
                var dataAdd = mapper.Map<Course>(request);
                dataAdd.CreatedCl = DateTime.Now;
                // CREATE & SAVE
                await courseRepository.CreateAsync(dataAdd);
                await courseRepository.SaveChangeAsync();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while creating the todo item.");
            }
        }
        public async Task UpdateCourse(int id, UpdateCourse request)
        {
            try
            {
                // FINDED
                var dataTable = await courseRepository.GetByIDAsync(id);
                if (dataTable != null)
                {
                    var dataUpdate = mapper.Map(request, dataTable);
                    dataUpdate.UpdatedCl = DateTime.Now;
                    // UPDATE & SAVE
                    courseRepository.Update(dataUpdate);
                    await courseRepository.SaveChangeAsync();
                }
                else
                {
                    logger.LogInformation($" No Course items found");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while updating the Course.");
            }
        }
        public async Task DeleteCourseAsync(int id)
        {
            try
            {
                // FINDED
                var data = await courseRepository.GetByIDAsync(id);
                if (data != null)
                {
                    // DELETE & SAVE
                    courseRepository.Delete(data);
                    await courseRepository.SaveChangeAsync();
                }
                else
                {
                    logger.LogInformation($"No Course found with the id {id}");
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "An error occurred while remove the Course.");
            }
        }
    }
}
