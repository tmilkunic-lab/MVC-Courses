using Microsoft.AspNetCore.Mvc;
using MvcCourses.Models;

namespace MvcCourses.Controllers
{
    public class CourseController : Controller
    {
        private readonly ILogger<CourseController> _logger;

        // Sample Course

        private static readonly List<Course> _courses = new()
        {
            new Course { Id = 1, Title = "Data Structures", Credits = 4, Department = Department.Computing, IsOnline = false },
            new Course { Id = 2, Title = "Statistics I",   Credits = 3, Department = Department.Math,      IsOnline = true  },
            new Course { Id = 3, Title = "Microeconomics",  Credits = 3, Department = Department.Business,  IsOnline = false }
        };

        public CourseController(ILogger<CourseController> logger) => _logger = logger;
        public IActionResult Index()
        {
            _logger.LogInformation("GET /Course/Index (count={Count})", _courses.Count);
            return View(_courses); 
        }

        [HttpGet]
        public IActionResult Create()
        {
            _logger.LogInformation("GET /Course/Create");
            return View(new Course());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Course course)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid course submitted: {@Course}", course);
                return View(course);
            }

            course.Id = _courses.Count == 0 ? 1 : _courses.Max(c => c.Id) + 1;
            _courses.Add(course);

            _logger.LogInformation("Course created: {Id} - {Title}", course.Id, course.Title);
            return RedirectToAction(nameof(Index));
        }
    }
}
