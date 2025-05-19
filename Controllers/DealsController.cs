using FoodECommerce.Data;
using FoodECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class DealsController : Controller
{
    private readonly AppDbContext _context;

    public DealsController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var deals = _context.Deals.ToList();
        return View(deals);
    }
}
