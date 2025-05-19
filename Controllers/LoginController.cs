using FoodECommerce.Data;
using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    private readonly AppDbContext _context;

    public LoginController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Login(string email, string password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        if (user != null)
        {
            HttpContext.Session.SetString("FullName", user.FullName ?? string.Empty);
            return RedirectToAction("Index", "Home");
        }

        ViewBag.Error = "Geçersiz giriş bilgileri.";
        return View();
    }

    [HttpPost]
    public IActionResult Register(string fullName, string email, string password)
    {
        var user = new User { FullName = fullName, Email = email, Password = password };
        _context.Users.Add(user);
        _context.SaveChanges();
        HttpContext.Session.SetString("FullName", user.FullName);
        return RedirectToAction("Index", "Home");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }
}
