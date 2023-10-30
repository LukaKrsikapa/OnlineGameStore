namespace ZavrsniRad.Models
{
    public class GenreRepository : IGenreRepository
    {
        private readonly StoreDbContext _dbContext;

        public GenreRepository(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Genre> AllGenres => _dbContext.Genres;

        public Genre getGenreById(int id)
        {
            Genre result = _dbContext.Genres.FirstOrDefault(g => g.Id == id);
            return result;
        }
    }
}
