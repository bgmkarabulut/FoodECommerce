using FoodECommerce.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize]
public class CartController : Controller
{
    private readonly AppDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public CartController(AppDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [HttpPost]
    public async Task<IActionResult> Add(int productId)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return RedirectToAction("Login", "Account");

        // Kullanıcının sepetini bul
        var cart = _context.Carts
            .Include(c => c.CartItems)
            .FirstOrDefault(c => c.UserId.ToString() == user.Id);

        if (cart == null)
        {
            cart = new Cart { UserId = user.Id, CartItems = new List<CartItem>() };
            _context.Carts.Add(cart);
            await _context.SaveChangesAsync();
        }

        // Ürün daha önce sepete eklenmişse miktarı arttır
        var existingItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);

        if (existingItem != null)
        {
            existingItem.Quantity++;
        }
        else
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                TempData["Error"] = "Ürün bulunamadı.";
                return RedirectToAction("Index");
            }
            cart.CartItems.Add(new CartItem
            {
                ProductId = productId,
                Quantity = 1,
                Product = product
            });
        }

        await _context.SaveChangesAsync();

        TempData["Message"] = "Ürün sepete eklendi.";
        return RedirectToAction("Index");
    }

    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
        {
            return RedirectToAction("Login", "Account");
        }

        var cart = _context.Carts
            .Include(c => c.CartItems)
            .ThenInclude(ci => ci.Product)
            .FirstOrDefault(c => c.UserId == user.Id);

        return View(cart);
    }
}
