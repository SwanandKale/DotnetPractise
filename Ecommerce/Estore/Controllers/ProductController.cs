using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Estore.Models;
using BLL;
using BOL;

namespace Estore.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["products"]=(List<Product>)ProductManager.GetAllProducts();
        return View();
    }

    public IActionResult Details(int id)
    {
        Console.WriteLine("Id is "+id);
        
         ViewData["product"]=ProductManager.GetProductById(id);
         return View();
    }

    public IActionResult DBProducts()
    {
        ViewData["products"]=(List<Product>)ProductManager.GetAllProductsDatabase();

        return View();
    }

    public IActionResult Dbdetails(int id)
    {
        ViewData["products"]=ProductManager.GetProductsByIdDatabase(id);
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
