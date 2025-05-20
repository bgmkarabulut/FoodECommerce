using Microsoft.EntityFrameworkCore;
using FoodECommerce.Data;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Veritabanı
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
// Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
})
.AddEntityFrameworkStores<AppDbContext>()
.AddDefaultTokenProviders();
// MVC
builder.Services.AddControllersWithViews();

// Session servisini ekle
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
// Authentication
builder.Services.AddAuthentication("Cookies")
    .AddCookie("Cookies", options =>
    {
        options.LoginPath = "/Account/Login";
        options.AccessDeniedPath = "/Account/AccessDenied";
    });
    builder.Services.AddAuthorization();


var app = builder.Build();

// Statik dosyalar
app.UseStaticFiles();

// Session middleware'ini aktif et
app.UseSession();

// Routing
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
// Controller route
app.MapDefaultControllerRoute();

// Uygulamayı başlat
app.Run();
