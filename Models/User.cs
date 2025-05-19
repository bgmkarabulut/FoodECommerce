using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    [Column(TypeName = "text")]
    public string? FullName { get; set; }

    [Required]
    [EmailAddress]
    [Column(TypeName = "text")]
    public string? Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [StringLength(100, MinimumLength = 6)]
    public string? Password { get; set; }
}
