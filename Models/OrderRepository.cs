using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Security.Principal;

namespace ZavrsniRad.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StoreDbContext _storeDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(StoreDbContext storeDbContext, ShoppingCart shoppingCart)
        {
            _storeDbContext = storeDbContext;
            _shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            IEnumerable<ShoppingCartItem> shoppingCartItems = _shoppingCart.ShoppingCartItems;

            order.OrderDetails = new List<OrderDetail>();

            foreach (ShoppingCartItem item in shoppingCartItems)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    isInTheCart = item.IsInTheCart,
                    GameId = item.Game.Id,
                    Price = item.Game.Price
                };

                order.OrderDetails.Add(orderDetail);
            }

            _storeDbContext.Orders.Add(order);
            _storeDbContext.SaveChanges();
        }
    }
}
