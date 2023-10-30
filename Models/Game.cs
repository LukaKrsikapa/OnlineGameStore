using System.ComponentModel.DataAnnotations;

namespace ZavrsniRad.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsOnSale { get; set; }
        public string Thumbnail { get; set; }
        public bool IsOwned { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

    }
}
