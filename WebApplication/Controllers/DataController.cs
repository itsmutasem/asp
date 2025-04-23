using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers;

public class DataController : Controller
{
    private List<Course> _courses;
    public DataController()
    {
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