using Microsoft.AspNetCore.Mvc;
using WebStudent.Entities;
using WebStudent.Interface.Service;
using WebStudent.Models;
using WebStudent.Service;
using static WebStudent.Models.CreateCourse;

namespace WebStudent.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;
        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var Course = await courseService.GetAllAsync();
                if (Course == null || !Course.Any())
                {
                    return Ok(new { message = "No Course found" });
                }
                return Ok(new { message = "Successfully retrieved all course ", data = Course });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving all Course it", error = ex.Message });
            }
        }
        [HttpGet("{courseid:int}")]
        public async Task<IActionResult> GetCourseIdAsync(int courseid)
        {
            try
            {
                var Course = await courseService.GetCourseIdAsync(courseid);
                if (Course == null)
                {
                    return NotFound(new { message = $"Course with id {courseid} not found" });
                }
                return Ok(new { message = "Successfully retrieved all Course ", data = Course });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving all Course", error = ex.Message });
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourseAsync(CreateCourse request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                await courseService.CreateCourseAsync(request);
                return Ok(new { message = "Course successfully created" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the crating Course", error = ex.Message });
            }
        }
        [HttpPut("{courseid:int}")]
        public async Task<IActionResult> UpdateCourseAsync(int courseid, UpdateCourse request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var Course = await courseService.GetCourseIdAsync(courseid);
                if (Course == null)
                {
                    return NotFound(new { message = $"Course  with courseid {courseid} not found" });
                }
                await courseService.UpdateCourse(courseid, request);
                return Ok(new { message = $" Course with id {courseid} successfully updated" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"An error occurred while updating Course with id {courseid}", error = ex.Message });
            }
        }
        [HttpDelete("{courseid:int}")]
        public async Task<IActionResult> DeleteCourseAsync(int courseid)
        {
            try
            {
                var Course = await courseService.GetCourseIdAsync(courseid);
                if (Course == null)
                {
                    return NotFound(new { message = $"Course  with courseid  {courseid} not found" });
                }
                await courseService.DeleteCourseAsync(courseid);
                return Ok(new { message = $"Course  with courseid  {courseid} successfully deleted" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = $"An error occurred while deleting Course  with courseid {courseid}", error = ex.Message });
            }
        }
    }
}
