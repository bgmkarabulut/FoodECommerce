using FoodECommerce.Data;
using Microsoft.AspNetCore.Mvc;

public class RestaurantsController : Controller
{
    private readonly AppDbContext _context;

    public RestaurantsController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var restaurants = _context.Restaurants.ToList();
        return View(restaurants);
    }
}
