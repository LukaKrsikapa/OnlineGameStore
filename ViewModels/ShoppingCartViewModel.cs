using ZavrsniRad.Models;

namespace ZavrsniRad.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public Publisher Publisher { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
