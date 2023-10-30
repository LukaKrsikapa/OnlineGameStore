using Microsoft.EntityFrameworkCore;

namespace ZavrsniRad.Models
{
    public class GameRepository : IGameRepository
    {
        private readonly StoreDbContext _dbContext;

        public GameRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Game> AllGames => _dbContext.Games.Include(g => g.Genre);

        public IEnumerable<Game> GamesOnSale => _dbContext.Games.Include(g => g.Genre).Where(g => g.IsOnSale);

        public Game getGameById(int id)
        {
            Game result = _dbContext.Games.FirstOrDefault(g => g.Id == id);
            return result;
        }

        public IEnumerable<Game> getGamesByGenreId(int genreId)
        {
            IEnumerable<Game> result = _dbContext.Games.Where(g => g.GenreId == genreId);
            return result;
        }


    }
}
