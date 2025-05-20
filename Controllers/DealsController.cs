using FoodECommerce.Data;
using FoodECommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public async Task<IActionResult> Details(int id)
    {
        var deal = await _context.Deals.FirstOrDefaultAsync(d => d.Id == id);
        if (deal == null)
        {
            return NotFound();
        }

        return View(deal);
    }
}
