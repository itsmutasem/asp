using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;
using WebApplication.ViewModels;

namespace WebApplication.Controllers;

public class DataController : Controller
{
    private List<Course> _courses;
    private Student _student;
    private StudentCourses _studentCourses;
    public DataController()
    {
        _student = new Student();
        _student.Id = 1;
        _student.Name = "Qusai";
        _student.GPA = 3.76;
        
        _courses = new List<Course>();
        _courses.Add(new Course() { Id = 1, Name = "PHP" });
        _courses.Add(new Course() { Id = 2, Name = "JS" });
        _courses.Add(new Course() { Id = 3, Name = "C++" });
        
        // View Model student courses
        _studentCourses = new StudentCourses();
        _studentCourses.StudentDetails = _student;
        _studentCourses.Courses = _courses;
    }
    public IActionResult Index()
    {
        return View(_studentCourses);
    }
}