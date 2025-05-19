using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodECommerce.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "text")]   // PostgreSQL text tipi
        public string Name { get; set; } = null!;

        [Column(TypeName = "text")]
        public string? Description { get; set; }

        [Column(TypeName = "text")]
        public string? ImageUrl { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
    }
}
