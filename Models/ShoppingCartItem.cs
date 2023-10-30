namespace ZavrsniRad.Models
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public Game Game { get; set; }
        public bool IsInTheCart { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
