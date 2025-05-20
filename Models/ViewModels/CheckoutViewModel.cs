using System.ComponentModel.DataAnnotations;

public class CheckoutViewModel
{
    [Required(ErrorMessage = "Ad Soyad zorunludur.")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Adres zorunludur.")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Telefon numarası zorunludur.")]
    [Phone(ErrorMessage = "Geçerli bir telefon numarası girin.")]
    public string PhoneNumber { get; set; }


    [Required(ErrorMessage = "Ödeme yöntemi seçiniz.")]
    public string PaymentMethod { get; set; }
}
