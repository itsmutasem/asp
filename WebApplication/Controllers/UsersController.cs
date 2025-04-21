using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers;

public class UsersController : Controller
{
    // GET
    private List<User> _users;

    public UsersController()
    {
        _users = new List<User>();
        CreateTempUsers();
    }

    private void CreateTempUsers()
    {
        User user1 = new User(1)
        {
            Name = "John Doe",
            Email = "john.doe@gmail.com",
            Phone = "0558675850",
            Password = "john.doe"
        };
        User user2 = new User(1)
        {
            Name = "Adam Smith",
            Email = "Adamsmith@gmail.com",
            Phone = "0786004331",
            Password = "adsalhi"
        };
        User user3 = new User(1)
        {
            Name = "Qusai Alexander",
            Email = "Alexander@gmail.com",
            Phone = "0798501869",
            Password = "tafeilih"
        };
        User user4 = new User(1)
        {
            Name = "Ahmad Wilson",
            Email = "ahmad.wilson@gmail.com",
            Phone = "0791234567",
            Password = "waqafi"
        };
        _users.Add(user1);
        _users.Add(user2);
        _users.Add(user3);
        _users.Add(user4);
    }
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