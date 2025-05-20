using FoodECommerce.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class AccountController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly SignInManager<ApplicationUser> _signInManager;

    public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public IActionResult Register() => View();

   [HttpPost]
public async Task<IActionResult> Register(RegisterViewModel model)
{
    if (ModelState.IsValid)
    {
        var user = new ApplicationUser
        {
            UserName = model.Email,
            Email = model.Email,
            FullName = model.FullName
        };

        var result = await _userManager.CreateAsync(user, model.Password);

        if (result.Succeeded)
        {
            // Otomatik giriş yapma kodu kaldırıldı
            // Giriş sayfasına yönlendir
            TempData["RegisterSuccess"] = "Kayıt başarılı! Giriş yapabilirsiniz.";
            return RedirectToAction("Login", "Account");
        }

        foreach (var error in result.Errors)
            ModelState.AddModelError("", error.Description);
    }

    return View(model);
}


    public IActionResult Login() => View();

    [HttpPost]
public async Task<IActionResult> Login(LoginViewModel model)
{
    if (!ModelState.IsValid)
    {
        return View(model);
    }

  var user = await _userManager.FindByEmailAsync(model.Email);
if (user != null)
{
    var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false);
    
    if (result.Succeeded)
    
        return RedirectToAction("Index", "Home");

    else if (result.IsLockedOut)
        ModelState.AddModelError("", "Hesabınız kilitlenmiş.");

    else if (result.IsNotAllowed)
        ModelState.AddModelError("", "Giriş izniniz yok.");

    else
        ModelState.AddModelError("", "Geçersiz giriş bilgileri.");
}
else
{
    ModelState.AddModelError("", "Geçersiz giriş bilgileri.");
}

return View(model);

}

    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }
}
