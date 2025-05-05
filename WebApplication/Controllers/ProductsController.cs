using Microsoft.AspNetCore.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers;

public class ProductsController : Controller
{
    private static List<Product> _peoducts = new List<Product>();
    
    public IActionResult Index()
    {
        return View(_peoducts);
    }

    public IActionResult Details(int id)
    {
        Product product = _peoducts.Find(p => p.Id == id);// Link Query
        return View(product);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Store(Product data)
    {
        if (ModelState.IsValid)
        {
            data.Id = _peoducts.Count + 1;
            _peoducts.Add(data);
            return RedirectToAction(nameof(Index));   
        }
        return View("Create");
    }
}