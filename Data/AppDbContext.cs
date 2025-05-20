using Microsoft.EntityFrameworkCore;
using FoodECommerce.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace FoodECommerce.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; } 
        public DbSet<Deal> Deals { get; set; }

        public object Restaurant { get; internal set; }
       
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Menus", ImageName = "menüler.png" },
                new Category { Id = 2, Name = "Burgers", ImageName = "burgers.png" },
                new Category { Id = 3, Name = "Desserts", ImageName = "tatlılar.png" },
                new Category { Id = 4, Name = "Beverages", ImageName = "içecekler.png" },
                new Category { Id = 5, Name = "Sauces", ImageName = "soslar.png" },
                new Category { Id = 6, Name = "Kids Menu", ImageName = "kids.png" }
            );
            modelBuilder.Entity<Product>().HasData(
    new Product
    {
        Id = 1,
        Name = "Chicken Royale Menü",
        Description = "Lezzetli tavuk burger menüsü.",
        Price = 250,
        ImageUrl = "images/products/chickenroyalemenü.png",
        CategoryId = 1
    },
      new Product
      {
          Id = 2,
          Name = "Tavuk Burger Menü",
          Description = "Lezzetli tavuk burger menüsü.",
          Price = 215,
          ImageUrl = "images/products/tavukburgermenü.png",
          CategoryId = 1
      },

    new Product
    {
        Id = 3,
        Name = "Spicy Menü",
        Description = "Baharatlı menü seçeneği.",
        Price = 230,
        ImageUrl = "images/products/spicymenü.png",
        CategoryId = 1
    },
    new Product
    {
        Id = 4,
        Name = "Whopper",
        Description = "Klasik burger.",
        Price = 155,
        ImageUrl = "images/products/whopper.png",
        CategoryId = 2
    },
    new Product
    {
        Id = 5,
        Name = "Rodeo Burger",
        Description = "Barbekü soslu burger.",
        Price = 135,
        ImageUrl = "images/products/rodeo.png",
        CategoryId = 2
    },
     new Product
     {
         Id = 6,
         Name = "Tavuklu Burger",
         Description = "Tavuk burger.",
         Price = 120,
         ImageUrl = "images/products/tavuklu.png",
         CategoryId = 2
     },
    new Product
    {
        Id = 7,
        Name = "Ball Mustard",
        Description = "Ballı hardal sos.",
        Price = 6,
        ImageUrl = "images/products/ballımustrad.png",
        CategoryId = 5
    },
    new Product
    {
        Id = 8,
        Name = "Ketçap",
        Description = "Klasik ketçap.",
        Price = 6,
        ImageUrl = "images/products/ketçap.png",
        CategoryId = 5
    },
     new Product
     {
         Id = 9,
         Name = "Mayonez",
         Description = "Klasik mayonez.",
         Price = 6,
         ImageUrl = "images/products/mayonez.png",
         CategoryId = 5
     },
    new Product
    {
        Id = 10,
        Name = "Sundae",
        Description = "Soslu dondurma.",
        Price = 45,
        ImageUrl = "images/products/sundae.png",
        CategoryId = 3
    },
     new Product
     {
         Id = 11,
         Name = "Cookie",
         Description = "Kurabiye",
         Price = 45,
         ImageUrl = "images/products/cookie.png",
         CategoryId = 3
     },
     new Product
     {
         Id = 12,
         Name = "Coca-Cola",
         Description = " Kola",
         Price = 40,
         ImageUrl = "images/products/cocacola.png",
         CategoryId = 4
     },
     new Product
     {
         Id = 13,
         Name = "Fanta",
         Description = "Fanta",
         Price = 40,
         ImageUrl = "images/products/fanta.png",
         CategoryId = 4
     },
        new Product
        {
            Id = 14,
            Name = "Hot Chocolate",
            Description = "Sıcak çikolata",
            Price = 40,
            ImageUrl = "images/products/sıcakçiko.png",
            CategoryId = 4
        },
         new Product
         {
             Id = 15,
             Name = "Kids Menü",
             Description = "Kids cheeseburger menüsü.",
             Price = 165,
             ImageUrl = "images/products/kids2.png",
             CategoryId = 6
         },
         new Product
         {
             Id = 16,
             Name = "Kids Tenders Menü",
             Description = "Kids chicken tenders menüsü.",
             Price = 200,
             ImageUrl = "images/products/kids3.png",
             CategoryId = 6
         }

);
            modelBuilder.Entity<Restaurant>().HasData(
                          new Restaurant { Id = 1, Name = "Food Express", Rating = 5.0M, City = "İstanbul", Latitude = "41.0082", Longitude = "28.9784" },
                          new Restaurant { Id = 2, Name = "Food Express Beşiktaş", City = "İstanbul", Latitude = "41.0438", Longitude = "29.0094" },
                          new Restaurant { Id = 3, Name = "Food Express Bakırköy", City = "İstanbul", Latitude = "40.9760", Longitude = "28.8570" },
                          new Restaurant { Id = 4, Name = "Food Express Ümraniye", City = "İstanbul", Latitude = "41.0165", Longitude = "29.1241" },
                          new Restaurant { Id = 5, Name = "Food Express", Rating = 4.5M, City = "Ankara", Latitude = "39.9334", Longitude = "32.8597" },
                          new Restaurant { Id = 6, Name = "Food Express Kızılay", City = "Ankara", Latitude = "39.9208", Longitude = "32.8541" },
                          new Restaurant { Id = 7, Name = "Food Express Çankaya", City = "Ankara", Latitude = "39.9016", Longitude = "32.8597" },
                          new Restaurant { Id = 8, Name = "Food Express Keçiören", City = "Ankara", Latitude = "40.0071", Longitude = "32.8663" },

                          new Restaurant { Id = 9, Name = "Food Express Alsancak", Rating = 4.8M, City = "İzmir", Latitude = "38.4192", Longitude = "27.1287" },
                          new Restaurant { Id = 10, Name = "Food Express Özlüce", Rating = 4.7M, City = "Bursa", Latitude = "40.1826", Longitude = "29.0668" },
                          new Restaurant { Id = 11, Name = "Food Express Antalya", Rating = 4.6M, City = "Antalya", Latitude = "36.8969", Longitude = "30.7133" },
                          new Restaurant { Id = 12, Name = "Food Express Adana", Rating = 4.9M, City = "Adana", Latitude = "37.0017", Longitude = "35.3213" }
                      );
            modelBuilder.Entity<Deal>().HasData(
                new Deal { Id = 1, Title = "Dondurma", Description = "Yaz aylarına özel .", ImageUrl = "images/deals/dondurmadeal.png" },
                new Deal { Id = 2, Title = "Menü 4 Big King", Description = "Dörtlü Big King + Coca-Cola", ImageUrl = "images/deals/dörtlüdeal.png" },
                new Deal { Id = 3, Title = "Friends Menü", Description = "TavukBurger menü ^KöfteBurger menü.", ImageUrl = "images/deals/ikilideal.png" },
                new Deal { Id = 4, Title = "Rodeoo", Description = "RodeoBurger menü + Onion Fries.", ImageUrl = "images/deals/rodeodeal.png" },
                new Deal { Id = 5, Title = "King 2", Description = "Big King + King Chicken", ImageUrl = "images/deals/kralikili.png" },
                new Deal { Id = 6, Title = "Tripple Whopper", Description = "3 Whopper menü + Coca-Cola", ImageUrl = "images/deals/üçlüwhopper.png" }
            );

        }

    }

}

