using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers;

public class ProductsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}