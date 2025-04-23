using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers;

public class DataController : Controller
{
    private List<Course> _courses;
    private Student _student;
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
    }
    public IActionResult Index()
    {
        return View(_courses);
    }
}