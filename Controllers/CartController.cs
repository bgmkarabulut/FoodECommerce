using FoodECommerce.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize]
public class CartController : Controller
{
    private readonly AppDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public CartController(AppDbContext context, UserManager<ApplicationUser> userManager)
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

        var cart = _context.Carts
            .Include(c => c.CartItems)
            .FirstOrDefault(c => c.UserId == user.Id);
        
        

        if (cart == null)
        {
            cart = new Cart { UserId = user.Id, CartItems = new List<CartItem>() };
            _context.Carts.Add(cart);
            await _context.SaveChangesAsync();
        }

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
                return RedirectToAction("Index", "Home"); 
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
        return RedirectToAction("Index", "Cart");
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
    [HttpPost]
    public async Task<IActionResult> Remove(int itemId)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return RedirectToAction("Login", "Account");

        var item = await _context.CartItems
            .Include(ci => ci.Cart)
            .FirstOrDefaultAsync(ci => ci.Id == itemId && ci.Cart.UserId == user.Id);

        if (item != null)
        {
            _context.CartItems.Remove(item);
            await _context.SaveChangesAsync();
            TempData["Message"] = "Ürün sepetten kaldırıldı.";
        }

        return RedirectToAction("Index");
    }
    [HttpPost]
    public async Task<IActionResult> ClearCart()
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return RedirectToAction("Login", "Account");

        var cart = _context.Carts
            .Include(c => c.CartItems)
            .FirstOrDefault(c => c.UserId == user.Id);

        if (cart != null)
        {
            _context.CartItems.RemoveRange(cart.CartItems);
            await _context.SaveChangesAsync();
            TempData["Message"] = "Sepet temizlendi.";
        }

        return RedirectToAction("Index");
    }
    [HttpPost]
    public async Task<IActionResult> UpdateQuantity(int itemId, int quantity)
    {
        var user = await _userManager.GetUserAsync(User);
        if (user == null)
            return RedirectToAction("Login", "Account");

        var item = await _context.CartItems
            .Include(ci => ci.Cart)
            .FirstOrDefaultAsync(ci => ci.Id == itemId && ci.Cart.UserId == user.Id);

        if (item != null)
        {
            item.Quantity = quantity;
            await _context.SaveChangesAsync();
            TempData["Message"] = "Ürün miktarı güncellendi.";
        }

        return RedirectToAction("Index");
    }
    
}
