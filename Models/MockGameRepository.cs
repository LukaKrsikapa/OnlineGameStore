namespace ZavrsniRad.Models
{
    public class MockGameRepository : IGameRepository
    {
        private readonly IGenreRepository _genreRepository = new MockGenreRepository();
        public IEnumerable<Game> AllGames => new List<Game>
        {
            new Game{Id = 1, Name = "Minecraft", Description = "The gameplay of Minecraft offers players a high degree of freedom and creativity. They can gather resources by mining blocks, such as wood, stone, and ores, which can be used to craft tools, weapons, and building materials. The crafting system in Minecraft allows players to combine different resources in a specific pattern to create various items and tools.",
            IsOnSale = false, Price = 19.99M, Thumbnail = "/img/minecraftthumbnail.jpg", GenreId = 1, Genre = _genreRepository.getGenreById(1)},
            new Game{Id = 2, Name = "Golf It", Description = "In Golf It, players navigate through a series of imaginative and challenging mini-golf courses. The game offers a variety of beautifully designed and visually captivating environments, including lush green landscapes, whimsical fantasy worlds, and even unconventional settings like space or underwater.",
            IsOnSale = false, Price = 9.99M, Thumbnail = "/img/GolfItThumbnail.jpeg", GenreId = 5, Genre = _genreRepository.getGenreById(5)},
            new Game{Id = 3, Name = "Tekken 7", Description = "Tekken offers various gameplay modes to cater to different player preferences. The Arcade mode allows players to follow a character-specific story arc, progressing through a series of battles against AI-controlled opponents. The Versus mode enables local multiplayer, pitting players against each other in thrilling head-to-head matches. Tekken also includes an expansive Practice mode, allowing players to hone their skills, learn new moves, and experiment with combos and strategies.",
            IsOnSale = true, Price = 28.45M, Thumbnail = "/img/tekkenthumbnail.jpg", GenreId = 2, Genre = _genreRepository.getGenreById(2)},
            new Game{Id = 4, Name = "Need For Speed: Most Wanted", Description = "In the world of Need for Speed, players step into the shoes of street racers, navigating through vast open-world environments or tightly designed tracks in a variety of exotic, high-performance cars. The franchise offers a mix of both legal and illegal racing experiences, allowing players to compete in sanctioned events or engage in illicit street races.",
            IsOnSale = false, Price = 19.99M, Thumbnail = "/img/nfsmwthumbnail.jpg", GenreId = 3, Genre = _genreRepository.getGenreById(3)},
            new Game{Id = 5, Name = "Super Smash Bros", Description = "The core gameplay of Super Smash Bros. revolves around intense battles between multiple characters on interactive stages. Players control their chosen character and attempt to knock their opponents off the stage to score points and secure victories. The game features a wide array of attacks, special moves, and defensive maneuvers that vary depending on the character being played.",
            IsOnSale = false, Price = 35.99M, Thumbnail = "/img/supersmashbrosthumbnail.webp", GenreId = 2, Genre = _genreRepository.getGenreById(2)},
            new Game{Id = 6, Name = "Assassin's Creed: Black Flag", Description = "The gameplay of Black Flag combines the series' signature historical exploration and stealth mechanics with the new and exhilarating element of naval combat. Players can freely traverse the Caribbean Sea on Edward's ship, the Jackdaw, engaging in intense naval battles, looting enemy vessels, and even boarding enemy ships to engage in close-quarters combat.",
            IsOnSale = true, Price = 8.49M, Thumbnail = "/img/acblackflagthumbnail.jpg", GenreId = 4, Genre = _genreRepository.getGenreById(4)},
            new Game{Id = 7, Name = "Fallout: New Vegas", Description = "Fallout: New Vegas offers a vast and immersive open-world experience. Players can freely explore the expansive desert landscape, encountering various factions, mutated creatures, and morally ambiguous characters along the way. The game presents players with multiple branching paths and a multitude of choices, allowing for a high degree of player agency and influencing the outcome of the story.",
            IsOnSale = false, Price = 9.99M, Thumbnail = "/img/falloutnvthumbnail.jpeg", GenreId = 6, Genre = _genreRepository.getGenreById(6)}
        };

        public IEnumerable<Game> GamesOnSale => AllGames.Where(g => g.IsOnSale == true);

        public IEnumerable<Game> getGamesByGenreId(int genreId)
        {
            return AllGames.Where(g => g.GenreId == genreId);
        }

        public Game getGameById(int id)
        {
            return AllGames.FirstOrDefault(g => g.Id == id);
        }
    }
}
