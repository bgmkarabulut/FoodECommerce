using FoodECommerce.Data;
using FoodECommerce.Models;
using FoodECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    private readonly AppDbContext _context;

    public AccountController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Register() => View();

    [HttpPost]
    public async Task<IActionResult> Register(User user)
    {
        if (ModelState.IsValid)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Login");
        }

        return View(user);
    }

    public IActionResult Login() => View();

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

        if (user != null)
        {
            HttpContext.Session.SetString("UserEmail", user.Email ?? string.Empty);
            HttpContext.Session.SetString("FullName", user.FullName);
            return RedirectToAction("Index", "Home");
        }

        ViewBag.Error = "Geçersiz giriş bilgileri";
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }
}
