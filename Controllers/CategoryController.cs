using Microsoft.AspNetCore.Mvc;
using FoodECommerce.Data;
using FoodECommerce.Models;
using FoodECommerce.Models.ViewModels;

namespace FoodECommerce.Controllers;

public class CategoryController : Controller
{
    private readonly AppDbContext _context;

    public CategoryController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult ProductsByCategory(int id)
    {
        var category = _context.Categories.FirstOrDefault(c => c.Id == id);
        if (category == null)
        {
            return NotFound();
        }

        var products = _context.Products.Where(p => p.CategoryId == id).ToList();

        var viewModel = new ProductsByCategoryViewModel
        {
            Category = category,
            Products = products
        };

        return View(viewModel);
    }
}
