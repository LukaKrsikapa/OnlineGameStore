using ZavrsniRad.Models;

namespace ZavrsniRad.ViewModels
{
    public class GenreViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public string GenreDescription { get; set; }
        public IEnumerable<Game> Games { get; set; }
    }
}
