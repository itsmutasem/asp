using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers;

public class ProductsController : Controller
{
    private List<Product> _peoducts;

    public ProductsController()
    {
        _peoducts = new List<Product>();
        _peoducts.Add(new Product { Id = 1, Name = "Keyboard", Description = "Black Keyboard", Price = 15.99 });
        _peoducts.Add(new Product { Id = 2, Name = "Mouse", Description = "Black Mouse", Price = 10.99 });
        _peoducts.Add(new Product { Id = 3, Name = "Screen", Description = "Wide Screen", Price = 35.99 });
    }
    public IActionResult Index()
    {
        return View(_peoducts);
    }
}