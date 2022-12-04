using DotNetCoreRestAPI.Models.Db;
using DotNetCoreRestAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreRestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        [HttpGet(Name = "GetCourses")]
        public async Task<IActionResult> Get()
        {
            var list = await courseRepository.GetAll();
            return Ok(list);
        }
    }
}
