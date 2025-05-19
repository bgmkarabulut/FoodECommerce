using FoodECommerce.Models;

namespace FoodECommerce.Models.ViewModels
{
    public class ProductsByCategoryViewModel
    {
        public Category Category { get; set; } = null!;
        public List<Product> Products { get; set; } = new();
    }
}
