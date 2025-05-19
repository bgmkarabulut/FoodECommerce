using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodECommerce.Models
{
    public class Category
{
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "text")]
    public string Name { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? ImageName { get; set; }   // Yeni eklenen alan
}

}
