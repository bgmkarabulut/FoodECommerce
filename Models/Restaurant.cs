using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodECommerce.Models
{
  public class Restaurant
  {
    [Key]
    [Column("restaurant_id")]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "text")]   // PostgreSQL için uygun tip
    public string Name { get; set; } = null!;

 

    [Column(TypeName = "decimal(18,2)")]
    public decimal Rating { get; set; }

    [Column(TypeName = "text")]
        public string? City { get; set; }

        [Column(TypeName = "text")]
        public string? Latitude { get; set; }  

        [Column(TypeName = "text")]
        public string? Longitude { get; set; } 

  }
          
    
}