namespace ZavrsniRad.Models
{
    public interface IGameRepository
    {
        IEnumerable<Game> AllGames { get; }
        IEnumerable<Game> GamesOnSale { get; }
        Game getGameById(int id);
        IEnumerable<Game> getGamesByGenreId(int genreId);
    }
}
