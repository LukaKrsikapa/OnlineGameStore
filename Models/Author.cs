using System.ComponentModel.DataAnnotations;

namespace ZavrsniRad.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Game> Games { get; set; }
    }
}
