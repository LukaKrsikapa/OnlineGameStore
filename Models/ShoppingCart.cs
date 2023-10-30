using Microsoft.EntityFrameworkCore;

namespace ZavrsniRad.Models
{
    public class ShoppingCart
    {
        private readonly StoreDbContext _dbContext;

        public string Id { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private ShoppingCart(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;

            StoreDbContext? context = services.GetService<StoreDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { Id = cartId };
        }

        public void AddToCart(Game game)
        {
            var shoppingCartItem =
                    _dbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Game.Id == game.Id && s.ShoppingCartId == Id);

            shoppingCartItem = new ShoppingCartItem
            {
                ShoppingCartId = Id,
                Game = game,
                IsInTheCart = true
            };

            _dbContext.ShoppingCartItems.Add(shoppingCartItem);
            game.IsOwned = true;

            _dbContext.SaveChanges();
        }

        public void RemoveFromCart(Game game)
        {
            var shoppingCartItem =
                    _dbContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Game.Id == game.Id && s.ShoppingCartId == Id);

            if (shoppingCartItem != null)
            {
                _dbContext.ShoppingCartItems.Remove(shoppingCartItem);
            }

            _dbContext.SaveChanges();
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _dbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == Id)
                           .Include(s => s.Game)
                           .Include(s => s.Game.Publisher)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _dbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == Id);

            _dbContext.ShoppingCartItems.RemoveRange(cartItems);

            _dbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _dbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == Id)
                .Select(c => c.Game.Price).Sum();
            return total;
        }
    }
}
