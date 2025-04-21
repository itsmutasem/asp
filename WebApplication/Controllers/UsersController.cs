using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers;

public class UsersController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult UserDetails()
    {
        User user = new(1)
        {
            Name = "Mutasem",
            Email = "itsmutasem@gmail.com",
            Phone = "0788717057",
            Password = "123"
        };
        return View(user);
    }
}