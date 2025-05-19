public class Cart
{
    public int Id { get; set; }

    public string UserId { get; set; }  // Identity kullanıyorsan

    public List<CartItem> CartItems { get; set; } = new List<CartItem>();
}


