using WebApplication.Models;

namespace WebApplication.ViewModels;

public class StudentCourses
{
    public Student StudentDetails { get; set; }
    public List<Course> Courses { get; set; }
}