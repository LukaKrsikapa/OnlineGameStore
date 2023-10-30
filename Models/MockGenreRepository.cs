namespace ZavrsniRad.Models
{
    public class MockGenreRepository : IGenreRepository
    {
        public IEnumerable<Genre> AllGenres => new List<Genre>
        {
            new Genre{Id = 1, Name = "Survival"},
            new Genre{Id = 2, Name = "Fighter"},
            new Genre{Id = 3, Name = "Racing"},
            new Genre{Id = 4, Name = "Adventure"},
            new Genre{Id = 5, Name = "Sport"},
            new Genre{Id = 6, Name = "RPG"}
        };

        public Genre getGenreById(int id)
        {
            return AllGenres.FirstOrDefault(g => g.Id == id);
        }
    }
}
