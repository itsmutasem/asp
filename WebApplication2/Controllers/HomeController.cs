using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

public class HomeController : Controller
{

    private static List<User> _users;
    
    public HomeController()
    {
        _users = new List<User>();
        var admin = new User { Id = 1, Name = "admin",Email = "admin@admin.com", Password = "admin" };
        _users.Add(admin);
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginModel login)
    {
        if (ModelState.IsValid)
        {
            var exsit = _users.FirstOrDefault(x => x.Email == login.Email);
            if (exsit != null)
            {
                if (exsit.Password == login.Password)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            ModelState.AddModelError("", "Invalid username or password");
            return View(login);
        }
        return View(login);
    }

    public IActionResult SignUp()
    {
        return View();
    }

    public IActionResult SignUp(User newUser)
    {
        if (ModelState.IsValid)
        {
            var exit = _users.FirstOrDefault(x => x.Email == newUser.Email);
            if (exit != null)
            {
                ModelState.AddModelError("", "User already exists");
                return View(newUser);
            }

            if (_users.Count > 0)
            {
                newUser.Id = _users.Max(x => x.Id) + 1;
            }
            else
            {
                newUser.Id = 1;
                _users.Add(newUser);
                RedirectToAction(nameof(Login));
            }
        }
        return View(newUser);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}