namespace ZavrsniRad.Models
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> AllGenres { get; }
        Genre getGenreById(int id);
    }
}
