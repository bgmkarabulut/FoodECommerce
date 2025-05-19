using Microsoft.AspNetCore.Mvc;
using FoodECommerce.Data;
using FoodECommerce.Models;
using FoodECommerce.Data;

namespace FoodECommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
