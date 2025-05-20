using System.ComponentModel.DataAnnotations;

namespace FoodECommerce.Models.ViewModels;
public class RegisterViewModel
{
    [Required]
    public required string FullName { get; set; }
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public required string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Şifre")]
    public required string Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Şifreyi Onayla")]
    [Compare("Password", ErrorMessage = "Şifreler eşleşmiyor.")]
    public required string ConfirmPassword { get; set; }
}
