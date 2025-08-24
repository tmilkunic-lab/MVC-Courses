using System.ComponentModel.DataAnnotations;

namespace MvcCourses.Models
{
    public enum Department
    {
        Computing, Math, Business, Arts, Science
    }

    public class Course
    {
        [Key] public int Id { get; set; }

        [Required, StringLength(80)]
        public string Title { get; set; } = string.Empty;

        [Range(0, 10)]
        public int Credits { get; set; }

        [Required]
        public Department Department { get; set; } = Department.Computing;

        [Display(Name = "Online course?")]
        public bool IsOnline { get; set; }
    }
}
