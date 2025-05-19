using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodECommerce.Models
{
    public class Deal
    {
        [Key]
    [Column("restaurant_id")]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "text")]   
    public string Title { get; set; } = null!;

   
 [Column(TypeName = "text")]
        public string? Description { get; set; }
 [Column(TypeName = "text")]
        public string ImageUrl { get; set; } = null!;
    }
}
