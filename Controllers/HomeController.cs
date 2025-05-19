using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FoodECommerce.Models;
using FoodECommerce.Data;
using FoodECommerce.Models.ViewModels;

namespace FoodECommerce.Controllers;

public class HomeController : Controller
{
   
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {

        _context = context;
    }

    public IActionResult Index()
    {
        var categories = _context.Categories.ToList();
        var products = _context.Products.ToList();
        var restaurants = _context.Restaurants.ToList();

        var viewModel = new HomePageViewModel
        {
            Categories = categories,
            Products = products,
            Restaurants = restaurants
        };

        return View(viewModel);
    }
    
    
}
