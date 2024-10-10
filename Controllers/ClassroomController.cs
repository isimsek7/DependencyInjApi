using Microsoft.AspNetCore.Mvc;
using DependencyInjApi.Services;
using DependencyInjApi.Interfaces;

namespace DependencyInjApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassroomController : ControllerBase
    {
        private readonly IClassroomService _classroomService;

        public ClassroomController(IClassroomService classroomService)
        {
            _classroomService = classroomService;
        }

        [HttpGet]
        public IActionResult GetTeacherInfo()
        {
            var teacherInfo = _classroomService.DisplayTeacherInfo();
            return Ok(teacherInfo);
        }
    }
}
