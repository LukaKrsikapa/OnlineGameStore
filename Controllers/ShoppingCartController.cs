using Microsoft.AspNetCore.Mvc;
using ZavrsniRad.Models;
using ZavrsniRad.ViewModels;

namespace ZavrsniRad.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly IGameRepository _gameRepository;

        public ShoppingCartController(ShoppingCart shoppingCart, IGameRepository gameRepository)
        {
            _shoppingCart = shoppingCart;
            _gameRepository = gameRepository;
        }
        public IActionResult Index()
        {
            List<ShoppingCartItem> items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            ShoppingCartViewModel shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                TotalPrice = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int gameId)
        {
            Game game = _gameRepository.AllGames.FirstOrDefault(g => g.Id == gameId);

            if(game != null)
            {
                _shoppingCart.AddToCart(game);
            }
            TempData["GameName"] = game.Name;
            return RedirectToAction("Success");
        }

        public IActionResult Success()
        {
            string gameName = TempData["GameName"] as string;
            ViewBag.Message = gameName;
            return View();
        }
    }
}