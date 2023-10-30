using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using ZavrsniRad.Models;
using ZavrsniRad.ViewModels;

namespace ZavrsniRad.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameRepository _gameRepository;
        private readonly IGenreRepository _genreRepository;

        public GameController(IGameRepository gameRepository, IGenreRepository genreRepository)
        {
            _gameRepository = gameRepository;
            _genreRepository = genreRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult List(int genreId, string? search)
        {
            IEnumerable<Game> model;
            
            if(genreId != 0)
            {
                model = _gameRepository.AllGames.Where(g => g.Genre.Id == genreId);
            }
            else
            {
                model = _gameRepository.AllGames;
            }

            if (search == null)
            {
                return View(model);
            }
            else
            {
                return View(model.Where(g => g.Name.ToLower().Contains(search.ToLower())));
            }
        }

        public ViewResult GenreDetail(int genreId)
        {
            GenreViewModel model = new GenreViewModel {
                GenreDescription = _genreRepository.getGenreById(genreId).Description,
                Games = _gameRepository.getGamesByGenreId(genreId)
            };
            return View(model);
        }
    }
}
