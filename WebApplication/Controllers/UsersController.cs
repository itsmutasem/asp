using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers;

public class UsersController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}